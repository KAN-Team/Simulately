using MultiQueueSimulation.OOP;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace MultiQueueSimulation.Forms
{
    public partial class SimulationTableForm : Form
    {

        private Thread thread;
        private readonly CustomerServerSimulator simulator;

        public SimulationTableForm()
        {
            InitializeComponent();

            simulator = new CustomerServerSimulator();
            loadDataToGgv();
            simulationDgv.Columns["customerNumber"].DefaultCellStyle.BackColor = Color.Goldenrod;
        }

        private void loadDataToGgv()
        {
            for (int i = 0; i < Program.system.numberOfCustomers; ++i)
                simulationDgv.Rows.Add(
                    simulator.simulationCaseList[i].CustomerNumber,
                    simulator.simulationCaseList[i].RandomInterArrival,
                    simulator.simulationCaseList[i].InterArrival,
                    simulator.simulationCaseList[i].ArrivalTime,
                    simulator.simulationCaseList[i].RandomService,
                    simulator.simulationCaseList[i].AssignedServer.ID,
                    simulator.simulationCaseList[i].StartTime,
                    simulator.simulationCaseList[i].ServiceTime,
                    simulator.simulationCaseList[i].EndTime,
                    simulator.simulationCaseList[i].TimeInQueue);
        }

        #region HANDLING_FOOTER_NAVIGATION_BUTTONS
        private void backToWelcomeBtn_Click(object sender, System.EventArgs e)
        {
            openForm(1); // open Welcome Form
        }

        private void chartBtn_Click(object sender, System.EventArgs e)
        {
            openForm(2); // open Chart Form
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
            else if (formID == 2)
                thread = new Thread(openChartForm);
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

        private void openChartForm(object obj)
        {
            Application.Run(new ChartForm());
        }

        private void openPerformanceMesuresForm(object obj)
        {
            Application.Run(new PerformanceMesuresForm());
        }
        #endregion

    }
}
