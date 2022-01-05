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
            if(Program.mSystem.idleServers.Count != 0)
            {
                serverID = Program.mSystem.idleServers[0].ID;
            }

            // There will be delay...
            else 
            {
                Program.mSystem.waitedCustomers.Add(Program.mSystem.SimulationTable[i]);
                int nearestFinishDiff = int.MaxValue;
                for (int j = 0; j < Program.mSystem.Servers.Count; ++j)
                    if (Program.mSystem.Servers[j].FinishTime - simulationCaseList[i].ArrivalTime < nearestFinishDiff)
                    {
                        nearestFinishDiff = Program.mSystem.Servers[j].FinishTime - simulationCaseList[i].ArrivalTime;
                        simulationCaseList[i].TimeInQueue = nearestFinishDiff;
                        serverID = Program.mSystem.Servers[j].ID;
                    }
            }
        }
    }
}
