using MultiQueueModels;
using System.Collections.Generic;

namespace MultiQueueSimulation.OOP
{
    class HighestPrioritySelection : ServerSelectionMethod
    {
        public HighestPrioritySelection(List<SimulationCase> simulationCaseList, int i) : base(simulationCaseList, i)
        {
        }

        public override void DetermineServer(int i)
        {
            if(Program.system.idleServers.Count != 0)
            {
                serverID = Program.system.idleServers[0].ID;
            }

            // There will be delay...
            else 
            {
                Program.system.waitedCustomers.Add(Program.system.SimulationTable[i]);
                int nearestFinishDiff = int.MaxValue;
                for (int j = 0; j < Program.system.Servers.Count; ++j)
                    if (Program.system.Servers[j].FinishTime - simulationCaseList[i].ArrivalTime < nearestFinishDiff)
                    {
                        nearestFinishDiff = Program.system.Servers[j].FinishTime - simulationCaseList[i].ArrivalTime;
                        simulationCaseList[i].TimeInQueue = nearestFinishDiff;
                        serverID = Program.system.Servers[j].ID;
                    }
            }
        }
    }
}
