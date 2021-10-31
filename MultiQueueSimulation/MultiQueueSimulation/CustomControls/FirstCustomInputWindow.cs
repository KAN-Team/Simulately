using MultiQueueModels;
using System;
using System.Windows.Forms;

namespace MultiQueueSimulation
{
    public partial class FirstCustomInputWindow : UserControl
    {
        private WelcomeForm WelcomeForm;
        public FirstCustomInputWindow()
        {
            InitializeComponent();
            selectionCmb.SelectedIndex = 0;
            stoppingCriteriaCmb.SelectedIndex = 0;
            Program.system.NumberOfServers = 1;
            Program.system.StoppingNumber = 2;
            Program.system.Servers.Add(new Server(1));
            Program.system.SelectionMethod = Enums.SelectionMethod.HighestPriority;
            Program.system.StoppingCriteria = Enums.StoppingCriteria.NumberOfCustomers;

        }

        private void numberOfServersTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void numberOfServersTxt_TextChanged(object sender, EventArgs e)
        {
            if (numberOfServersTxt.Text == "")
            {
                MessageBox.Show("There Must be at Least 1 Server to Simulate.", "Number of Servers Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numberOfServersTxt.Text = "1";
                Program.system.NumberOfServers = 1;
            }
            else
            {
                Program.system.NumberOfServers = int.Parse(numberOfServersTxt.Text.ToString());
                Program.system.Servers.Clear();
                for (int i = 0; i < Program.system.NumberOfServers; i++)
                {
                    Program.system.Servers.Add(new Server(i+1));
                }
            }
            WelcomeForm.getSecondCustomInput().setColums();
        }

        private void stoppingNumberTxt_TextChanged(object sender, EventArgs e)
        {
            if (stoppingNumberTxt.Text == "" || (int.Parse(stoppingNumberTxt.Text) < 2))
            {
                MessageBox.Show("There Must be at Least:\n2 Customers for NumberOfCustomers \nOR\n2 Clock units for SimulationEndTime", "Stopping Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                stoppingNumberTxt.Text = "2";
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

        public void setWelcomeForm(WelcomeForm welcomeForm)
        {
            this.WelcomeForm = welcomeForm;
        }
    }
}
