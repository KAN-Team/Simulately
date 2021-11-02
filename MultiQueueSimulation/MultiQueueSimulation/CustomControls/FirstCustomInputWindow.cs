using MultiQueueModels;
using MultiQueueSimulation.OOP;
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
            selectionCmb.SelectedIndex = Defaults.SELECTION_METHOD - 1;
            stoppingCriteriaCmb.SelectedIndex = Defaults.STOPPING_CRITERIA - 1;
            switch(Defaults.SELECTION_METHOD)
            {
                case 1:
                    Program.system.SelectionMethod = Enums.SelectionMethod.HighestPriority;
                    break;
                case 2:
                    Program.system.SelectionMethod = Enums.SelectionMethod.Random;
                    break;
                case 3:
                    Program.system.SelectionMethod = Enums.SelectionMethod.LeastUtilization;
                    break;
            }
            switch (Defaults.STOPPING_CRITERIA)
            {
                case 1:
                    Program.system.StoppingCriteria = Enums.StoppingCriteria.NumberOfCustomers;
                    break;
                case 2:
                    Program.system.StoppingCriteria = Enums.StoppingCriteria.SimulationEndTime;
                    break;
            }

            Program.system.NumberOfServers = Defaults.NUMBER_Of_SERVERS;
            for (int i = 0; i < Defaults.NUMBER_Of_SERVERS; ++i)
                Program.system.Servers.Add(new Server(i + 1));
            
            Program.system.StoppingNumber = Defaults.STOPPING_NUMBER;
            stoppingNumberTxt.Text = Defaults.STOPPING_NUMBER.ToString();
        }

        #region HANDLING_INSTANT_VALUE_CHANGES
        private void numberOfServersTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void numberOfServersTxt_TextChanged(object sender, EventArgs e)
        {
            if (numberOfServersTxt.Text == "" || (int.Parse(numberOfServersTxt.Text) < Defaults.NUMBER_Of_SERVERS))
            {
                MessageBox.Show("There Must be at Least " + (Defaults.NUMBER_Of_SERVERS) + " Servers to Simulate.", "Number of Servers Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numberOfServersTxt.Text = Defaults.NUMBER_Of_SERVERS.ToString();
                Program.system.NumberOfServers = Defaults.NUMBER_Of_SERVERS;
            }
            else
            {
                Program.system.NumberOfServers = int.Parse(numberOfServersTxt.Text.ToString());
                Program.system.Servers.Clear();
                for (int i = 0; i < Program.system.NumberOfServers; ++i)
                    Program.system.Servers.Add(new Server(i + 1));
            }

            welcomeForm.getSecondCustomInput().initializeServersColumns();
        }

        private void stoppingNumberTxt_TextChanged(object sender, EventArgs e)
        {
            if (stoppingNumberTxt.Text == "" || (int.Parse(stoppingNumberTxt.Text) < Defaults.STOPPING_NUMBER))
            {
                MessageBox.Show("There Must be at Least:\n" + (Defaults.STOPPING_NUMBER) + " Customers for NumberOfCustomers\nOR\n" + (Defaults.STOPPING_NUMBER) + " Clock units for SimulationEndTime", "Stopping Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                stoppingNumberTxt.Text = Defaults.STOPPING_NUMBER.ToString();
            }
            else
                Program.system.StoppingNumber = int.Parse(stoppingNumberTxt.Text.ToString());
        }

        private void stoppingCriteriaCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int stoppintCriteriaID = stoppingCriteriaCmb.SelectedIndex;
            if (stoppintCriteriaID == 0)
                Program.system.StoppingCriteria = Enums.StoppingCriteria.NumberOfCustomers;
            else
                Program.system.StoppingCriteria = Enums.StoppingCriteria.SimulationEndTime;
        }

        private void selectionCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ServerSelectionID = selectionCmb.SelectedIndex;
            if (ServerSelectionID == 0)
                Program.system.SelectionMethod = Enums.SelectionMethod.HighestPriority;
            else if (ServerSelectionID == 1)
                Program.system.SelectionMethod = Enums.SelectionMethod.Random;
            else 
                Program.system.SelectionMethod = Enums.SelectionMethod.LeastUtilization;
        }
        #endregion

        public void setWelcomeForm(WelcomeForm welcomeForm)
        {
            this.welcomeForm = welcomeForm;
            numberOfServersTxt.Text = Defaults.NUMBER_Of_SERVERS.ToString();
        }

    }
}
