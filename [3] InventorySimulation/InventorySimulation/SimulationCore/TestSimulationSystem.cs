using System.Windows.Forms;

namespace InventorySimulation.SimulationCore
{
    class TestSimulationSystem
    {
        public static void testSimulationData()
        {
            string showConfigurations =
                 "[OrderUpTo] -> " + Program.mSystem.OrderUpTo + "\n"
               + "[ReviewPeriod] -> " + Program.mSystem.ReviewPeriod + "\n"
               + "[StartInventoryQuantity] -> " + Program.mSystem.StartInventoryQuantity + "\n"
               + "[StartLeadDays] -> " + Program.mSystem.StartLeadDays + "\n"
               + "[StartOrderQuantity] -> " + Program.mSystem.StartOrderQuantity + "\n"
               + "[NumberOfDays] -> " + Program.mSystem.NumberOfDays;

            string showDemandDistributions = "";
            for (int i = 0; i < Program.mSystem.DemandDistribution.Count; ++i)
            {
                showDemandDistributions += "[Demand] -> ";
                showDemandDistributions += Program.mSystem.DemandDistribution[i].Value.ToString();
                showDemandDistributions += "   \t";
                showDemandDistributions += "[Probability] -> ";
                showDemandDistributions += Program.mSystem.DemandDistribution[i].Probability.ToString();
                showDemandDistributions += "\n";
            }

            string showLeadDaysDistubution = "";
            for (int i = 0; i < Program.mSystem.LeadDaysDistribution.Count; ++i)
            {
                showLeadDaysDistubution += "[Days] -> ";
                showLeadDaysDistubution += Program.mSystem.LeadDaysDistribution[i].Value.ToString();
                showLeadDaysDistubution += "   \t";
                showLeadDaysDistubution += "[Probability] -> ";
                showLeadDaysDistubution += Program.mSystem.LeadDaysDistribution[i].Probability.ToString();
                showLeadDaysDistubution += "\n";
            }

            MessageBox.Show(showConfigurations, "DATA (Configurations)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(showDemandDistributions, "DATA (DemandDistributions)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(showLeadDaysDistubution, "DATA (LeadDaysDistributions)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
