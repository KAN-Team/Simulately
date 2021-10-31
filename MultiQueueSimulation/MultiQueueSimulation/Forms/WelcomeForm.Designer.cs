namespace MultiQueueSimulation
{
    partial class WelcomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.nextPic = new System.Windows.Forms.PictureBox();
            this.backPic = new System.Windows.Forms.PictureBox();
            this.welcomePanel = new System.Windows.Forms.Panel();
            this.secondCustomInputWindow = new MultiQueueSimulation.SecondCustomInputWindow();
            this.firstCustomInputWindow = new MultiQueueSimulation.FirstCustomInputWindow();
            this.abanoubLbl = new System.Windows.Forms.Label();
            this.nadaLbl = new System.Windows.Forms.Label();
            this.horizontalSeparatorPanel = new System.Windows.Forms.Panel();
            this.welcomeToLbl = new System.Windows.Forms.Label();
            this.simulatelyTitleLbl = new System.Windows.Forms.Label();
            this.logoPic = new System.Windows.Forms.PictureBox();
            this.theBestLbl = new System.Windows.Forms.Label();
            this.simulatingSystemLbl = new System.Windows.Forms.Label();
            this.closePic = new System.Windows.Forms.PictureBox();
            this.loadFileWindow = new MultiQueueSimulation.LoadFileWindow();
            this.kareemLbl = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nextPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPic)).BeginInit();
            this.welcomePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePic)).BeginInit();
            this.SuspendLayout();
            // 
            // nextPic
            // 
            this.nextPic.BackColor = System.Drawing.Color.Transparent;
            this.nextPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextPic.Image = ((System.Drawing.Image)(resources.GetObject("nextPic.Image")));
            this.nextPic.Location = new System.Drawing.Point(464, 193);
            this.nextPic.Name = "nextPic";
            this.nextPic.Size = new System.Drawing.Size(30, 30);
            this.nextPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nextPic.TabIndex = 2;
            this.nextPic.TabStop = false;
            this.nextPic.Click += new System.EventHandler(this.nextPic_Click);
            // 
            // backPic
            // 
            this.backPic.BackColor = System.Drawing.Color.Transparent;
            this.backPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backPic.Image = ((System.Drawing.Image)(resources.GetObject("backPic.Image")));
            this.backPic.Location = new System.Drawing.Point(3, 193);
            this.backPic.Name = "backPic";
            this.backPic.Size = new System.Drawing.Size(30, 30);
            this.backPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backPic.TabIndex = 3;
            this.backPic.TabStop = false;
            this.backPic.Click += new System.EventHandler(this.backPic_Click);
            // 
            // welcomePanel
            // 
            this.welcomePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("welcomePanel.BackgroundImage")));
            this.welcomePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.welcomePanel.Controls.Add(this.secondCustomInputWindow);
            this.welcomePanel.Controls.Add(this.firstCustomInputWindow);
            this.welcomePanel.Controls.Add(this.abanoubLbl);
            this.welcomePanel.Controls.Add(this.nadaLbl);
            this.welcomePanel.Controls.Add(this.horizontalSeparatorPanel);
            this.welcomePanel.Controls.Add(this.welcomeToLbl);
            this.welcomePanel.Controls.Add(this.simulatelyTitleLbl);
            this.welcomePanel.Controls.Add(this.logoPic);
            this.welcomePanel.Controls.Add(this.backPic);
            this.welcomePanel.Controls.Add(this.nextPic);
            this.welcomePanel.Controls.Add(this.theBestLbl);
            this.welcomePanel.Controls.Add(this.simulatingSystemLbl);
            this.welcomePanel.Controls.Add(this.closePic);
            this.welcomePanel.Controls.Add(this.loadFileWindow);
            this.welcomePanel.Controls.Add(this.kareemLbl);
            this.welcomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomePanel.Location = new System.Drawing.Point(0, 0);
            this.welcomePanel.Name = "welcomePanel";
            this.welcomePanel.Size = new System.Drawing.Size(500, 400);
            this.welcomePanel.TabIndex = 5;
            // 
            // secondCustomInputWindow
            // 
            this.secondCustomInputWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.secondCustomInputWindow.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.secondCustomInputWindow.Location = new System.Drawing.Point(500, 0);
            this.secondCustomInputWindow.Margin = new System.Windows.Forms.Padding(5);
            this.secondCustomInputWindow.Name = "secondCustomInputWindow";
            this.secondCustomInputWindow.Size = new System.Drawing.Size(500, 400);
            this.secondCustomInputWindow.TabIndex = 19;
            // 
            // firstCustomInputWindow
            // 
            this.firstCustomInputWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.firstCustomInputWindow.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstCustomInputWindow.Location = new System.Drawing.Point(500, 0);
            this.firstCustomInputWindow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.firstCustomInputWindow.Name = "firstCustomInputWindow";
            this.firstCustomInputWindow.Size = new System.Drawing.Size(500, 400);
            this.firstCustomInputWindow.TabIndex = 18;
            // 
            // abanoubLbl
            // 
            this.abanoubLbl.AutoSize = true;
            this.abanoubLbl.BackColor = System.Drawing.Color.Transparent;
            this.abanoubLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abanoubLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(189)))), ((int)(((byte)(151)))));
            this.abanoubLbl.Location = new System.Drawing.Point(185, 349);
            this.abanoubLbl.Name = "abanoubLbl";
            this.abanoubLbl.Size = new System.Drawing.Size(123, 23);
            this.abanoubLbl.TabIndex = 17;
            this.abanoubLbl.Text = "Abanoub Asaad";
            this.abanoubLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nadaLbl
            // 
            this.nadaLbl.AutoSize = true;
            this.nadaLbl.BackColor = System.Drawing.Color.Transparent;
            this.nadaLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nadaLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(189)))), ((int)(((byte)(151)))));
            this.nadaLbl.Location = new System.Drawing.Point(3, 337);
            this.nadaLbl.Name = "nadaLbl";
            this.nadaLbl.Size = new System.Drawing.Size(120, 46);
            this.nadaLbl.TabIndex = 15;
            this.nadaLbl.Text = "Nada Anies\r\nNada Mohamed";
            this.nadaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // horizontalSeparatorPanel
            // 
            this.horizontalSeparatorPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.horizontalSeparatorPanel.Location = new System.Drawing.Point(54, 208);
            this.horizontalSeparatorPanel.Name = "horizontalSeparatorPanel";
            this.horizontalSeparatorPanel.Size = new System.Drawing.Size(387, 2);
            this.horizontalSeparatorPanel.TabIndex = 14;
            // 
            // welcomeToLbl
            // 
            this.welcomeToLbl.AutoSize = true;
            this.welcomeToLbl.BackColor = System.Drawing.Color.Transparent;
            this.welcomeToLbl.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeToLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(149)))), ((int)(((byte)(155)))));
            this.welcomeToLbl.Location = new System.Drawing.Point(105, 149);
            this.welcomeToLbl.Name = "welcomeToLbl";
            this.welcomeToLbl.Size = new System.Drawing.Size(159, 39);
            this.welcomeToLbl.TabIndex = 9;
            this.welcomeToLbl.Text = "Welcome to";
            // 
            // simulatelyTitleLbl
            // 
            this.simulatelyTitleLbl.AutoSize = true;
            this.simulatelyTitleLbl.BackColor = System.Drawing.Color.Transparent;
            this.simulatelyTitleLbl.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simulatelyTitleLbl.ForeColor = System.Drawing.Color.White;
            this.simulatelyTitleLbl.Location = new System.Drawing.Point(257, 150);
            this.simulatelyTitleLbl.Name = "simulatelyTitleLbl";
            this.simulatelyTitleLbl.Size = new System.Drawing.Size(148, 39);
            this.simulatelyTitleLbl.TabIndex = 13;
            this.simulatelyTitleLbl.Text = "Simulately";
            // 
            // logoPic
            // 
            this.logoPic.BackColor = System.Drawing.Color.Transparent;
            this.logoPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoPic.Image = ((System.Drawing.Image)(resources.GetObject("logoPic.Image")));
            this.logoPic.Location = new System.Drawing.Point(205, 67);
            this.logoPic.Name = "logoPic";
            this.logoPic.Size = new System.Drawing.Size(90, 80);
            this.logoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPic.TabIndex = 12;
            this.logoPic.TabStop = false;
            // 
            // theBestLbl
            // 
            this.theBestLbl.AutoSize = true;
            this.theBestLbl.BackColor = System.Drawing.Color.Transparent;
            this.theBestLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theBestLbl.ForeColor = System.Drawing.Color.Silver;
            this.theBestLbl.Location = new System.Drawing.Point(148, 217);
            this.theBestLbl.Name = "theBestLbl";
            this.theBestLbl.Size = new System.Drawing.Size(206, 23);
            this.theBestLbl.TabIndex = 6;
            this.theBestLbl.Text = "The best app for modelling";
            this.theBestLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // simulatingSystemLbl
            // 
            this.simulatingSystemLbl.AutoSize = true;
            this.simulatingSystemLbl.BackColor = System.Drawing.Color.Transparent;
            this.simulatingSystemLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simulatingSystemLbl.ForeColor = System.Drawing.Color.Silver;
            this.simulatingSystemLbl.Location = new System.Drawing.Point(149, 236);
            this.simulatingSystemLbl.Name = "simulatingSystemLbl";
            this.simulatingSystemLbl.Size = new System.Drawing.Size(204, 23);
            this.simulatingSystemLbl.TabIndex = 11;
            this.simulatingSystemLbl.Text = "and simulating your system";
            this.simulatingSystemLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closePic
            // 
            this.closePic.BackColor = System.Drawing.Color.Transparent;
            this.closePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePic.Image = ((System.Drawing.Image)(resources.GetObject("closePic.Image")));
            this.closePic.Location = new System.Drawing.Point(464, 5);
            this.closePic.Name = "closePic";
            this.closePic.Size = new System.Drawing.Size(30, 30);
            this.closePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closePic.TabIndex = 10;
            this.closePic.TabStop = false;
            this.closePic.Click += new System.EventHandler(this.closePic_Click);
            // 
            // loadFileWindow
            // 
            this.loadFileWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.loadFileWindow.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadFileWindow.Location = new System.Drawing.Point(500, 0);
            this.loadFileWindow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loadFileWindow.Name = "loadFileWindow";
            this.loadFileWindow.Size = new System.Drawing.Size(500, 400);
            this.loadFileWindow.TabIndex = 8;
            // 
            // kareemLbl
            // 
            this.kareemLbl.AutoSize = true;
            this.kareemLbl.BackColor = System.Drawing.Color.Transparent;
            this.kareemLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kareemLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(189)))), ((int)(((byte)(151)))));
            this.kareemLbl.Location = new System.Drawing.Point(372, 337);
            this.kareemLbl.Name = "kareemLbl";
            this.kareemLbl.Size = new System.Drawing.Size(116, 46);
            this.kareemLbl.TabIndex = 16;
            this.kareemLbl.Text = "Kareem Sherif\r\nKareem Saeed";
            this.kareemLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.welcomePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nextPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPic)).EndInit();
            this.welcomePanel.ResumeLayout(false);
            this.welcomePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox nextPic;
        private System.Windows.Forms.PictureBox backPic;
        private System.Windows.Forms.Panel welcomePanel;
        private System.Windows.Forms.Label theBestLbl;
        private System.Windows.Forms.Timer timer;
        private LoadFileWindow loadFileWindow;
        private System.Windows.Forms.Label welcomeToLbl;
        private System.Windows.Forms.PictureBox closePic;
        private System.Windows.Forms.Label simulatingSystemLbl;
        private System.Windows.Forms.PictureBox logoPic;
        private System.Windows.Forms.Label simulatelyTitleLbl;
        private System.Windows.Forms.Panel horizontalSeparatorPanel;
        private System.Windows.Forms.Label abanoubLbl;
        private System.Windows.Forms.Label kareemLbl;
        private System.Windows.Forms.Label nadaLbl;
        private FirstCustomInputWindow firstCustomInputWindow;
        private SecondCustomInputWindow secondCustomInputWindow;
    }
}

