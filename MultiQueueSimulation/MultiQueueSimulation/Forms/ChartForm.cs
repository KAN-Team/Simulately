using System;
using System.Threading;
using System.Windows.Forms;

namespace MultiQueueSimulation.Forms
{
    public partial class ChartForm : Form
    {
        private Thread thread;

        public ChartForm()
        {
            InitializeComponent();
        }

        #region HANDLING_FOOTER_NAVIGATION_BUTTONS
        private void backToWelcomeBtn_Click(object sender, EventArgs e)
        {
            openForm(1);
        }

        private void backToSimulation_Click(object sender, EventArgs e)
        {
            openForm(2);
        }

        private void showMesuresBtn_Click(object sender, EventArgs e)
        {
            // openForm(3);

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
                thread = new Thread(openSimulationForm);
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

        private void openSimulationForm(object obj)
        {
            Application.Run(new SimulationTableForm());
        }

        private void openPerformanceMesuresForm(object obj)
        {
            Application.Run(new PerformanceMesuresForm());
        }
        #endregion
        
    }
}
