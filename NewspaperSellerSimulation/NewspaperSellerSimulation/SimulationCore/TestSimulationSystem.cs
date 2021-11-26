using System.Windows.Forms;

namespace NewspaperSellerSimulation.SimulationCore
{
    class TestSimulationSystem
    {
        public static void testSimulationData()
        {
            string showConfigurations =
                 "[NumOfNewspapers] -> " + Program.System.NumOfNewspapers + "\n"
               + "[NumOfRecords] -> " + Program.System.NumOfRecords + "\n"
               + "[PurchasePrice] -> " + Program.System.PurchasePrice + "\n"
               + "[ScrapPrice] -> " + Program.System.ScrapPrice + "\n"
               + "[SellingPrice] -> " + Program.System.SellingPrice;

            string showDayTypeDistributions = "";
            for (int i = 0; i < Program.System.DayTypeDistributions.Count; ++i)
            {
                showDayTypeDistributions += "[Day Type] -> ";
                showDayTypeDistributions += Program.System.DayTypeDistributions[i].DayType.ToString();
                showDayTypeDistributions += "   \t";
                showDayTypeDistributions += "[Probability] -> ";
                showDayTypeDistributions += Program.System.DayTypeDistributions[i].Probability.ToString();
                showDayTypeDistributions += "\n";
            }

            string showDemandDistributions = "";
            for (int i = 0; i < Program.System.DemandDistributions.Count; ++i)
            {
                showDemandDistributions += "\nDemand -> " + Program.System.DemandDistributions[i].Demand + "\n\n";
                for (int j = 0; j < 3; ++j)
                {
                    showDemandDistributions += "[Day Type] -> ";
                    showDemandDistributions += Program.System.DemandDistributions[i].DayTypeDistributions[j].DayType.ToString();
                    showDemandDistributions += "   \t";
                    showDemandDistributions += "[Probability] -> ";
                    showDemandDistributions += Program.System.DemandDistributions[i].DayTypeDistributions[j].Probability.ToString();
                    showDemandDistributions += "\n";
                }
            }

            MessageBox.Show(showConfigurations, "DATA (Configurations)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(showDayTypeDistributions, "DATA (DayTypeDistributions)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(showDemandDistributions, "DATA (DemandDistributions)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
