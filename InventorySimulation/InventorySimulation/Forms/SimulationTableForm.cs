using InventorySimulation.SimulationCore;
using System.Threading;
using System.Windows.Forms;

namespace InventorySimulation.Forms
{
    public partial class SimulationTableForm : Form
    {

        private Thread thread;

        public SimulationTableForm()
        {
            InitializeComponent();

            new InventorySimulator();
            loadDataToGgv();
        }

        private void loadDataToGgv()
        {
            for (int i = 0; i < Program.mSystem.SimulationCases.Count; ++i)
            {
                simulationDgv.Rows.Add(
                    Program.mSystem.SimulationCases[i].Day,
                    Program.mSystem.SimulationCases[i].Cycle,
                    Program.mSystem.SimulationCases[i].DayWithinCycle,
                    Program.mSystem.SimulationCases[i].BeginningInventory,
                    Program.mSystem.SimulationCases[i].RandomDemand,
                    Program.mSystem.SimulationCases[i].Demand,
                    Program.mSystem.SimulationCases[i].EndingInventory,
                    Program.mSystem.SimulationCases[i].ShortageQuantity,
                    Program.mSystem.SimulationCases[i].OrderQuantity,
                    Program.mSystem.SimulationCases[i].RandomLeadDays,
                    Program.mSystem.SimulationCases[i].LeadDays,
                    Program.mSystem.SimulationCases[i].DaysUntilOrderArrives
                    );
            }
        }

        #region HANDLING_FOOTER_NAVIGATION_BUTTONS
        private void backToWelcomeBtn_Click(object sender, System.EventArgs e)
        {
            openForm(1); // open Welcome Form
        }

        private void showMesuresBtn_Click(object sender, System.EventArgs e)
        {
            //openForm(3);

            PerformanceMesuresForm performanceMesuresForm = new PerformanceMesuresForm();
            performanceMesuresForm.Show();
        }
        #endregion

        #region OPENING_FORM_WITH_FORM_ID
        private void openForm(int formID)
        {
            if (formID == 1)
                thread = new Thread(openWelcomeForm);
            else
                thread = new Thread(openPerformanceMesuresForm);

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            Close();
        }

        private void openWelcomeForm(object obj)
        {
            Application.Run(new WelcomeForm());
        }

        private void openPerformanceMesuresForm(object obj)
        {
            Application.Run(new PerformanceMesuresForm());
        }
        #endregion
    }
}
