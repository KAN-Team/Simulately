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
            if (Program.system.idleServers.Count != 0)
            {
                int randomChoice = random.Next(0, Program.system.idleServers.Count-1);
                serverID = Program.system.idleServers[randomChoice].ID;
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

                int randomChoice = random.Next(0, eligibleServers.Count - 1);
                serverID = eligibleServers[randomChoice].ID;
            }
        }
    }
}
