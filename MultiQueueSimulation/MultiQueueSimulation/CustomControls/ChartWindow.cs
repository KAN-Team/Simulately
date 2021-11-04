using MultiQueueModels;
using MultiQueueSimulation.OOP;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MultiQueueSimulation.CustomControls
{
    public partial class ChartWindow : UserControl
    {
        private string seriesName;
        private Server server;
        public ChartWindow(int serverID)
        {
            InitializeComponent();
            chart.ChartAreas[0].AxisY.Maximum = Defaults.MAX_Y_VALUE;
            seriesName = "Server Working Time";

            server = getServerWithID(serverID);
            addServerWithID(serverID);
            addDataToPlot();
        }

        public void addServerWithID(int serverID)
        {
            chart.Text = "Server #" + (serverID) + " Working Time";
            chart.Series[seriesName].Name = "Server #" + (serverID) + " Working Time";
            seriesName = "Server #" + (serverID) + " Working Time";
        }

        public void addDataToPlot()
        {
            if (Program.system.endSimulationTime < 50)
                chart.ChartAreas.FirstOrDefault().AxisX.Interval = 1;

            chart.Series[seriesName].Points.AddXY(0, 0);
            foreach (KeyValuePair<int, int> KVP in server.WorkingIntervals)
            {
                chart.Series[seriesName].Points.AddXY(KVP.Key, 0);
                chart.Series[seriesName].Points.AddXY(KVP.Key, 1);
                chart.Series[seriesName].Points.AddXY(KVP.Value, 1);
                chart.Series[seriesName].Points.AddXY(KVP.Value, 0);
            }
            chart.Series[seriesName].Points.AddXY(Program.system.endSimulationTime, 0);
        }

        private Server getServerWithID(int ID)
        {
            for (int i = 0; i < Program.system.Servers.Count; ++i)
                if (Program.system.Servers[i].ID == ID)
                    return Program.system.Servers[i];

            MessageBox.Show("No Server Found with ID = " + ID, "getServer METHOD in ChartWindow", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }
    }
}
