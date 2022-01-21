using InventorySimulation.Forms;
using InventoryModels;
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
            // Validate Lead Days Table
            decimal sumOfProbabilities = 0;
            for (int i = leadDaysDGV.Rows.Count - 2; i >= 0; --i)
            {
                decimal res = validateRow(leadDaysDGV, i, sumOfProbabilities);
                if (res == -8) continue; // empty row
                else if (res == -1) return false; // empty fields
                sumOfProbabilities = res;
            }

            if (sumOfProbabilities != 1)
            {
                MessageBox.Show("Sum of Probabilities Must be Equal (1) !!", "Lead Days Table Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validate Demand table
            sumOfProbabilities = 0;
            for (int i = demandDGV.Rows.Count - 2; i >= 0; --i)
            {
                decimal res = validateRow(demandDGV, i, sumOfProbabilities);
                if (res == -8) continue; // empty row
                else if (res == -1) return false; // empty fields
                sumOfProbabilities = res;
            }

            if (sumOfProbabilities != 1)
            {
                MessageBox.Show("Sum of Probabilities Must be Equal (1) !!", "Demand Table Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private decimal validateRow(DataGridView DGV, int rowIdx, decimal sumOfProbabilities)
        {
            DataGridViewRow row = DGV.Rows[rowIdx];

            bool emptyRow = true;
            for (int col = 0; col < DGV.Columns.Count; ++col)
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
                DGV.Rows.Remove(row);
                return -8;
            }

            for (int col = 0; col < DGV.Columns.Count; ++col)
            {
                if (row.Cells[col].Value == null) row.Cells[col].Value = "";
                if (row.Cells[col].Value.ToString().Equals(""))
                {
                    MessageBox.Show("Please Fill the Empty Fields !!", DGV.AccessibleName + " Table Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }

                if (col > 0)
                    sumOfProbabilities += decimal.Parse(row.Cells[col].Value.ToString());
            }

            return sumOfProbabilities;
        }

        private bool isFirstCol = false;
        private void leadDaysDGV_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv.CurrentCell.ColumnIndex == 0) // First Column in any DGV
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    if (isFirstCol)
                        tb.KeyPress -= new KeyPressEventHandler(demandCol_KeyPress);
                    else
                        tb.KeyPress -= new KeyPressEventHandler(probabilityCol_KeyPress);
                    tb.KeyPress += new KeyPressEventHandler(demandCol_KeyPress);

                    isFirstCol = true;
                }
            }

            else // Probability Column
            {
                TextBox tb2 = e.Control as TextBox;
                if (tb2 != null)
                {
                    if (isFirstCol)
                        tb2.KeyPress -= new KeyPressEventHandler(demandCol_KeyPress);
                    else
                        tb2.KeyPress -= new KeyPressEventHandler(probabilityCol_KeyPress);
                    tb2.KeyPress += new KeyPressEventHandler(probabilityCol_KeyPress);

                    isFirstCol = false;
                }

            }
        }

        private void demandCol_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allow only integers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void probabilityCol_KeyPress(object sender, KeyPressEventArgs e)
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

        private void getDataReadyForSimulation()
        {
            // Storing Lead Days Distributions values...
            foreach (DataGridViewRow row in leadDaysDGV.Rows)
            {
                if (row.Cells[0].Value == null) break;
                Distribution dist = new Distribution();
                dist.Value = int.Parse(row.Cells[0].Value.ToString());
                dist.Probability = decimal.Parse(leadDaysDGV.Rows[0].Cells[1].Value.ToString()) * 100;
                dist.CummProbability = decimal.Parse(leadDaysDGV.Rows[0].Cells[1].Value.ToString()) * 100;
                if (row == leadDaysDGV.Rows[0]) dist.MinRange = 1;
                dist.MaxRange = (int)dist.CummProbability;
                Program.mSystem.LeadDaysDistribution.Add(dist);
            }

            // Storing Demand Distributions values...
            foreach (DataGridViewRow row in demandDGV.Rows)
            {
                if (row.Cells[0].Value == null) break;
                Distribution dist = new Distribution();
                dist.Value = int.Parse(row.Cells[0].Value.ToString()); ;
                dist.Probability = decimal.Parse(row.Cells[1].Value.ToString()) * 100;
                dist.CummProbability = decimal.Parse(row.Cells[1].Value.ToString()) * 100;
                if (row == leadDaysDGV.Rows[0]) dist.MinRange = 1;
                dist.MaxRange = (int)dist.CummProbability;
                Program.mSystem.DemandDistribution.Add(dist);
            }
        }
        #endregion

        #region OPENING_SIMULATION_TABLE_FORM
        public void openSumulationTableForm(WelcomeForm welcomeForm)
        {
            toBeFocusedTxt.Focus();
            try
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
            catch
            {
                MessageBox.Show("An error was encountered while validating the entered data!!", "VALIDATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openSimulationForm(object obj)
        {
           Application.Run(new SimulationTableForm());
        }
        #endregion
        
    }
}
