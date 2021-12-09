using System.Windows.Forms;
using InventorySimulation.Forms;

namespace InventorySimulation.Forms
{
    public partial class PerformanceMesuresForm : Form
    {
        public PerformanceMesuresForm()
        {
            InitializeComponent();
            
            fillMeasures();
        }

        private void fillMeasures()
        {
            // ans_1.Text = Program.mSystem.PerformanceMeasures.TotalSalesProfit.ToString();
            // ans_2.Text = Program.mSystem.PerformanceMeasures.TotalLostProfit.ToString();
        }
    }
}
