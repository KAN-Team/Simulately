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
            DisplayTable();
        }

        private void DisplayTable()
        {

        }

        public void CalcInterarrivalDist()
        {
            decimal cumulative = 0;
            int minNum = 1;
            for(int i = 0; i < Program.system.InterarrivalDistribution.Count; ++i)
            {
                cumulative += Program.system.InterarrivalDistribution[i].Probability;
                Program.system.InterarrivalDistribution[i].CummProbability = cumulative;

                Program.system.InterarrivalDistribution[i].MinRange = minNum;
                Program.system.InterarrivalDistribution[i].MaxRange = (int)(cumulative * 100);
                minNum = Program.system.InterarrivalDistribution[i].MaxRange + 1;
            }
        }

        public void CalcServerSeviceTime()
        {
            for (int j = 0; j < Program.system.NumberOfServers; ++j)
            {
                decimal cumulative = 0;
                int minNum = 1;

                for (int i = 0; i < Program.system.Servers[j].TimeDistribution.Count; ++i)
                {
                    cumulative += Program.system.Servers[j].TimeDistribution[i].Probability;
                    Program.system.Servers[j].TimeDistribution[i].CummProbability = cumulative;

                    Program.system.Servers[j].TimeDistribution[i].MinRange = minNum;
                    Program.system.Servers[j].TimeDistribution[i].MaxRange = (int)(cumulative * 100);
                    minNum = Program.system.Servers[j].TimeDistribution[i].MaxRange + 1;
                }
            }
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
