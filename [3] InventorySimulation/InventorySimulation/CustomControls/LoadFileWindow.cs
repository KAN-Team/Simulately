using InventoryModels;
using InventorySimulation.Forms;
using InventorySimulation.SimulationCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace InventorySimulation
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
        private Thread thread;

        public LoadFileWindow()
        {
            InitializeComponent();

            containerPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }

        private void loadFromFileBtn_Click(object sender, EventArgs e)
        {
            string fileFormatReadmeText = "";
            try
            {
                string exeFile = (new Uri(Assembly.GetEntryAssembly().CodeBase)).AbsolutePath;
                string exeDir = Path.GetDirectoryName(exeFile);
                string readmeFullPath = Path.Combine(exeDir, @"..\..\TestCases\ReadMe.txt");
                readmeFullPath = readmeFullPath.Replace("%20", " ");
                fileFormatReadmeText = File.ReadAllText(readmeFullPath);
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
                        setDemandDistributions(lines);
                        setLeadDaysDistribution(lines);

                        openSumulationTableForm();
                    } catch
                    {
                        MessageBox.Show("Here is What the Input File Should look like !!\n\n" + fileFormatReadmeText, "Invalid File Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Testing Data which we get from the input file.
                    // TestSimulationSystem.testSimulationData();
                }
            }
        }

        #region HELPER_METHODS
        private void setConfigurations(string[] lines)
        {
            Program.mSystem.OrderUpTo = int.Parse(lines[1]);
            Program.mSystem.ReviewPeriod = int.Parse(lines[4]);
            Program.mSystem.StartInventoryQuantity = int.Parse(lines[7]);
            Program.mSystem.StartLeadDays = int.Parse(lines[10]);
            Program.mSystem.StartOrderQuantity = int.Parse(lines[13]);
            Program.mSystem.NumberOfDays = int.Parse(lines[16]);
        }

        decimal DemDistCummCounter = 0;
        private void setDemandDistributions(string[] lines)
        {
            List<Distribution> DemDist = new List<Distribution>();
            int i = 18;
            for (int j = 0; j < 5; j++)
            {
                i++;
                Distribution DemDistTemp = new Distribution();
                string[] DemRow = lines[i].Trim().Replace(" ", String.Empty).Split(',');
                if (lines[i - 1] == "DemandDistribution")
                {
                    decimal prob = decimal.Parse(DemRow[1]) * 100;
                    DemDistTemp.Value = int.Parse(DemRow[0]);
                    DemDistTemp.Probability = prob;
                    DemDistTemp.CummProbability = (int)prob;
                    DemDistCummCounter += DemDistTemp.CummProbability;
                    DemDistTemp.MinRange = 1;
                    DemDistTemp.MaxRange = (int)prob;
                }
                else
                {
                    decimal prob = decimal.Parse(DemRow[1]) * 100;
                    DemDistTemp.Value = int.Parse(DemRow[0]);
                    DemDistTemp.Probability = prob;
                    DemDistCummCounter = DemDist[j - 1].CummProbability + (int)prob;
                    DemDistTemp.CummProbability = DemDistCummCounter;
                    DemDistTemp.MinRange = DemDist[j - 1].MaxRange + 1;
                    DemDistTemp.MaxRange = (int)DemDistTemp.CummProbability;
                }
                DemDist.Add(DemDistTemp);
            }
            Program.mSystem.DemandDistribution = DemDist;
        }

        private void setLeadDaysDistribution(string[] lines)
        {
            int i = 0;
            for (; i < lines.Length; ++i)
                if (lines[i].Equals("LeadDaysDistribution"))
                    break;

            List<Distribution> LeadDaysDist = new List<Distribution>();
            for (int j = 0; j < 3; j++)
            {
                i++;
                Distribution LeadDaysDistTemp = new Distribution();
                string[] LeadDaysRow = lines[i].Trim().Replace(" ", String.Empty).Split(',');
                if (lines[i - 1] == "LeadDaysDistribution")
                {
                    decimal prob = decimal.Parse(LeadDaysRow[1]) * 100;
                    LeadDaysDistTemp.Value = int.Parse(LeadDaysRow[0]);
                    LeadDaysDistTemp.Probability = prob;
                    LeadDaysDistTemp.CummProbability = (int)prob;
                    DemDistCummCounter += LeadDaysDistTemp.CummProbability;
                    LeadDaysDistTemp.MinRange = 1;
                    LeadDaysDistTemp.MaxRange = (int)prob;
                }
                else
                {
                    decimal prob = decimal.Parse(LeadDaysRow[1]) * 100;
                    LeadDaysDistTemp.Value = int.Parse(LeadDaysRow[0]);
                    LeadDaysDistTemp.Probability = prob;
                    DemDistCummCounter = LeadDaysDist[j - 1].CummProbability + (int)prob;
                    LeadDaysDistTemp.CummProbability = DemDistCummCounter;
                    LeadDaysDistTemp.MinRange = LeadDaysDist[j - 1].MaxRange + 1;
                    LeadDaysDistTemp.MaxRange = (int)LeadDaysDistTemp.CummProbability;

                }
                LeadDaysDist.Add(LeadDaysDistTemp);
            }
            Program.mSystem.LeadDaysDistribution = LeadDaysDist;
        }
        #endregion

        #region OPENING_SIMULATION_TABLE_FORM
        public void setWelcomeForm(WelcomeForm welcomeForm)
        {
            this.welcomeForm = welcomeForm;
        }

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
