using MultiQueueModels;
using System.Collections.Generic;

namespace MultiQueueSimulation.OOP
{
    abstract class ServerSelectionMethod
    {
        protected List<SimulationCase> simulationCaseList;
        public int serverID;

        public ServerSelectionMethod(List<SimulationCase> simulationCaseList, int i)
        {
            this.simulationCaseList = simulationCaseList;
            serverID = 0;
            calculateServiceTimeForAllServers(i);
            DetermineServer(i);
        }
      
        private void calculateServiceTimeForAllServers(int i)
        {
            Program.mSystem.idleServers.Clear();

            // Extracting new Idle Servers
            for (int j = 0; j < Program.mSystem.NumberOfServers; ++j)
                if (simulationCaseList[i].ArrivalTime >= Program.mSystem.Servers[j].FinishTime)
                    Program.mSystem.idleServers.Add(Program.mSystem.Servers[j]);
        }

        public abstract void DetermineServer(int i);
    }
}
