using NewspaperSellerSimulation;
using NewspaperSellerSimulation.Forms;
using NewspaperSellerSimulation.SimulationCore;
using System.Threading;
using System.Windows.Forms;

namespace MultiQueueSimulation.Forms
{
    public partial class SimulationTableForm : Form
    {

        private Thread thread;

        public SimulationTableForm()
        {
            InitializeComponent();

            new NewspaperSimulator();
            loadDataToGgv();
        }

        private void loadDataToGgv()
        {
            for (int i = 0; i < Program.System.NumOfRecords; ++i)
                 simulationDgv.Rows.Add(
                    Program.System.SimulationTable[i].DayNo,
                    Program.System.SimulationTable[i].RandomNewsDayType,
                    Program.System.SimulationTable[i].NewsDayType,
                    Program.System.SimulationTable[i].RandomDemand,
                    Program.System.SimulationTable[i].Demand,
                    Program.System.SimulationTable[i].DailyCost,
                    Program.System.SimulationTable[i].SalesProfit,
                    Program.System.SimulationTable[i].LostProfit,
                    Program.System.SimulationTable[i].ScrapProfit,
                    Program.System.SimulationTable[i].DailyNetProfit);
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
