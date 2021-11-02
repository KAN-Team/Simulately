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
            random = new Random();
            Program.system.numberOfCustomers = Defaults.STOPPING_NUMBER;
            Program.system.endSimulationTime = Defaults.STOPPING_NUMBER;
            clockTimeArrival = 0;
            selectedServerID = -1;

            if (Program.system.StoppingCriteria == Enums.StoppingCriteria.NumberOfCustomers)
                Program.system.numberOfCustomers = Math.Max(Program.system.numberOfCustomers, Program.system.StoppingNumber);
            else // Unknwon number of customers
            {
                Program.system.numberOfCustomers = int.MaxValue;
                Program.system.endSimulationTime = Math.Max(Program.system.endSimulationTime, Program.system.StoppingNumber);
            }

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
                Program.system.SimulationTable.Add(new SimulationCase());
                setCustomerNumber(i);
                generateRandomDigitsForCustomers(i);
                setTimeBetweenArrivals(i);
                setTimeArrivals(i);
                generateRandomDigitsForServers(i);
                setServerID(i);
                setServerTime(i);
                
                if (isSimulationOver(i)) break;
            }
        }

        private void setCustomerNumber(int i)
        {
            Program.system.SimulationTable[i].CustomerNumber = i + 1;
        }

        private void generateRandomDigitsForCustomers(int i)
        {
            if (i != 0)
                Program.system.SimulationTable[i].RandomInterArrival = random.Next(1, 100);
            else
                Program.system.SimulationTable[i].RandomInterArrival = -1;
        }

        private void setTimeBetweenArrivals(int i)
        {
            if (i != 0)
                for (int j = 0; j < Program.system.InterarrivalDistribution.Count; j++)
                {
                    int minRange = Program.system.InterarrivalDistribution[j].MinRange;
                    int maxRange = Program.system.InterarrivalDistribution[j].MaxRange;
                    int RandomInterarrival = Program.system.SimulationTable[i].RandomInterArrival;
                    if (RandomInterarrival >= minRange && RandomInterarrival <= maxRange)
                    {
                        Program.system.SimulationTable[i].InterArrival = Program.system.InterarrivalDistribution[j].Time;
                        break;
                    }
                }
            
            else
                Program.system.SimulationTable[i].InterArrival = -1;
        }

        private void setTimeArrivals(int i)
        {
            if (i != 0)
            {
                clockTimeArrival += Program.system.SimulationTable[i].InterArrival;
                Program.system.SimulationTable[i].ArrivalTime = clockTimeArrival;
            }
        }

        private void generateRandomDigitsForServers(int i)
        {
            Program.system.SimulationTable[i].RandomService = random.Next(1, 100);
        }

        private void setServerID(int i)
        {
            if(Program.system.SelectionMethod == Enums.SelectionMethod.HighestPriority)
                serverSelectionMethod = new HighestPrioritySelection(Program.system.SimulationTable, i);
            else if (Program.system.SelectionMethod == Enums.SelectionMethod.Random)
                serverSelectionMethod = new RandomSelection(Program.system.SimulationTable, i);
            else
                serverSelectionMethod = new LeastUtilizationSelection(Program.system.SimulationTable, i);

            selectedServerID = serverSelectionMethod.serverID;
            Program.system.SimulationTable[i].AssignedServer = getServerWithID(selectedServerID);
        }

        private void setServerTime(int i)
        {
            int startTime = Math.Max(Program.system.SimulationTable[i].ArrivalTime, Program.system.SimulationTable[i].AssignedServer.FinishTime);
            int serviceTime = getServiceTime(i);
            int endTime = startTime + serviceTime;

            Program.system.SimulationTable[i].StartTime = startTime;
            Program.system.SimulationTable[i].ServiceTime = serviceTime;
            Program.system.SimulationTable[i].EndTime = endTime;

            Program.system.SimulationTable[i].AssignedServer.FinishTime = endTime;
            Program.system.SimulationTable[i].AssignedServer.TotalWorkingTime += serviceTime;
            Server assignedServer = getServerWithID(selectedServerID);
            assignedServer.FinishTime = endTime;
            assignedServer.TotalWorkingTime += serviceTime;
        }

        private int getServiceTime(int i)
        {
            for (int j = 0; j < Program.system.SimulationTable[i].AssignedServer.TimeDistribution.Count; j++)
            {
                int minRange = Program.system.SimulationTable[i].AssignedServer.TimeDistribution[j].MinRange;
                int maxRange = Program.system.SimulationTable[i].AssignedServer.TimeDistribution[j].MaxRange;
                int RandomService = Program.system.SimulationTable[i].RandomService;

                if (RandomService >= minRange && RandomService <= maxRange)
                    return Program.system.SimulationTable[i].AssignedServer.TimeDistribution[j].Time;
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

        private bool isSimulationOver(int i)
        {
            if (Program.system.StoppingCriteria == Enums.StoppingCriteria.SimulationEndTime)
                if (clockTimeArrival >= Program.system.endSimulationTime)
                {
                    Program.system.SimulationTable.RemoveAt(i);
                    Program.system.numberOfCustomers = i;
                    return true;
                }
            return false;
        }
        #endregion

    }
}
