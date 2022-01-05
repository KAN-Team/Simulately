using InventorySimulation;
using System.Windows.Forms;

namespace InventorySimulation.Forms
{
    public partial class PerformanceMesuresForm : Form
    {
        public PerformanceMesuresForm()
        {
            InitializeComponent();
            EndingInventoryAverageAnsLbl.Text = Program.mSystem.PerformanceMeasures.EndingInventoryAverage.ToString();
            ShortageQuantityAverageAnsLbl.Text = Program.mSystem.PerformanceMeasures.ShortageQuantityAverage.ToString();
        }
    }
}
