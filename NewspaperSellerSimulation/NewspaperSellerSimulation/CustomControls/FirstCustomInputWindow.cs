using NewspaperSellerSimulation.Forms;
using System;
using System.Windows.Forms;

namespace MultiQueueSimulation
{
    public partial class FirstCustomInputWindow : UserControl
    {
        private WelcomeForm welcomeForm;

        public FirstCustomInputWindow()
        {
            InitializeComponent();
        }

        private void Form_Initiator()
        {
            
        }

        #region HANDLING_INSTANT_VALUE_CHANGES
        private void numberOfServersTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void numberOfServersTxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void stoppingCriteriaCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void selectionCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        #endregion

        public void setWelcomeForm(WelcomeForm welcomeForm)
        {
            this.welcomeForm = welcomeForm;
            Form_Initiator();
        }

    }
}
