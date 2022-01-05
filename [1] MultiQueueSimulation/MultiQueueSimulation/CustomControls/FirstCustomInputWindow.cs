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
        }

        private void Form_Initiator()
        {
            selectionCmb.SelectedIndex = Defaults.SELECTION_METHOD - 1;
            stoppingCriteriaCmb.SelectedIndex = Defaults.STOPPING_CRITERIA - 1;
            switch (Defaults.SELECTION_METHOD)
            {
                case 1:
                    Program.mSystem.SelectionMethod = Enums.SelectionMethod.HighestPriority;
                    break;
                case 2:
                    Program.mSystem.SelectionMethod = Enums.SelectionMethod.Random;
                    break;
                case 3:
                    Program.mSystem.SelectionMethod = Enums.SelectionMethod.LeastUtilization;
                    break;
            }
            switch (Defaults.STOPPING_CRITERIA)
            {
                case 1:
                    Program.mSystem.StoppingCriteria = Enums.StoppingCriteria.NumberOfCustomers;
                    break;
                case 2:
                    Program.mSystem.StoppingCriteria = Enums.StoppingCriteria.SimulationEndTime;
                    break;
            }

            Program.mSystem.NumberOfServers = Defaults.NUMBER_Of_SERVERS;
            numberOfServersTxt.Text = Defaults.NUMBER_Of_SERVERS.ToString();
            for (int i = 0; i < Defaults.NUMBER_Of_SERVERS; ++i)
                Program.mSystem.Servers.Add(new Server(i + 1));

            Program.mSystem.StoppingNumber = Defaults.STOPPING_NUMBER;
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
                Program.mSystem.NumberOfServers = Defaults.NUMBER_Of_SERVERS;
            }
            else
            {
                Program.mSystem.NumberOfServers = int.Parse(numberOfServersTxt.Text.ToString());
                Program.mSystem.Servers.Clear();
                for (int i = 0; i < Program.mSystem.NumberOfServers; ++i)
                    Program.mSystem.Servers.Add(new Server(i + 1));
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
                Program.mSystem.StoppingNumber = int.Parse(stoppingNumberTxt.Text.ToString());
        }

        private void stoppingCriteriaCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int stoppintCriteriaID = stoppingCriteriaCmb.SelectedIndex;
            if (stoppintCriteriaID == 0)
                Program.mSystem.StoppingCriteria = Enums.StoppingCriteria.NumberOfCustomers;
            else
                Program.mSystem.StoppingCriteria = Enums.StoppingCriteria.SimulationEndTime;
        }

        private void selectionCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ServerSelectionID = selectionCmb.SelectedIndex;
            if (ServerSelectionID == 0)
                Program.mSystem.SelectionMethod = Enums.SelectionMethod.HighestPriority;
            else if (ServerSelectionID == 1)
                Program.mSystem.SelectionMethod = Enums.SelectionMethod.Random;
            else 
                Program.mSystem.SelectionMethod = Enums.SelectionMethod.LeastUtilization;
        }
        #endregion

        public void setWelcomeForm(WelcomeForm welcomeForm)
        {
            this.welcomeForm = welcomeForm;
            Form_Initiator();
        }

    }
}
