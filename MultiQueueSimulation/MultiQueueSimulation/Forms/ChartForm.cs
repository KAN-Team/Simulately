using MultiQueueSimulation.CustomControls;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace MultiQueueSimulation.Forms
{
    public partial class ChartForm : Form
    {
        private Thread thread;
        private List<ChartWindow> chartWindowList;
        private int activeWindow;
        private int screenWidth;
        private bool isSlidingLeft;
        private bool isSlidingRight;
        public ChartForm()
        {
            InitializeComponent();
            chartWindowList = new List<ChartWindow>();
            activeWindow = 0;
            screenWidth = Screen.FromControl(this).Bounds.Width;
            isSlidingLeft = isSlidingRight = false;
        }
        private void ChartForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.system.NumberOfServers; ++i)
            {
                ChartWindow chartWindow = new ChartWindow(Program.system.Servers[i].ID);
                chartContainerPanel.Controls.Add(chartWindow);
                chartWindow.Left = 0;
                chartWindow.Top = 0;
                chartWindow.Width = chartContainerPanel.Width;
                chartWindow.Height = chartContainerPanel.Height;
                chartWindow.BringToFront();
                chartWindowList.Add(chartWindow);
            }

            nextPic.BringToFront();
            backPic.BringToFront();
            for (int i = 1; i < Program.system.NumberOfServers; ++i)
                chartWindowList[i].Left = screenWidth;
        }

        #region HANDLING_FOOTER_NAVIGATION_BUTTONS
        private void backToWelcomeBtn_Click(object sender, EventArgs e)
        {
            openForm(1);
        }

        private void backToSimulation_Click(object sender, EventArgs e)
        {
            openForm(2);
        }

        private void showMesuresBtn_Click(object sender, EventArgs e)
        {
            // openForm(3);

            PerformanceMesuresForm performanceMesuresForm = new PerformanceMesuresForm();
            performanceMesuresForm.Show();
        }
        #endregion

        #region OPENING_FORM_WITH_FORM_ID
        private void openForm(int formID)
        {
            if (formID == 1)
                thread = new Thread(openWelcomeForm);
            else if (formID == 2)
                thread = new Thread(openSimulationForm);
            else
                thread = new Thread(openPerformanceMesuresForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            Close();
        }

        private void openWelcomeForm(object obj)
        {
            Application.Run(new WelcomeForm());
        }

        private void openSimulationForm(object obj)
        {
            Application.Run(new SimulationTableForm());
        }

        private void openPerformanceMesuresForm(object obj)
        {
            Application.Run(new PerformanceMesuresForm());
        }
        #endregion

        #region HANDLING_SLIDING_BUTTONS
        private void backPic_Click(object sender, EventArgs e)
        {
            if (activeWindow > 0)
            {
                activeWindow--;
                isSlidingRight = true;
            }
        }

        private void nextPic_Click(object sender, EventArgs e)
        {
            if (activeWindow < Program.system.NumberOfServers - 1)
            {
                activeWindow++;
                isSlidingLeft = true;
            }
        }
        #endregion
        private void timer_Tick(object sender, EventArgs e)
        {
            int sliding_speed = 80;

            if (isSlidingLeft)
            {
                if (chartWindowList[activeWindow].Left > 0)
                {
                    if (chartWindowList[activeWindow].Left < sliding_speed)
                        chartWindowList[activeWindow].Left = 0;
                    else
                        chartWindowList[activeWindow].Left -= sliding_speed;
                }

                else
                    isSlidingLeft = false;
            }

            else if (isSlidingRight)
            {
                if (chartWindowList[activeWindow + 1].Left < screenWidth)
                {
                    if (chartWindowList[activeWindow + 1].Left + sliding_speed > screenWidth)
                        chartWindowList[activeWindow + 1].Left = screenWidth;
                    else
                        chartWindowList[activeWindow + 1].Left += sliding_speed;
                }
                else
                    isSlidingRight = false;
            }
        }
    }
}
