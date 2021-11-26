using System.Windows.Forms;

namespace MultiQueueSimulation.Forms
{
    public partial class PerformanceMesuresForm : Form
    {
        public PerformanceMesuresForm()
        {
            InitializeComponent();

            //averageWaitingTimeAnsLbl.Text = Program.system.PerformanceMeasures.AverageWaitingTime.ToString();
            //probabilityWaitAnsLbl.Text = Program.system.PerformanceMeasures.WaitingProbability.ToString();
            //maxQueueLengthAnsLbl.Text = Program.system.PerformanceMeasures.MaxQueueLength.ToString();
        
            //for (int i = 0; i < Program.system.NumberOfServers; ++i)
            //    performanceDgv.Rows.Add(
            //        Program.system.Servers[i].ID,
            //        Program.system.Servers[i].IdleProbability,
            //        Program.system.Servers[i].AverageServiceTime,
            //        Program.system.Servers[i].Utilization
            //        );
        }
    }
}
