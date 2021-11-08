using MultiQueueModels;
using System.Collections.Generic;

namespace MultiQueueSimulation.OOP
{
    class LeastUtilizationSelection : ServerSelectionMethod
    {
        public LeastUtilizationSelection(List<SimulationCase> simulationCaseList, int i) : base(simulationCaseList, i)
        {

        }
        public override void DetermineServer(int i)
        {
            if (Program.system.idleServers.Count != 0)
            {
                getLeastUtilized(Program.system.idleServers);
            }

            // There will be delay...
            else
            {
                Program.system.waitedCustomers.Add(Program.system.SimulationTable[i]);
                List<Server> eligibleServers = new List<Server>();
                int nearestFinishDiff = int.MaxValue;
                for (int j = 0; j < Program.system.Servers.Count; ++j)
                    if (Program.system.Servers[j].FinishTime - simulationCaseList[i].ArrivalTime < nearestFinishDiff)
                    {
                        eligibleServers.Clear();
                        eligibleServers.Add(Program.system.Servers[j]);
                        nearestFinishDiff = Program.system.Servers[j].FinishTime - simulationCaseList[i].ArrivalTime;
                        simulationCaseList[i].TimeInQueue = nearestFinishDiff;
                        serverID = Program.system.Servers[j].ID;
                    }
                    else if (Program.system.Servers[j].FinishTime - simulationCaseList[i].ArrivalTime == nearestFinishDiff)
                        eligibleServers.Add(Program.system.Servers[j]);

                getLeastUtilized(eligibleServers);
            }
        }

        private void getLeastUtilized(List<Server> servers)
        {
            int leastUtilized = int.MaxValue;
            for (int j = 0; j < servers.Count; ++j)
                if (servers[j].TotalWorkingTime < leastUtilized)
                {
                    leastUtilized = servers[j].TotalWorkingTime;
                    serverID = servers[j].ID;
                }
        }

    }
}
