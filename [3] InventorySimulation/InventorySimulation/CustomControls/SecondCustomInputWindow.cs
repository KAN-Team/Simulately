using InventorySimulation.Forms;
using InventorySimulation;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace InventorySimulation
{
    public partial class SecondCustomInputWindow : UserControl
    {
        private Thread thread;

        public SecondCustomInputWindow()
        {
            InitializeComponent();
        }

        #region DAYTYPE_AND_DEMAND_PROBABILITY
        private bool isValidDgvs()
        {
            // Validate tables

            return true;
        }

        private bool isFirstCol = false;
        private void dayTypeDGV_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            
        }

        private void demandCol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void probabilityCol_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void validateBtn_Click(object sender, System.EventArgs e)
        {
            
        }

        private void dayTypeDGV_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            
        }

        private void getDataReadyForSimulation()
        {
            
        }
        #endregion

        #region OPENING_SIMULATION_TABLE_FORM
        public void openSumulationTableForm(WelcomeForm welcomeForm)
        {
            if (isValidDgvs())
            {
                getDataReadyForSimulation();
                thread = new Thread(openSimulationForm);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                welcomeForm.Close();
            }
        }

        private void openSimulationForm(object obj)
        {
           Application.Run(new SimulationTableForm());
        }
        #endregion

    }
}
