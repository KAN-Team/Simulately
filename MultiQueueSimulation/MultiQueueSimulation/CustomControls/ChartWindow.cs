using MultiQueueSimulation.OOP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiQueueSimulation.CustomControls
{
    public partial class ChartWindow : UserControl
    {
        private string seriesName;

        public ChartWindow()
        {
            InitializeComponent();
            chart.ChartAreas[0].AxisY.Maximum = Defaults.MAX_Y_VALUE;
            seriesName = "Server Working Time";
        }

        public void addServerWithID(int ID)
        {
            chart.Text = "Server #" + (ID) + " Working Time";
            chart.Series[seriesName].Name = "Server #" + (ID) + " Working Time";
            seriesName = "Server #" + (ID) + " Working Time";
        }

        public void addDataToPlot()
        {
            chart.Series[seriesName].Points.AddXY("Kareem", 0);
            chart.Series[seriesName].Points.AddXY("Sherif", 1);
            chart.Series[seriesName].Points.AddXY("Moga", 0);
            chart.Series[seriesName].Points.AddXY("Comedy", 1);
        }
    }
}
