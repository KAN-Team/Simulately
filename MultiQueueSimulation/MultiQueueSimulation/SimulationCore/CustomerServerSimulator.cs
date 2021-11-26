using MultiQueueModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MultiQueueSimulation.OOP
{
    class CustomerServerSimulator
    {
        private SimulationSystem system;
        private ServerSelectionMethod serverSelectionMethod;
        private Server assignedServer;
        private readonly Random random;
        private int selectedServerID;
        private int clockTimeArrival;

        public CustomerServerSimulator()
        {
            if (SimulationSystem.needsCopy) 
                return; 

            random = new Random();
            system = Program.mSystem;
            system.numberOfCustomers = Defaults.STOPPING_NUMBER;
            system.endSimulationTime = Defaults.STOPPING_NUMBER;
            clockTimeArrival = 0;
            selectedServerID = -1;

            if (system.StoppingCriteria == Enums.StoppingCriteria.NumberOfCustomers)
                system.numberOfCustomers = Math.Max(system.numberOfCustomers, system.StoppingNumber);
            else // Unknwon number of customers
            {
                system.numberOfCustomers = int.MaxValue;
                system.endSimulationTime = Math.Max(system.endSimulationTime, system.StoppingNumber);
            }
            
            calcInterarrivalDist();
            calcServiceDist();
            simulateTable();
            calcPerformanceMeasures();
            SimulationSystem.needsCopy = true;
        }

        #region INTERARRIVAL_AND_SERVICE_TIME_DISTRIBUTION
        public void calcInterarrivalDist()
        {
            decimal cumulative = 0;
            int minNum = 1;
            for (int i = 0; i < system.InterarrivalDistribution.Count; ++i)
            {
                cumulative += system.InterarrivalDistribution[i].Probability;
                system.InterarrivalDistribution[i].CummProbability = cumulative;

                system.InterarrivalDistribution[i].MinRange = minNum;
                system.InterarrivalDistribution[i].MaxRange = (int)(cumulative * 100);
                minNum = system.InterarrivalDistribution[i].MaxRange + 1;
            }
        }

        public void calcServiceDist()
        {
            for (int j = 0; j < system.NumberOfServers; ++j)
            {
                decimal cumulative = 0;
                int minNum = 1;

                for (int i = 0; i < system.Servers[j].TimeDistribution.Count; ++i)
                {
                    cumulative += system.Servers[j].TimeDistribution[i].Probability;
                    system.Servers[j].TimeDistribution[i].CummProbability = cumulative;
                    system.Servers[j].TimeDistribution[i].MinRange = minNum;
                    system.Servers[j].TimeDistribution[i].MaxRange = (int)(cumulative * 100);
                    minNum = system.Servers[j].TimeDistribution[i].MaxRange + 1;
                }
            }
        }
        #endregion
        
        #region SIMULATION_TABLE
        private void simulateTable()
        {
            for (int i = 0; i < system.numberOfCustomers; i++)
            {
                system.SimulationTable.Add(new SimulationCase());
                setCustomerNumber(i);
                generateRandomDigitsForCustomers(i);
                setTimeBetweenArrivals(i);
                setTimeArrivals(i);
                generateRandomDigitsForServers(i);
                setServerID(i);
                setServerTime(i);
                
                if (isSimulationOver(i)) break;
            }

            for (int i = 0; i < system.Servers.Count; ++i)
                if (system.Servers[i].FinishTime > system.endSimulationTime)
                    system.endSimulationTime = system.Servers[i].FinishTime;
        }

        private void setCustomerNumber(int i)
        {
            system.SimulationTable[i].CustomerNumber = i + 1;
        }

        private void generateRandomDigitsForCustomers(int i)
        {
            system.SimulationTable[i].RandomInterArrival = random.Next(1, 100);
        }

        private void setTimeBetweenArrivals(int i)
        {
            if (i != 0)
                for (int j = 0; j < system.InterarrivalDistribution.Count; j++)
                {
                    int minRange = system.InterarrivalDistribution[j].MinRange;
                    int maxRange = system.InterarrivalDistribution[j].MaxRange;
                    int RandomInterarrival = system.SimulationTable[i].RandomInterArrival;
                    if (RandomInterarrival >= minRange && RandomInterarrival <= maxRange)
                    {
                        system.SimulationTable[i].InterArrival = system.InterarrivalDistribution[j].Time;
                        break;
                    }
                }
            
            else
                system.SimulationTable[i].InterArrival = -1;
        }

        private void setTimeArrivals(int i)
        {
            if (i != 0)
            {
                clockTimeArrival += system.SimulationTable[i].InterArrival;
                system.SimulationTable[i].ArrivalTime = clockTimeArrival;
            }
        }

        private void generateRandomDigitsForServers(int i)
        {
            system.SimulationTable[i].RandomService = random.Next(1, 100);
        }

        private void setServerID(int i)
        {
            if(system.SelectionMethod == Enums.SelectionMethod.HighestPriority)
                serverSelectionMethod = new HighestPrioritySelection(system.SimulationTable, i);
            else if (system.SelectionMethod == Enums.SelectionMethod.Random)
                serverSelectionMethod = new RandomSelection(system.SimulationTable, i);
            else
                serverSelectionMethod = new LeastUtilizationSelection(system.SimulationTable, i);

            selectedServerID = serverSelectionMethod.serverID;
            assignedServer = getServerWithID(selectedServerID);
            system.SimulationTable[i].AssignedServer = assignedServer;

            assignedServer.NumberOfCustomersServed++;
        }

        private void setServerTime(int i)
        {
            int startTime = Math.Max(system.SimulationTable[i].ArrivalTime, assignedServer.FinishTime);
            int serviceTime = getServiceTime(i);
            int endTime = startTime + serviceTime;

            system.SimulationTable[i].StartTime = startTime;
            system.SimulationTable[i].ServiceTime = serviceTime;
            system.SimulationTable[i].EndTime = endTime;

            assignedServer.FinishTime = endTime;
            assignedServer.TotalWorkingTime += serviceTime;
            assignedServer.WorkingIntervals.Add(new KeyValuePair<int, int>(startTime, endTime));
        }

        private int getServiceTime(int i)
        {
            for (int j = 0; j < assignedServer.TimeDistribution.Count; j++)
            {
                int minRange = assignedServer.TimeDistribution[j].MinRange;
                int maxRange = assignedServer.TimeDistribution[j].MaxRange;
                int RandomService = system.SimulationTable[i].RandomService;

                if (RandomService >= minRange && RandomService <= maxRange)
                    return assignedServer.TimeDistribution[j].Time;
            }
            return 0;
        }

        private Server getServerWithID(int ID)
        {
            for (int i = 0; i < system.Servers.Count; ++i)
                if (system.Servers[i].ID == ID)
                    return system.Servers[i];

            MessageBox.Show("No Server Found with ID = " + ID, "getServer METHOD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }

        private bool isSimulationOver(int i)
        {
            if (system.StoppingCriteria == Enums.StoppingCriteria.SimulationEndTime)
                if (clockTimeArrival > system.endSimulationTime)
                {
                    manageServer(i);
                    system.SimulationTable.RemoveAt(i);
                    system.numberOfCustomers = i;
                    return true;
                }
            return false;
        }

        private void manageServer(int i)
        {
            int lastInterval = system.SimulationTable[i].AssignedServer.WorkingIntervals.Count - 1;
            if (lastInterval > 0)
                system.SimulationTable[i].AssignedServer.FinishTime = system.SimulationTable[i].AssignedServer.WorkingIntervals[lastInterval - 1].Value;
            else
                system.SimulationTable[i].AssignedServer.FinishTime = 0;
            if (system.waitedCustomers[system.waitedCustomers.Count - 1].CustomerNumber == system.SimulationTable[i].CustomerNumber)
                system.waitedCustomers.RemoveAt(system.waitedCustomers.Count - 1);
            system.SimulationTable[i].AssignedServer.TotalWorkingTime -= system.SimulationTable[i].ServiceTime;
            system.SimulationTable[i].AssignedServer.NumberOfCustomersServed--;
            system.SimulationTable[i].AssignedServer.WorkingIntervals.RemoveAt(lastInterval);
        }
        #endregion

        #region PERFORMANCE_MEASURES
        private void calcPerformanceMeasures()
        {
            setAverageWaitingTime();
            setWaitingProbability();
            setMaximumQueueLength();

            setServersIdleProbability();
            setServersAverageServiceTime();
            setServersUtilization();
        }
        
        private void setAverageWaitingTime()
        {
            decimal waitingTimeSum = 0;
            int cases = system.numberOfCustomers;
            for (int i = 0; i < cases; ++i)
                waitingTimeSum += system.SimulationTable[i].TimeInQueue;
            
            system.PerformanceMeasures.AverageWaitingTime = waitingTimeSum / cases;
        }
        private void setWaitingProbability()
        {
            decimal waitProbability = (decimal)(system.waitedCustomers.Count) / system.numberOfCustomers;

            system.PerformanceMeasures.WaitingProbability = waitProbability;
        }
        private void setMaximumQueueLength()
        {
            int maxLength = 0;
            for (int i = 0; i < system.waitedCustomers.Count; ++i)
            {
                int tempLength = 1;
                for (int j = i+1; j < system.waitedCustomers.Count; ++j)
                {
                    if (system.waitedCustomers[i].StartTime > system.waitedCustomers[j].ArrivalTime)
                        tempLength++;
                    else
                        break;
                }
                if (maxLength < tempLength) maxLength = tempLength;
            }

            system.PerformanceMeasures.MaxQueueLength = maxLength;
        }

        private void setServersIdleProbability()
        {
            for (int i = 0; i < system.NumberOfServers; ++i)
            {
                decimal totalIdleTime = system.endSimulationTime - system.Servers[i].TotalWorkingTime;
                system.Servers[i].IdleProbability = totalIdleTime / system.endSimulationTime;
            }
        }
        private void setServersAverageServiceTime()
        {
            for (int i = 0; i < system.NumberOfServers; ++i)
            {
                int customersServed = system.Servers[i].NumberOfCustomersServed;
                if (customersServed != 0)
                {
                    decimal totalWorkingTime = system.Servers[i].TotalWorkingTime;
                    system.Servers[i].AverageServiceTime = totalWorkingTime / customersServed;
                }
                else
                    system.Servers[i].AverageServiceTime = 0;
            }
        }
        private void setServersUtilization()
        {
            for (int i = 0; i < system.NumberOfServers; ++i)
                system.Servers[i].Utilization = (decimal)system.Servers[i].TotalWorkingTime / system.endSimulationTime;
        }
        #endregion
    }
}
