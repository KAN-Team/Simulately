using InventoryModels;
using InventorySimulation;
using InventorySimulation.Forms;
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
                        setDayTypeDistributions(lines);
                        setDemandDistributions(lines);

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
            //Program.mSystem.NumOfNewspapers = int.Parse(lines[1]);
            //Program.mSystem.NumOfRecords = int.Parse(lines[4]);
            //Program.mSystem.PurchasePrice = decimal.Parse(lines[7]);
            //Program.mSystem.ScrapPrice = decimal.Parse(lines[10]);
            //Program.mSystem.SellingPrice = decimal.Parse(lines[13]);
        }

        private void setDayTypeDistributions(string[] lines)
        {
            
        }

        private void setDemandDistributions(string[] lines)
        {
            
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
