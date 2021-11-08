using System.Windows.Forms;

namespace MultiQueueSimulation.OOP
{
    class TestSimulationSystem
    {
        public static void testSimulationData()
        {
            string showConfigurations = Program.system.NumberOfServers + " "
                 + Program.system.StoppingNumber + " "
                 + Program.system.StoppingCriteria + " "
                 + Program.system.SelectionMethod;

            string showInterarrivalTime = "";
            for (int i = 0; i < Program.system.InterarrivalDistribution.Count; ++i)
            {
                showInterarrivalTime += " [Time] ";
                showInterarrivalTime += Program.system.InterarrivalDistribution[i].Time.ToString();
                showInterarrivalTime += " [Prob] ";
                showInterarrivalTime += Program.system.InterarrivalDistribution[i].Probability.ToString();
            }

            string showServerServiceTime = "";
            for (int i = 0; i < Program.system.Servers.Count; ++i)
            {
                showServerServiceTime += "\nServer -> " + Program.system.Servers[i].ID + "\n";
                for (int j = 0; j < Program.system.Servers[i].TimeDistribution.Count; ++j)
                {
                    showServerServiceTime += " [Time] ";
                    showServerServiceTime += Program.system.Servers[i].TimeDistribution[j].Time.ToString();
                    showServerServiceTime += " [Prob] ";
                    showServerServiceTime += Program.system.Servers[i].TimeDistribution[j].Probability.ToString();
                }
            }

            MessageBox.Show(showConfigurations, "DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(showInterarrivalTime, "DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(showServerServiceTime, "DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
