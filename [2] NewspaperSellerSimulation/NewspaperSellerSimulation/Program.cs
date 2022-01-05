using System;
using System.Windows.Forms;
using NewspaperSellerModels;
using NewspaperSellerSimulation.Forms;
using NewspaperSellerTesting;

namespace NewspaperSellerSimulation
{
    static class Program
    {
        // Applying Singleton Design Pattern on SimulationSystem Object
        public static SimulationSystem mSystem;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mSystem = new SimulationSystem();
            Application.Run(new WelcomeForm());

            /*System.Threading.Thread.Sleep(500);
            string result = TestingManager.Test(mSystem, Constants.FileNames.TestCase1);
            MessageBox.Show(result);*/
        }
    }
}
