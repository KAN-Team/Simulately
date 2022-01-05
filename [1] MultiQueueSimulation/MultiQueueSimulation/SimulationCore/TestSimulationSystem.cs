using System.Windows.Forms;

namespace MultiQueueSimulation.OOP
{
    class TestSimulationSystem
    {
        public static void testSimulationData()
        {
            string showConfigurations = Program.mSystem.NumberOfServers + " "
                 + Program.mSystem.StoppingNumber + " "
                 + Program.mSystem.StoppingCriteria + " "
                 + Program.mSystem.SelectionMethod;

            string showInterarrivalTime = "";
            for (int i = 0; i < Program.mSystem.InterarrivalDistribution.Count; ++i)
            {
                showInterarrivalTime += " [Time] ";
                showInterarrivalTime += Program.mSystem.InterarrivalDistribution[i].Time.ToString();
                showInterarrivalTime += " [Prob] ";
                showInterarrivalTime += Program.mSystem.InterarrivalDistribution[i].Probability.ToString();
            }

            string showServerServiceTime = "";
            for (int i = 0; i < Program.mSystem.Servers.Count; ++i)
            {
                showServerServiceTime += "\nServer -> " + Program.mSystem.Servers[i].ID + "\n";
                for (int j = 0; j < Program.mSystem.Servers[i].TimeDistribution.Count; ++j)
                {
                    showServerServiceTime += " [Time] ";
                    showServerServiceTime += Program.mSystem.Servers[i].TimeDistribution[j].Time.ToString();
                    showServerServiceTime += " [Prob] ";
                    showServerServiceTime += Program.mSystem.Servers[i].TimeDistribution[j].Probability.ToString();
                }
            }

            MessageBox.Show(showConfigurations, "DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(showInterarrivalTime, "DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(showServerServiceTime, "DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
