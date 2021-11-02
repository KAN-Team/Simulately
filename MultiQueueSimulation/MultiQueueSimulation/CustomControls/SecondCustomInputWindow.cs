using MultiQueueModels;
using MultiQueueSimulation.Forms;
using MultiQueueSimulation.OOP;
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
            int count = 0;
            foreach (DataGridViewRow row in interarrivalDgv.Rows)
            {
                if (count == interarrivalDgv.Rows.Count-1) break;
                int time = int.Parse(row.Cells[0].Value.ToString());
                decimal prob = (decimal)float.Parse(row.Cells[1].Value.ToString());
                Program.system.InterarrivalDistribution.Add(new TimeDistribution(time, prob));
                count++;
            }
        }

        private void setServerServiceTime()
        {
            int count = 0;
            foreach (DataGridViewRow row in serviceTimeDgv.Rows)
            {
                if (count == serviceTimeDgv.Rows.Count - 1) break;
                for(int i = 0; i < Program.system.NumberOfServers*2; i+=2)
                {
                    int time = int.Parse(row.Cells[i].Value.ToString());
                    decimal prob = (decimal)float.Parse(row.Cells[i+1].Value.ToString());
                    Program.system.Servers[i/2].TimeDistribution.Add(new TimeDistribution(time, prob));
                }
                count++;
            }
        }


        #region TIME_PROBABILITY_COLUMNS_VALIDATION
        private bool isValidDgvs()
        {
            // Validate InterarrivalTime table
            float sumOfProbabilities = 0;
            for (int i = interarrivalDgv.Rows.Count - 2; i >= 0; --i)
            {
                DataGridViewRow row = interarrivalDgv.Rows[i];
                if (row.Cells[0].Value == null) row.Cells[0].Value = "";
                if (row.Cells[1].Value == null) row.Cells[1].Value = "";

                if (row.Cells[0].Value.ToString().Equals("")
                    && row.Cells[1].Value.ToString().Trim().Equals(""))
                {
                    interarrivalDgv.Rows.RemoveAt(i);
                    continue;
                }
                else if (row.Cells[0].Value.ToString().Equals("")
                    || row.Cells[1].Value.ToString().Equals(""))
                {
                    MessageBox.Show("Please Fill the Empty Fields.", "Interarrival Table Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                sumOfProbabilities += float.Parse(row.Cells[1].Value.ToString());
            }

            if (sumOfProbabilities != 1)
            {
                MessageBox.Show("Sum of Probabilities Must be Equal (1) !!", "Interarrival Table Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validate ServiceTime table
            List<float> sumOfProbabilitiesList = new List<float>(new float[serviceTimeDgv.Columns.Count / 2]);
            for (int i = serviceTimeDgv.Rows.Count-2; i >= 0; --i)
            {
                DataGridViewRow row = serviceTimeDgv.Rows[i];

                bool emptyRow = true;
                for (int col = 0; col < serviceTimeDgv.Columns.Count; ++col)
                {
                    if (row.Cells[col].Value == null) row.Cells[col].Value = "";
                    if (!(row.Cells[col].Value.ToString().Equals("")))
                    {
                        emptyRow = false;
                        break;
                    }
                }

                if (emptyRow)
                {
                    serviceTimeDgv.Rows.Remove(row);
                    continue;
                }

                for (int col = 0; col < serviceTimeDgv.Columns.Count; ++col)
                {
                    if (row.Cells[col].Value == null) row.Cells[col].Value = "";
                    if (row.Cells[col].Value.ToString().Equals(""))
                    {
                        MessageBox.Show("Please Fill the Empty Fields.", "ServiceTime Table Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    if (col % 2 != 0)
                        sumOfProbabilitiesList[col / 2] += float.Parse(row.Cells[col].Value.ToString());    
                }
            }

            for (int j = 0; j < sumOfProbabilitiesList.Count; ++j)
                if (sumOfProbabilitiesList[j] != 1)
                {
                    MessageBox.Show("PROB SUM " + sumOfProbabilitiesList[j]);
                    MessageBox.Show("Sum of Probabilities Must be Equal (1) !!\n--> Check Server " + (j + 1) + " Column <--", "ServiceTime Table Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            return true;
        }

        private bool isFirstCol = false;
        private void dgv_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv.CurrentCell.ColumnIndex % 2 == 0) // Time Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    if (isFirstCol)
                        tb.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
                    else 
                        tb.KeyPress -= new KeyPressEventHandler(Column2_KeyPress);
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);

                    isFirstCol = true;
                }
            }

            else // Probability Column
            {
                TextBox tb2 = e.Control as TextBox;
                if (tb2 != null)
                {
                    if (isFirstCol)
                        tb2.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
                    else
                        tb2.KeyPress -= new KeyPressEventHandler(Column2_KeyPress);
                    tb2.KeyPress += new KeyPressEventHandler(Column2_KeyPress);

                    isFirstCol = false;
                }

            }

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
            DataTable dataTable = new DataTable();
            for (int i = 0; i < Program.system.NumberOfServers; ++i)
            {
                dataTable.Columns.Add("Server " + (i + 1) + "\nService Time");
                dataTable.Columns.Add("Server " + (i + 1) + "\nProbability");
            }

            serviceTimeDgv.DataSource = dataTable;
            for (int i = 0; i < serviceTimeDgv.Columns.Count; ++i)
                serviceTimeDgv.Columns[i].HeaderCell.Style.Font =
                        new Font("comic sans ms", 10, FontStyle.Bold);
        }

        public void simulateData()
        {
            toBeFocusedTxt.Focus();
            if (isValidDgvs())
            {
                setInterarrivalDistribution();
                setServerServiceTime();

                openSumulationTableForm();
            }
            
            //TestSimulationSystem.testSimulationData();
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
            Application.Run(new SimulationTableForm());
        }
        #endregion

    }
}
