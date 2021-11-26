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
            //DailyCost_Label = System.SimulationTable[i].DailyCost;
            for (int i = 0; i < Program.system.NumOfRecords; ++i)
            {
                DailyCost_Label.Text = Program.system.NumOfNewspapers + " * " + Program.system.PurchasePrice + " = " + Program.system.SimulationTable[i].DailyCost;
                simulationDgv.Rows.Add(
                   Program.system.SimulationTable[i].DayNo,
                   Program.system.SimulationTable[i].RandomNewsDayType,
                   Program.system.SimulationTable[i].NewsDayType,
                   Program.system.SimulationTable[i].RandomDemand,
                   Program.system.SimulationTable[i].Demand,
                   Program.system.SimulationTable[i].SalesProfit,
                   Program.system.SimulationTable[i].LostProfit,
                   Program.system.SimulationTable[i].ScrapProfit,
                   Program.system.SimulationTable[i].DailyNetProfit);
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
