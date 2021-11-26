using System.Windows.Forms;

namespace NewspaperSellerSimulation.SimulationCore
{
    class TestSimulationSystem
    {
        public static void testSimulationData()
        {
            string showConfigurations =
                 "[NumOfNewspapers] -> " + Program.system.NumOfNewspapers + "\n"
               + "[NumOfRecords] -> " + Program.system.NumOfRecords + "\n"
               + "[PurchasePrice] -> " + Program.system.PurchasePrice + "\n"
               + "[ScrapPrice] -> " + Program.system.ScrapPrice + "\n"
               + "[SellingPrice] -> " + Program.system.SellingPrice;

            string showDayTypeDistributions = "";
            for (int i = 0; i < Program.system.DayTypeDistributions.Count; ++i)
            {
                showDayTypeDistributions += "[Day Type] -> ";
                showDayTypeDistributions += Program.system.DayTypeDistributions[i].DayType.ToString();
                showDayTypeDistributions += "   \t";
                showDayTypeDistributions += "[Probability] -> ";
                showDayTypeDistributions += Program.system.DayTypeDistributions[i].Probability.ToString();
                showDayTypeDistributions += "\n";
            }

            string showDemandDistributions = "";
            for (int i = 0; i < Program.system.DemandDistributions.Count; ++i)
            {
                showDemandDistributions += "\nDemand -> " + Program.system.DemandDistributions[i].Demand + "\n\n";
                for (int j = 0; j < 3; ++j)
                {
                    showDemandDistributions += "[Day Type] -> ";
                    showDemandDistributions += Program.system.DemandDistributions[i].DayTypeDistributions[j].DayType.ToString();
                    showDemandDistributions += "   \t";
                    showDemandDistributions += "[Probability] -> ";
                    showDemandDistributions += Program.system.DemandDistributions[i].DayTypeDistributions[j].Probability.ToString();
                    showDemandDistributions += "\n";
                }
            }

            MessageBox.Show(showConfigurations, "DATA (Configurations)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(showDayTypeDistributions, "DATA (DayTypeDistributions)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(showDemandDistributions, "DATA (DemandDistributions)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
