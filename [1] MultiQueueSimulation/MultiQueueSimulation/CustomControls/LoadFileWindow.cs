using MultiQueueModels;
using MultiQueueSimulation.Forms;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace MultiQueueSimulation
{
    public partial class LoadFileWindow : UserControl
    {
        // ========================== Rounding Edges ==========================//
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
        );
        // =====================================================================//

        private WelcomeForm welcomeForm;
        private int FileLineIndex;
        private Thread thread;

        public LoadFileWindow()
        {
            InitializeComponent();

            containerPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            FileLineIndex = 0;
        }

        private void loadFromFileBtn_Click(object sender, EventArgs e)
        {
            string fileFormatReadmeText;
            try
            {
                fileFormatReadmeText = File.ReadAllText(@"..\..\TestCases\ReadMe.txt");
            }
            catch
            {
                fileFormatReadmeText = "Unavilable...";
            }

            using (OpenFileDialog dialog = new OpenFileDialog() { Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*", Multiselect = false })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string FilePath = dialog.FileName;
                    string[] lines = File.ReadAllLines(FilePath);
                    try
                    {
                        setConfigurations(lines);
                        setInterarrivalDistribution(lines);

                        Program.mSystem.Servers.Clear();
                        for (int i = 0; i < Program.mSystem.NumberOfServers; i++)
                            setServerServiceTime(i + 1, lines);

                        openSumulationTableForm();
                    } catch
                    {
                        MessageBox.Show("Here is What the Input File Should look like !!\n\n" + fileFormatReadmeText, "Invalid File Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Testing Data File which you get from the file
                    // TestSimulationSystem.testSimulationData();
                }
            }
        }

        #region HELPER_METHODS
        private void setConfigurations(string[] lines)
        {
            Program.mSystem.NumberOfServers = int.Parse(lines[1]);
            Program.mSystem.StoppingNumber = int.Parse(lines[4]);
            int stoppintCriteriaID = int.Parse(lines[7]);
            int ServerSelectionID = int.Parse(lines[10]);

            if (stoppintCriteriaID == 1)
                Program.mSystem.StoppingCriteria = Enums.StoppingCriteria.NumberOfCustomers;
            else
                Program.mSystem.StoppingCriteria = Enums.StoppingCriteria.SimulationEndTime;

            if (ServerSelectionID == 1)
                Program.mSystem.SelectionMethod = Enums.SelectionMethod.HighestPriority;
            else if (ServerSelectionID == 2)
                Program.mSystem.SelectionMethod = Enums.SelectionMethod.Random;
            else
                Program.mSystem.SelectionMethod = Enums.SelectionMethod.LeastUtilization;
        }

        private void setInterarrivalDistribution(string[] lines)
        {
            for (int i = 13; i < lines.Length; i++)
            {
                if (lines[i] == "") { FileLineIndex = i + 2; break; }

                char[] separator = { ',', ' ' };
                string[] timesAndProbs = lines[i].Split(separator, StringSplitOptions.RemoveEmptyEntries);
                int time = int.Parse(timesAndProbs[0]);
                decimal prob = (decimal)float.Parse(timesAndProbs[1]);
                Program.mSystem.InterarrivalDistribution.Add(new TimeDistribution(time, prob));
            }

        }

        private void setServerServiceTime(int serverID, string[] lines)
        {
            Server newServer = new Server(serverID);
            for (int i = FileLineIndex; i < lines.Length; i++)
            {
                if (lines[i] == "") { FileLineIndex = i + 2; break; }

                char[] separator = { ',', ' ' };
                string[] timesAndProbs = lines[i].Split(separator, StringSplitOptions.RemoveEmptyEntries);
                int time = int.Parse(timesAndProbs[0]);
                decimal prob = (decimal)float.Parse(timesAndProbs[1]);
                newServer.TimeDistribution.Add(new TimeDistribution(time, prob));
            }

            Program.mSystem.Servers.Add(newServer);
        }

        public void setWelcomeForm(WelcomeForm welcomeForm)
        {
            this.welcomeForm = welcomeForm;
        }
        #endregion

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
