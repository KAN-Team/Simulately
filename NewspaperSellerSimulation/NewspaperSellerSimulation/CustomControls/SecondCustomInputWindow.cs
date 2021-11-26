using NewspaperSellerSimulation.Forms;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace MultiQueueSimulation
{
    public partial class SecondCustomInputWindow : UserControl
    {
        private WelcomeForm welcomeForm;
        private Thread thread;

        public SecondCustomInputWindow()
        {
            InitializeComponent();
        }

        #region HELPER_METHODS
        private void setInterarrivalDistribution()
        {
            
        }

        private void setServerServiceTime()
        {
            
        }


        #region TIME_PROBABILITY_COLUMNS_VALIDATION
        private bool isValidDgvs()
        {
            return false;
        }

        private void dgv_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            

        }

        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void Column2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allow number, backspace and dot
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
                e.Handled = true;

            //allow only one dot
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
                e.Handled = true;
        }

        private void validateBtn_Click(object sender, System.EventArgs e)
        {
            // TEST VALIDATION
            if (isValidDgvs())
            {
                MessageBox.Show("VALIDATED SUCCESSFULLY !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion


        #endregion

        public void setWelcomeForm(WelcomeForm welcomeForm)
        {
            this.welcomeForm = welcomeForm;
        }

        public void initializeServersColumns()
        {
            
        }

        public bool simulateData()
        {
            toBeFocusedTxt.Focus();
            if (isValidDgvs())
            {
                setInterarrivalDistribution();
                setServerServiceTime();

                openSumulationTableForm();

                //TestSimulationSystem.testSimulationData();
                return true;
            }
            return false;
        }

        #region OPENING_SIMULATION_TABLE_FORM
        private void openSumulationTableForm()
        {
            thread = new Thread(openSimulationForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            welcomeForm.Close();
        }

        private void openSimulationForm(object obj)
        {
           // Application.Run(new SimulationTableForm());
        }
        #endregion

        private void dayTypeDGV_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            dayTypeDGV.AllowUserToAddRows = false;
        }
    }
}
