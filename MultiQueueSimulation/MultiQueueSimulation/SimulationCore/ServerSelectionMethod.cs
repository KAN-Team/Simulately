using MultiQueueModels;
using System.Collections.Generic;
using System.Windows.Forms;

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
            Program.system.idleServers.Clear();

            // Extracting new Idle Servers
            for (int j = 0; j < Program.system.NumberOfServers; ++j)
                if (simulationCaseList[i].ArrivalTime >= Program.system.Servers[j].FinishTime)
                    Program.system.idleServers.Add(Program.system.Servers[j]);
        }

        public abstract void DetermineServer(int i);
    }
}
