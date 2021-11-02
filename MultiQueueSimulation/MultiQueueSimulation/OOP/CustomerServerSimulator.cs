using MultiQueueModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MultiQueueSimulation.OOP
{
    class CustomerServerSimulator
    {
        private ServerSelectionMethod serverSelectionMethod;
        private int selectedServerID;
        private readonly Random random;
        private int clockTimeArrival;

        public CustomerServerSimulator()
        {
            simulationCaseList = new List<SimulationCase>();
            random = new Random();
            Program.system.numberOfCustomers = Defaults.STOPPING_NUMBER;
            clockTimeArrival = 0;
            selectedServerID = -1;

            if (Program.system.StoppingCriteria == Enums.StoppingCriteria.NumberOfCustomers)
                Program.system.numberOfCustomers = Math.Max(Program.system.numberOfCustomers, Program.system.StoppingNumber);

            for (int i = 0; i < Program.system.numberOfCustomers; ++i)
                simulationCaseList.Add(new SimulationCase());

            calcInterarrivalDist();
            calcServiceDist();
            simulateTable();
        }

        #region CALCULATE_INTERARRIVAL_AND_SERVICE_TIME_DISTRIBUTION
        public void calcInterarrivalDist()
        {
            decimal cumulative = 0;
            int minNum = 1;
            for (int i = 0; i < Program.system.InterarrivalDistribution.Count; ++i)
            {
                cumulative += Program.system.InterarrivalDistribution[i].Probability;
                Program.system.InterarrivalDistribution[i].CummProbability = cumulative;

                Program.system.InterarrivalDistribution[i].MinRange = minNum;
                Program.system.InterarrivalDistribution[i].MaxRange = (int)(cumulative * 100);
                minNum = Program.system.InterarrivalDistribution[i].MaxRange + 1;
            }
        }

        public void calcServiceDist()
        {
            for (int j = 0; j < Program.system.NumberOfServers; ++j)
            {
                decimal cumulative = 0;
                int minNum = 1;

                for (int i = 0; i < Program.system.Servers[j].TimeDistribution.Count; ++i)
                {
                    cumulative += Program.system.Servers[j].TimeDistribution[i].Probability;
                    Program.system.Servers[j].TimeDistribution[i].CummProbability = cumulative;
                    Program.system.Servers[j].TimeDistribution[i].MinRange = minNum;
                    Program.system.Servers[j].TimeDistribution[i].MaxRange = (int)(cumulative * 100);
                    minNum = Program.system.Servers[j].TimeDistribution[i].MaxRange + 1;
                }
            }
        }
        #endregion
        
        #region HELPER_METHODS
        private void simulateTable()
        {
            for (int i = 0; i < Program.system.numberOfCustomers; i++)
            {
                setCustomerNumber(i);
                generateRandomDigitsForCustomers(i);
                setTimeBetweenArrivals(i);
                setTimeArrivals(i);
                generateRandomDigitsForServers(i);
                setServerID(i);
                setServerTime(i);
            }
        }

        private void setCustomerNumber(int i)
        {
            simulationCaseList[i].CustomerNumber = i + 1;
        }

        private void generateRandomDigitsForCustomers(int i)
        {
            if (i != 0)
                simulationCaseList[i].RandomInterArrival = random.Next(1, 100);
            else
                simulationCaseList[i].RandomInterArrival = -1;
        }

        private void setTimeBetweenArrivals(int i)
        {
            if (i != 0)
                for (int j = 0; j < Program.system.InterarrivalDistribution.Count; j++)
                {
                    int minRange = Program.system.InterarrivalDistribution[j].MinRange;
                    int maxRange = Program.system.InterarrivalDistribution[j].MaxRange;
                    int RandomInterarrival = simulationCaseList[i].RandomInterArrival;
                    if (RandomInterarrival >= minRange && RandomInterarrival <= maxRange)
                    {
                        simulationCaseList[i].InterArrival = Program.system.InterarrivalDistribution[j].Time;
                        break;
                    }
                }
            
            else
                simulationCaseList[i].InterArrival = -1;
        }

        private void setTimeArrivals(int i)
        {
            if (i != 0)
            {
                clockTimeArrival += simulationCaseList[i].InterArrival;
                simulationCaseList[i].ArrivalTime = clockTimeArrival;
            }
        }

        private void generateRandomDigitsForServers(int i)
        {
            simulationCaseList[i].RandomService = random.Next(1, 100);
        }

        private void setServerID(int i)
        {
            if(Program.system.SelectionMethod == Enums.SelectionMethod.HighestPriority)
                serverSelectionMethod = new HighestPrioritySelection(simulationCaseList, i);
            else if (Program.system.SelectionMethod == Enums.SelectionMethod.Random)
                serverSelectionMethod = new RandomSelection(simulationCaseList, i);
            else
                serverSelectionMethod = new LeastUtilizationSelection(simulationCaseList, i);

            selectedServerID = serverSelectionMethod.serverID;
            simulationCaseList[i].AssignedServer = getServerWithID(selectedServerID);
        }

        private void setServerTime(int i)
        {
            int startTime = Math.Max(simulationCaseList[i].ArrivalTime, simulationCaseList[i].AssignedServer.FinishTime);
            int serviceTime = getServiceTime(i);
            int endTime = startTime + serviceTime;

            simulationCaseList[i].StartTime = startTime;
            simulationCaseList[i].ServiceTime = serviceTime;
            simulationCaseList[i].EndTime = endTime;

            simulationCaseList[i].AssignedServer.FinishTime = endTime;
            simulationCaseList[i].AssignedServer.TotalWorkingTime += serviceTime;
            Server assignedServer = getServerWithID(selectedServerID);
            assignedServer.FinishTime = endTime;
            assignedServer.TotalWorkingTime += serviceTime;
        }

        private int getServiceTime(int i)
        {
            for (int j = 0; j < simulationCaseList[i].AssignedServer.TimeDistribution.Count; j++)
            {
                int minRange = simulationCaseList[i].AssignedServer.TimeDistribution[j].MinRange;
                int maxRange = simulationCaseList[i].AssignedServer.TimeDistribution[j].MaxRange;
                int RandomService = simulationCaseList[i].RandomService;

                if (RandomService >= minRange && RandomService <= maxRange)
                    return simulationCaseList[i].AssignedServer.TimeDistribution[j].Time;
            }
            return 0;
        }

        private Server getServerWithID(int ID)
        {
            for (int i = 0; i < Program.system.Servers.Count; ++i)
                if (Program.system.Servers[i].ID == ID)
                    return Program.system.Servers[i];

            MessageBox.Show("No Server Found with ID = " + ID, "getServer METHOD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }
        #endregion

        public List<SimulationCase> simulationCaseList { get; set; }

    }
}
