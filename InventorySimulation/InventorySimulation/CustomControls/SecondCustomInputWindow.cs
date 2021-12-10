using InventorySimulation.Forms;
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
            // Validate DayType table
            DataGridViewRow row = dayTypeDGV.Rows[0];
            decimal sumOfProbabilities = 0;
            for (int col = 0; col < dayTypeDGV.ColumnCount; ++col)
            {
                if (row.Cells[col].Value == null) row.Cells[col].Value = "";
                if (row.Cells[col].Value.ToString().Equals(""))
                {
                    MessageBox.Show("Please Fill the Empty Fields !!", "DayType Table Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                sumOfProbabilities += decimal.Parse(row.Cells[col].Value.ToString());
            }

            if (sumOfProbabilities != 1)
            {
                MessageBox.Show("Sum of Probabilities Must be Equal (1) !!", "DayType Table Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validate Demand table
            List<decimal> sumOfProbabilitiesList = new List<decimal>(new decimal[3]);
            for (int i = demandDGV.Rows.Count - 2; i >= 0; --i)
            {
                row = demandDGV.Rows[i];

                bool emptyRow = true;
                for (int col = 0; col < demandDGV.Columns.Count; ++col)
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
                    demandDGV.Rows.Remove(row);
                    continue;
                }

                for (int col = 0; col < demandDGV.Columns.Count; ++col)
                {
                    if (row.Cells[col].Value == null) row.Cells[col].Value = "";
                    if (row.Cells[col].Value.ToString().Equals(""))
                    {
                        MessageBox.Show("Please Fill the Empty Fields !!", "Demand Table Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    if (col > 0)
                        sumOfProbabilitiesList[col-1] += decimal.Parse(row.Cells[col].Value.ToString());
                }
            }

            for (int j = 0; j < sumOfProbabilitiesList.Count; ++j)
                if (sumOfProbabilitiesList[j] != 1)
                {
                    string type;
                    if (j == 0)
                        type = "Good Prob";
                    else if (j == 1)
                        type = "Fair Prob";
                    else
                        type = "Poor Prob";

                    MessageBox.Show("Sum of Probabilities Must be Equal (1) !!\n--> Check Column #" + (j + 2) + " " + type + " <--", "Demand Table Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            return true;
        }

        private bool isFirstCol = false;
        private void dayTypeDGV_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (sender == demandDGV && dgv.CurrentCell.ColumnIndex == 0) // Demand Column
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

        private void dayTypeDGV_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            dayTypeDGV.AllowUserToAddRows = false;
        }

        private void getDataReadyForSimulation()
        {
            // Storing DayType Distributions values...
            //decimal goodProb = decimal.Parse(dayTypeDGV.Rows[0].Cells[0].Value.ToString());
            //decimal fairProb = decimal.Parse(dayTypeDGV.Rows[0].Cells[1].Value.ToString());
            //decimal poorProb = decimal.Parse(dayTypeDGV.Rows[0].Cells[2].Value.ToString());
            //Program.mSystem.DayTypeDistributions.Add(new DayTypeDistribution(Enums.DayType.Good, goodProb));
            //Program.mSystem.DayTypeDistributions.Add(new DayTypeDistribution(Enums.DayType.Fair, fairProb));
            //Program.mSystem.DayTypeDistributions.Add(new DayTypeDistribution(Enums.DayType.Poor, poorProb));

            //// Storing Demand Distributions values...
            //foreach (DataGridViewRow row in demandDGV.Rows)
            //{
            //    if (row.Cells[0].Value == null) break;
            //    int demand = int.Parse(row.Cells[0].Value.ToString());
            //    goodProb = decimal.Parse(row.Cells[1].Value.ToString());
            //    fairProb = decimal.Parse(row.Cells[2].Value.ToString());
            //    poorProb = decimal.Parse(row.Cells[3].Value.ToString());
            //    List<DayTypeDistribution> dayTypeDistributions = new List<DayTypeDistribution>();
            //    dayTypeDistributions.Add(new DayTypeDistribution(Enums.DayType.Good, goodProb));
            //    dayTypeDistributions.Add(new DayTypeDistribution(Enums.DayType.Fair, fairProb));
            //    dayTypeDistributions.Add(new DayTypeDistribution(Enums.DayType.Poor, poorProb));

            //    Program.mSystem.DemandDistributions.Add(new DemandDistribution(demand, dayTypeDistributions));
            //}
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

        private void demandDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void interarrivalLbl_Click(object sender, System.EventArgs e)
        {

        }

        private void dayTypeDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
