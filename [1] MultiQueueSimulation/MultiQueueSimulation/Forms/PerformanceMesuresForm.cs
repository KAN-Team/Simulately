using System.Windows.Forms;

namespace MultiQueueSimulation.Forms
{
    public partial class PerformanceMesuresForm : Form
    {
        public PerformanceMesuresForm()
        {
            InitializeComponent();

            averageWaitingTimeAnsLbl.Text = Program.mSystem.PerformanceMeasures.AverageWaitingTime.ToString();
            probabilityWaitAnsLbl.Text = Program.mSystem.PerformanceMeasures.WaitingProbability.ToString();
            maxQueueLengthAnsLbl.Text = Program.mSystem.PerformanceMeasures.MaxQueueLength.ToString();
        
            for (int i = 0; i < Program.mSystem.NumberOfServers; ++i)
                performanceDgv.Rows.Add(
                    Program.mSystem.Servers[i].ID,
                    Program.mSystem.Servers[i].IdleProbability,
                    Program.mSystem.Servers[i].AverageServiceTime,
                    Program.mSystem.Servers[i].Utilization
                    );
        }
    }
}
