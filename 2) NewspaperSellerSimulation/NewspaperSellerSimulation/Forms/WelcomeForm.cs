using MultiQueueSimulation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NewspaperSellerSimulation.Forms
{
    public partial class WelcomeForm : Form
    {
        // ========================== Rounding Edges ==========================//
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
        );
        // =====================================================================//

        // determines which window is active from 0 to 3
        private List<object> windowsList;
        private int activeWindow;
        private bool isSlidingLeft;
        private bool isSlidingRight;
        private SecondCustomInputWindow secondCustomInputWindow;

        public WelcomeForm()
        {
            InitializeComponent();

            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            isSlidingLeft = isSlidingRight = false;
            activeWindow = -1;
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            LoadFileWindow loadFileWindow = new LoadFileWindow();
            loadFileWindow.Left = Width;
            loadFileWindow.Top = 0;
            Controls.Add(loadFileWindow);
            loadFileWindow.BringToFront();
            FirstCustomInputWindow firstCustomInputWindow = new FirstCustomInputWindow();
            firstCustomInputWindow.Left = Width;
            firstCustomInputWindow.Top = 0;
            Controls.Add(firstCustomInputWindow);
            firstCustomInputWindow.BringToFront();
            secondCustomInputWindow = new SecondCustomInputWindow();
            secondCustomInputWindow.Left = Width;
            secondCustomInputWindow.Top = 0;
            Controls.Add(secondCustomInputWindow);
            secondCustomInputWindow.BringToFront();

            closePic.BringToFront();
            backPic.BringToFront();
            nextPic.BringToFront();

            windowsList = new List<object>();
            windowsList.Add(loadFileWindow);
            windowsList.Add(firstCustomInputWindow);
            windowsList.Add(secondCustomInputWindow);

            loadFileWindow.setWelcomeForm(this);
        }

        #region NAVIGATION_PICTURE_BUTTONS
        private void closePic_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Close();
        }

        private void nextPic_Click(object sender, EventArgs e)
        {
            if (activeWindow < windowsList.Count - 1)
            {
                activeWindow++;
                isSlidingLeft = true;
            }

            else if (activeWindow == windowsList.Count - 1)
            {
                secondCustomInputWindow.openSumulationTableForm(this);
            }
        }

        private void backPic_Click(object sender, EventArgs e)
        {
            if (activeWindow > 0)
            {
                activeWindow--;
                isSlidingRight = true;
            }
        }
        #endregion

        #region TIMER_AND_ACTIVATING_WINDOW
        private void timer_Tick(object sender, EventArgs e)
        {
            if (activeWindow != -1)
            {
                int sliding_speed = 20;
                Control window = (Control)windowsList[activeWindow];
                if (isSlidingLeft)
                {
                    if (window.Left > 0)
                    {
                        if (window.Left < sliding_speed)
                            window.Left = 0;
                        else
                            window.Left -= sliding_speed;
                    }

                    else
                        isSlidingLeft = false;
                }

                else if (isSlidingRight)
                {
                    window = (Control)windowsList[activeWindow + 1];
                    if (window.Left < Width)
                    {
                        if (window.Left + sliding_speed > Width)
                            window.Left = Width;
                        else
                            window.Left += sliding_speed;
                    }
                    else
                        isSlidingRight = false;
                }
            }
        }
        #endregion

        #region GITHUB
        private void gitHubLinkLbl_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Kareem100/Simulately");
        }

        private void gitHubLinkLbl_MouseEnter(object sender, EventArgs e)
        {
            gitHubLinkLbl.Font = new Font("comic sans ms", 14, FontStyle.Underline | FontStyle.Italic);
        }

        private void gitHubLinkLbl_MouseLeave(object sender, EventArgs e)
        {
            gitHubLinkLbl.Font = new Font("Monotype Corsiva", 14, FontStyle.Bold | FontStyle.Italic);
        }
        #endregion

        private void welcomePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
