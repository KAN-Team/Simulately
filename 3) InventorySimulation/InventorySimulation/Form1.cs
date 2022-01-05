using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using InventoryTesting;
using InventoryModels;
using System.IO;
using System.Reflection;

namespace InventorySimulation
{
    public partial class Form1 : Form
    {
        bool startButtonIsWorking = false;
        public string[] lines = File.ReadAllLines(@"TestCase1.txt");
        public SimulationSystem simulationSystemObject = new SimulationSystem();
        public SimulationCase simulationCaseObject = new SimulationCase();
        public List<int> DaysUntilOrderArrives = new List<int>();
        public SimulationCase SimulationCasesTemp;
        decimal DemDistCummCounter = 0;
        Random rand = new Random();

        int DayCounter = 0;
        int OrderQuantity = 0;
        int ShortQuantity = 0;
        int EndingQuantity = 0;
        int DayWithinCycle = 1;

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < lines.Length; i++)
            {
                if (i == 1)
                    simulationSystemObject.OrderUpTo = int.Parse(lines[i]);
                else if (i == 4)
                    simulationSystemObject.ReviewPeriod = int.Parse(lines[i]);
                else if (i == 7)
                    simulationSystemObject.StartInventoryQuantity = int.Parse(lines[i]);
                else if (i == 10)
                    simulationSystemObject.StartLeadDays = int.Parse(lines[i]);
                else if (i == 13)
                    simulationSystemObject.StartOrderQuantity = int.Parse(lines[i]);
                else if (i == 16)
                    simulationSystemObject.NumberOfDays = int.Parse(lines[i]);
                else if (lines[i] == "DemandDistribution")
                {
                    configureDimandDistribution(i);
                }
                else if (lines[i] == "LeadDaysDistribution")
                {
                    configureLeadDaysDistribution(i);
                }
            }
        }

        private void configureDimandDistribution(int i)
        {
            List<Distribution> DemDist = new List<Distribution>();
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
            simulationSystemObject.DemandDistribution = DemDist;
        }

        private void configureLeadDaysDistribution(int i)
        {
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
            simulationSystemObject.LeadDaysDistribution = LeadDaysDist;
        } 
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private bool checkValidation()
        {
            if (textBox1.Text.Length < 1 || textBox2.Text.Length < 1 || textBox3.Text.Length < 1 || 
                textBox4.Text.Length < 1 || textBox5.Text.Length < 1 || textBox6.Text.Length < 1)
            {
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(!checkValidation() && !startButtonIsWorking)
            {
                MessageBox.Show("Please fill all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DaysUntilOrderArrives.Add(simulationSystemObject.StartLeadDays-1);

            while (DayCounter < simulationSystemObject.NumberOfDays)
            {
                // Initial Static Values Assignment  
                SimulationCasesTemp = new SimulationCase();
                SimulationCasesTemp.Day = DayCounter + 1;
                SimulationCasesTemp.Cycle = GetCycle(SimulationCasesTemp.Day);
                SimulationCasesTemp.RandomDemand = GenerateRandom();
                SimulationCasesTemp.Demand = GetDemand(SimulationCasesTemp.RandomDemand);
                SimulationCasesTemp.LeadDays = 0;
                SimulationCasesTemp.ShortageQuantity = 0;

                // Day Within Cycle 
                workOnDayWithinCycle();

                // Beginning/Ending Inventory 
                workOnBeginningAndEndingInventory();

                // Cycle Order 
                workOnCycleOrder();

                // Lead Days 
                workOnLeadDays();

                // Counters Control
                simulationSystemObject.SimulationCases.Add(SimulationCasesTemp);
                DayWithinCycle++;
                DayCounter++;
            }

            // Set All Negative Values To Zeros
            setAllNegativeValuesToZeroes();

            // Fill Table
            startFillingTable();

            doPerformanceMeasure();

            testProgram();
        }

        private void setAllNegativeValuesToZeroes ()
        {
            for (int i = 0; i < DaysUntilOrderArrives.Count; i++)
            {
                if (DaysUntilOrderArrives[i] < 0)
                {
                    DaysUntilOrderArrives[i] = 0;
                }
            }
        }
        private void workOnLeadDays()
        {
            if (DaysUntilOrderArrives[DayCounter] >= -1)
            {
                DaysUntilOrderArrives.Add(DaysUntilOrderArrives[DayCounter] - 1);
            }
            else
            {
                DaysUntilOrderArrives.Add(0);
            }
        }

        private void workOnDayWithinCycle()
        {
            if (DayWithinCycle != simulationSystemObject.ReviewPeriod)
            {
                DayWithinCycle = DayWithinCycle % simulationSystemObject.ReviewPeriod;
            }
            SimulationCasesTemp.DayWithinCycle = DayWithinCycle;
        }

        private void workOnBeginningAndEndingInventory()
        {
            if (DayCounter == 0)
            {
                SimulationCasesTemp.BeginningInventory = simulationSystemObject.StartInventoryQuantity;
                SimulationCasesTemp.EndingInventory = SimulationCasesTemp.BeginningInventory - SimulationCasesTemp.Demand;
            }
            else
            {
                if (DaysUntilOrderArrives[DayCounter] == -1 && DayCounter / simulationSystemObject.ReviewPeriod == 0)
                {
                    SimulationCasesTemp.BeginningInventory =
                        simulationSystemObject.SimulationCases[DayCounter - 1].EndingInventory
                        + simulationSystemObject.StartOrderQuantity;
                }
                else if (DaysUntilOrderArrives[DayCounter] == -1 && DayCounter / simulationSystemObject.ReviewPeriod != 0 && DayWithinCycle != simulationSystemObject.ReviewPeriod)
                {
                    SimulationCasesTemp.BeginningInventory = simulationSystemObject.SimulationCases[DayCounter - 1].EndingInventory + OrderQuantity;
                }
                else
                {
                    SimulationCasesTemp.BeginningInventory = simulationSystemObject.SimulationCases[DayCounter - 1].EndingInventory;
                }


                SimulationCasesTemp.EndingInventory = EndingQuantity = SimulationCasesTemp.BeginningInventory -
                    (SimulationCasesTemp.Demand + simulationSystemObject.SimulationCases[DayCounter - 1].ShortageQuantity);
            }


            if (SimulationCasesTemp.EndingInventory <= 0)
            {
                SimulationCasesTemp.ShortageQuantity = ShortQuantity = Math.Abs(SimulationCasesTemp.EndingInventory);
                SimulationCasesTemp.EndingInventory = EndingQuantity = 0;
            }
            else
            {
                ShortQuantity = 0;
            }
        }
        private void workOnCycleOrder()
        {
            if (SimulationCasesTemp.DayWithinCycle == 5)
            {
                SimulationCasesTemp.OrderQuantity = OrderQuantity = GetOrderQuantity(
                   EndingQuantity,
                   ShortQuantity);

                SimulationCasesTemp.RandomLeadDays = GenerateRandom();
                SimulationCasesTemp.LeadDays = GetLeadDays(SimulationCasesTemp.RandomLeadDays);
                DaysUntilOrderArrives[DayCounter] = SimulationCasesTemp.LeadDays;
            }
            else
            {
                SimulationCasesTemp.OrderQuantity = 0;
                SimulationCasesTemp.RandomLeadDays = 0;
            }
        }
        private void doPerformanceMeasure ()
        {
            // Performance Measures 
            decimal ShortSum = 0, EndinSum = 0;
            for (int i = 0; i < simulationSystemObject.SimulationCases.Count; i++)
            {
                ShortSum += simulationSystemObject.SimulationCases[i].ShortageQuantity;
                EndinSum += simulationSystemObject.SimulationCases[i].EndingInventory;
            }
            PerformanceMeasures PM = new PerformanceMeasures();
            PM.ShortageQuantityAverage = ShortSum / simulationSystemObject.SimulationCases.Count;
            PM.EndingInventoryAverage = EndinSum / simulationSystemObject.SimulationCases.Count;
            simulationSystemObject.PerformanceMeasures = PM;
        }
        private void testProgram()
        {
            // Testings
            string TM = TestingManager.Test(simulationSystemObject, Constants.FileNames.TestCase1);
            MessageBox.Show(TM);
        }
        
        public int GenerateRandom()
        {
            return rand.Next(1, 101);
        }
        public int GetDemand(int Random)
        {
            for (int i = 0; i < simulationSystemObject.DemandDistribution.Count; i++)
            {
                if (Random >= simulationSystemObject.DemandDistribution[i].MinRange &&
                    Random <= simulationSystemObject.DemandDistribution[i].MaxRange)
                {
                    return simulationSystemObject.DemandDistribution[i].Value;
                }
            }
            return -1;
        }

        private void orderUpToGroup_Enter(object sender, EventArgs e)
        {

        }

        private void startLeadDaysGroup_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
                        startButtonIsWorking = true;
                    }
                    catch
                    {
                        MessageBox.Show("Here is What the Input File Should look like !!\n\n" + fileFormatReadmeText, "Invalid File Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        public int GetLeadDays(int Random)
        {
            for (int i = 0; i < simulationSystemObject.LeadDaysDistribution.Count; i++)
            {
                if (Random >= simulationSystemObject.LeadDaysDistribution[i].MinRange &&
                    Random <= simulationSystemObject.LeadDaysDistribution[i].MaxRange)
                {
                    return simulationSystemObject.LeadDaysDistribution[i].Value;
                }
            }
            return -1;
        }
        public int GetOrderQuantity(int EndingE,int ShortQuantity)
        {
            return OrderQuantity = simulationSystemObject.OrderUpTo - EndingE + ShortQuantity;
        }
        public int GetCycle(int Day)
        {
            if (Day % simulationSystemObject.ReviewPeriod == 0)
            {
                return (Day / simulationSystemObject.ReviewPeriod);
            }
            return (Day / simulationSystemObject.ReviewPeriod) + 1;
        }

        public void fillSimulationTable(DataTable dt)
        {
            dt.Columns.Add("Day");
            dt.Columns.Add("Cycle");
            dt.Columns.Add("Day Within Cycle");
            dt.Columns.Add("Beginning Inventory");
            dt.Columns.Add("Random Digits For Demand");
            dt.Columns.Add("Demand");
            dt.Columns.Add("Ending Inventory");
            dt.Columns.Add("Shortage Quantity");
            dt.Columns.Add("Order Quantity");
            dt.Columns.Add("Random Digits For Lead Time");
            dt.Columns.Add("Lead Time");
            dt.Columns.Add("Days Until Order Arrives");
        }
        public void startFillingTable()
        {
            DataTable dt = new DataTable();
            fillSimulationTable(dt);

            textBox1.Text = simulationSystemObject.OrderUpTo.ToString();
            textBox2.Text = simulationSystemObject.ReviewPeriod.ToString();
            textBox3.Text = simulationSystemObject.StartInventoryQuantity.ToString();
            textBox4.Text = simulationSystemObject.StartLeadDays.ToString();
            textBox5.Text = simulationSystemObject.StartOrderQuantity.ToString();
            textBox6.Text = simulationSystemObject.NumberOfDays.ToString();

            for (int i = 0; i < simulationSystemObject.SimulationCases.Count; i++)
            {
                dt.Rows.Add(
                     simulationSystemObject.SimulationCases[i].Day,
                     simulationSystemObject.SimulationCases[i].Cycle,
                     simulationSystemObject.SimulationCases[i].DayWithinCycle,
                     simulationSystemObject.SimulationCases[i].BeginningInventory,
                     simulationSystemObject.SimulationCases[i].RandomDemand,
                     simulationSystemObject.SimulationCases[i].Demand,
                     simulationSystemObject.SimulationCases[i].EndingInventory,
                     simulationSystemObject.SimulationCases[i].ShortageQuantity,
                     simulationSystemObject.SimulationCases[i].OrderQuantity,
                     simulationSystemObject.SimulationCases[i].RandomLeadDays,
                     simulationSystemObject.SimulationCases[i].LeadDays,
                     DaysUntilOrderArrives[i]
                  );
            }
            dataGridView1.DataSource = dt;
        }
    }
}
