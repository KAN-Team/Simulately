using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewspaperSellerModels;
using NewspaperSellerSimulation.Forms;
using NewspaperSellerTesting;

namespace NewspaperSellerSimulation
{
    static class Program
    {
        // Applying Singleton Design Pattern on SimulationSystem Object
        public static SimulationSystem System;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            System = new SimulationSystem();
            Application.Run(new WelcomeForm());
            
            /*System.Threading.Thread.Sleep(500);
            string result = TestingManager.Test(system, Constants.FileNames.TestCase1);
            MessageBox.Show(result);*/
        }
    }
}
