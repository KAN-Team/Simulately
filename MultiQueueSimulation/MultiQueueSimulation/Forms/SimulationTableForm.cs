using System.Windows.Forms;

namespace MultiQueueSimulation.Forms
{
    public partial class SimulationTableForm : Form
    {
        public SimulationTableForm()
        {
            InitializeComponent();
            DisplayTable();
        }

        private void DisplayTable()
        {

        }

        public void CalcInterarrivalDist()
        {
            decimal cumulative = 0;
            int minNum = 1;
            for(int i=0; i <Program.system.InterarrivalDistribution.Count; i++)
            {
                cumulative += Program.system.InterarrivalDistribution[i].Probability;
                Program.system.InterarrivalDistribution[i].CummProbability = cumulative;

                Program.system.InterarrivalDistribution[i].MinRange = minNum;
                Program.system.InterarrivalDistribution[i].MaxRange = (int)(cumulative * 100);
                minNum = Program.system.InterarrivalDistribution[i].MaxRange + 1;
            }
        }

        public void CalcServerSeviceTime()
        {
            for (int j = 0; j < Program.system.NumberOfServers; j++)
            {
                decimal cumulative = 0;
                int minNum = 1;

                for (int i = 0; i < Program.system.Servers[j].TimeDistribution.Count; i++)
                {
                    cumulative += Program.system.Servers[j].TimeDistribution[i].Probability;
                    Program.system.Servers[j].TimeDistribution[i].CummProbability = cumulative;

                    Program.system.Servers[j].TimeDistribution[i].MinRange = minNum;
                    Program.system.Servers[j].TimeDistribution[i].MaxRange = (int)(cumulative * 100);
                    minNum = Program.system.Servers[j].TimeDistribution[i].MaxRange + 1;
                }
            }
        }

    }
}
