using NewspaperSellerSimulation;
using System.Windows.Forms;

namespace MultiQueueSimulation.Forms
{
    public partial class PerformanceMesuresForm : Form
    {
        public PerformanceMesuresForm()
        {
            InitializeComponent();
            this.totalSalesProfitAnsLbl.Text = Program.system.PerformanceMeasures.TotalSalesProfit.ToString();
            this.totalLostProfitAnsLbl.Text = Program.system.PerformanceMeasures.TotalLostProfit.ToString();
            this.totalCostAnsLbl.Text = Program.system.PerformanceMeasures.TotalCost.ToString();
            this.totalScrapProfitAnsLbl.Text = Program.system.PerformanceMeasures.TotalScrapProfit.ToString();
            this.totalNetProfitAnsLbl.Text = Program.system.PerformanceMeasures.TotalNetProfit.ToString();
            this.dayWithMoreDemandAnsLbl.Text = Program.system.PerformanceMeasures.DaysWithMoreDemand.ToString();
            this.daysWithUnsoldPapersAnsLbl.Text = Program.system.PerformanceMeasures.DaysWithUnsoldPapers.ToString();
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
