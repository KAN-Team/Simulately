using System.Collections.Generic;
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

            DoConclusions();
        }

        private void DoConclusions()
        {
            Dictionary<string, string> MessageInfo = new Dictionary<string, string>
            {
                ["SelectionMethod"] = "Another Selection Method may have to be chosen!",
                ["DisposeServers"] = "Number of Servers may have to be disposed of!",
                ["NeedServers"] = "Extra Servers are needed!",
                ["NeedServer"] = "Extra Server may be needed!"
            };

            decimal avgUtilization = GetAverageUtilization();

            string hint    = "";
            string message = "";
            for (int i = 0; i < Program.mSystem.Servers.Count; ++i)
            {
                decimal currentServerUtilization = Program.mSystem.Servers[i].Utilization;
                if ((currentServerUtilization < (decimal)0.2 && avgUtilization > (decimal)0.5) ||
                    (currentServerUtilization > (decimal)0.8 && avgUtilization < (decimal)0.5))
                    hint = MessageInfo["SelectionMethod"];

                if (currentServerUtilization == 0)
                {
                    message = MessageInfo["DisposeServers"];
                    break;
                }
                    
                else if (currentServerUtilization == 1)
                {
                    if (Program.mSystem.PerformanceMeasures.WaitingProbability > (decimal)0.5)
                        message = MessageInfo["NeedServers"];
                    else
                        message = MessageInfo["NeedServer"];
                    break;
                }
            }

            hintLbl.Text = hint;
            serverLbl.Text = message;

            if (hint.Equals("") && message.Equals(""))
            {
                conclusionGroup.Visible = false;
                Height = 490;
            }

            if (hint.Equals(""))
            {
                hintPic.Visible = false;
                hintLbl.Visible = false;
            }

            if (message.Equals(""))
            {
                serverPic.Visible = false;
                serverLbl.Visible = false;
            }
        }

        private decimal GetAverageUtilization()
        {
            decimal utilzationAcc = 0;
            int serveresCount = Program.mSystem.Servers.Count;
            for (int i = 0; i < serveresCount; ++i)
                utilzationAcc += Program.mSystem.Servers[i].Utilization;

            return utilzationAcc / serveresCount;
        }
    }
}
