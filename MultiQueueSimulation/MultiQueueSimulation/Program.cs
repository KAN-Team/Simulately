using System;
using System.Windows.Forms;
using MultiQueueTesting;
using MultiQueueModels;

namespace MultiQueueSimulation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
         
        // Applying Singleton Design Pattern on SimulationSystem Object
        public static SimulationSystem system;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WelcomeForm());

            /*System.Threading.Thread.Sleep(500);
            string result = TestingManager.Test(system, Constants.FileNames.TestCase8);
            MessageBox.Show(result);*/
        }
    }
}
