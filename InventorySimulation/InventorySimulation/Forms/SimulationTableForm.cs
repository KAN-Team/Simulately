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
            //for (int i = 0; i < Program.mSystem.NumOfRecords; ++i)
            //{
            //    simulationDgv.Rows.Add(
            //       Program.mSystem.SimulationTable[i].DayNo,
            //       Program.mSystem.SimulationTable[i].RandomNewsDayType,
            //       Program.mSystem.SimulationTable[i].NewsDayType,
            //       Program.mSystem.SimulationTable[i].RandomDemand,
            //       Program.mSystem.SimulationTable[i].leadDays,
            //       Program.mSystem.SimulationTable[i].SalesProfit,
            //       Program.mSystem.SimulationTable[i].LostProfit,
            //       Program.mSystem.SimulationTable[i].ScrapProfit,
            //       Program.mSystem.SimulationTable[i].DailyNetProfit);
            //}
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
