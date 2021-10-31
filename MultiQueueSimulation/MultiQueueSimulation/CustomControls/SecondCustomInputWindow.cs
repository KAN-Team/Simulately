using MultiQueueModels;
using MultiQueueSimulation.Forms;
using MultiQueueSimulation.OOP;
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
            setInterarrivalDistribution();
            setServerServiceTime();

            openSumulationTableForm();
            // TestSimulationSystem.testSimulationData();
        }

        #region OPENING_SIMULATION_TABLE_FORM
        private void openSumulationTableForm()
        {
            SimulationTableForm simulationTableForm = new SimulationTableForm();
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
