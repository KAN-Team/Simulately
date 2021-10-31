using MultiQueueModels;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MultiQueueSimulation
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
        private int activeWindow;
        private bool secondIsLoaded;
        private bool isSimulated;

        public WelcomeForm()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            activeWindow = 0;
            loadFileWindow.setWelcomeForm(this);
            firstCustomInputWindow.setWelcomeForm(this);
            secondCustomInputWindow.setWelcomeForm(this);
            secondIsLoaded = isSimulated = false;
        }

        private void closePic_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Close();
        }

        private void nextPic_Click(object sender, EventArgs e)
        {
            if (activeWindow < 3)
                activeWindow++;
        }

        private void backPic_Click(object sender, EventArgs e)
        {
            if (activeWindow > 0)
                activeWindow--;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int animation_speed = 20;
            
            if (activeWindow == 0 && loadFileWindow.Left < Width)
            {
                loadFileWindow.Left += animation_speed;
                activateWindow();
            }
            else if (activeWindow == 1 && (loadFileWindow.Left > 0 || firstCustomInputWindow.Left < Width))
            {
                if (loadFileWindow.Left > 0)
                    loadFileWindow.Left -= animation_speed;

                loadFileWindow.BringToFront();
                firstCustomInputWindow.BringToFront();

                if (firstCustomInputWindow.Left < Width)
                    firstCustomInputWindow.Left += animation_speed;
                activateWindow();
                secondIsLoaded = false;
            }
            else if (activeWindow == 2 && (firstCustomInputWindow.Left > 0 || secondCustomInputWindow.Left < Width))
            {
                if (firstCustomInputWindow.Left > 0)
                    firstCustomInputWindow.Left -= animation_speed;

                firstCustomInputWindow.BringToFront();
                secondCustomInputWindow.BringToFront();

                if (secondCustomInputWindow.Left < Width)
                    secondCustomInputWindow.Left += animation_speed;
                activateWindow();
                if (!secondIsLoaded)
                {
                    secondCustomInputWindow.setColums();
                    secondIsLoaded = true;
                }
            }
            else if (activeWindow == 3 && secondCustomInputWindow.Left > 0)
            {
                secondCustomInputWindow.Left -= animation_speed;
                secondCustomInputWindow.BringToFront();
                activateWindow();
                secondIsLoaded = false;
            }
            /*else if (activeWindow == 4)
            {
                if (!isSimulated)
                {
                    secondCustomInputWindow.simulateData();
                    isSimulated = true;
                }
            }*/
        }

        private void activateWindow()
        {
            if (activeWindow == 0)
            {
                nextPic.Parent = welcomePanel;
                backPic.Parent = welcomePanel;
                closePic.Parent = welcomePanel;
            }

            else if (activeWindow == 1)
            {
                nextPic.Parent = loadFileWindow;
                backPic.Parent = loadFileWindow;
                closePic.Parent = loadFileWindow;
            }

            else if (activeWindow == 2)
            {
                nextPic.Parent = firstCustomInputWindow;
                backPic.Parent = firstCustomInputWindow;
                closePic.Parent = firstCustomInputWindow;
            }

            else if (activeWindow == 3)
            {
                nextPic.Parent = secondCustomInputWindow;
                backPic.Parent = secondCustomInputWindow;
                closePic.Parent = secondCustomInputWindow;
            }

            nextPic.BringToFront();
            backPic.BringToFront();
            closePic.BringToFront();
        }

        public void CloseForm()
        {
            Close();
            Dispose();
        } 

        public SecondCustomInputWindow getSecondCustomInput()
        {
            return secondCustomInputWindow;
        }
    }
}
