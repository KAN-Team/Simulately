using MultiQueueModels;
using System;
using System.Collections.Generic;

namespace MultiQueueSimulation.OOP
{
    class RandomSelection : ServerSelectionMethod
    {
        //private Random random;
        public RandomSelection(List<SimulationCase> simulationCaseList, int i) : base(simulationCaseList, i)
        {
            //random = new Random();
        }

        public override void DetermineServer(int i)
        {
            Random random = new Random();
            if (Program.mSystem.idleServers.Count != 0)
            {
                int randomChoice = random.Next(0, Program.mSystem.idleServers.Count-1);
                serverID = Program.mSystem.idleServers[randomChoice].ID;
            }

            // There will be delay...
            else
            {
                Program.mSystem.waitedCustomers.Add(Program.mSystem.SimulationTable[i]);
                List<Server> eligibleServers = new List<Server>();
                int nearestFinishDiff = int.MaxValue;
                for (int j = 0; j < Program.mSystem.Servers.Count; ++j)
                    if (Program.mSystem.Servers[j].FinishTime - simulationCaseList[i].ArrivalTime < nearestFinishDiff)
                    {
                        eligibleServers.Clear();
                        eligibleServers.Add(Program.mSystem.Servers[j]);
                        nearestFinishDiff = Program.mSystem.Servers[j].FinishTime - simulationCaseList[i].ArrivalTime;
                        simulationCaseList[i].TimeInQueue = nearestFinishDiff;
                        serverID = Program.mSystem.Servers[j].ID;
                    }
                    else if (Program.mSystem.Servers[j].FinishTime - simulationCaseList[i].ArrivalTime == nearestFinishDiff)
                        eligibleServers.Add(Program.mSystem.Servers[j]);

                int randomChoice = random.Next(0, eligibleServers.Count - 1);
                serverID = eligibleServers[randomChoice].ID;
            }
        }
    }
}
