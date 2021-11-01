
namespace MultiQueueSimulation.Forms
{
    partial class ChartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartForm));
            this.footerPanel = new System.Windows.Forms.Panel();
            this.showMesuresBtn = new System.Windows.Forms.Button();
            this.backToSimulation = new System.Windows.Forms.Button();
            this.backToWelcomeBtn = new System.Windows.Forms.Button();
            this.chartContainerPanel = new System.Windows.Forms.Panel();
            this.footerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.footerPanel.Controls.Add(this.showMesuresBtn);
            this.footerPanel.Controls.Add(this.backToSimulation);
            this.footerPanel.Controls.Add(this.backToWelcomeBtn);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 422);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(784, 54);
            this.footerPanel.TabIndex = 2;
            // 
            // showMesuresBtn
            // 
            this.showMesuresBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showMesuresBtn.BackColor = System.Drawing.Color.Crimson;
            this.showMesuresBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showMesuresBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showMesuresBtn.ForeColor = System.Drawing.Color.White;
            this.showMesuresBtn.Location = new System.Drawing.Point(263, 0);
            this.showMesuresBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showMesuresBtn.Name = "showMesuresBtn";
            this.showMesuresBtn.Size = new System.Drawing.Size(259, 54);
            this.showMesuresBtn.TabIndex = 3;
            this.showMesuresBtn.Text = "Show Performance Mesures";
            this.showMesuresBtn.UseVisualStyleBackColor = false;
            this.showMesuresBtn.Click += new System.EventHandler(this.showMesuresBtn_Click);
            // 
            // backToSimulation
            // 
            this.backToSimulation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backToSimulation.BackColor = System.Drawing.Color.SteelBlue;
            this.backToSimulation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToSimulation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToSimulation.ForeColor = System.Drawing.Color.White;
            this.backToSimulation.Location = new System.Drawing.Point(423, 0);
            this.backToSimulation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backToSimulation.Name = "backToSimulation";
            this.backToSimulation.Size = new System.Drawing.Size(259, 54);
            this.backToSimulation.TabIndex = 2;
            this.backToSimulation.Text = "Back to Simulation Table";
            this.backToSimulation.UseVisualStyleBackColor = false;
            this.backToSimulation.Click += new System.EventHandler(this.backToSimulation_Click);
            // 
            // backToWelcomeBtn
            // 
            this.backToWelcomeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(189)))), ((int)(((byte)(151)))));
            this.backToWelcomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToWelcomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToWelcomeBtn.ForeColor = System.Drawing.Color.White;
            this.backToWelcomeBtn.Location = new System.Drawing.Point(100, 0);
            this.backToWelcomeBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backToWelcomeBtn.Name = "backToWelcomeBtn";
            this.backToWelcomeBtn.Size = new System.Drawing.Size(259, 54);
            this.backToWelcomeBtn.TabIndex = 1;
            this.backToWelcomeBtn.Text = "Back to Welcome Screen";
            this.backToWelcomeBtn.UseVisualStyleBackColor = false;
            this.backToWelcomeBtn.Click += new System.EventHandler(this.backToWelcomeBtn_Click);
            // 
            // chartContainerPanel
            // 
            this.chartContainerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartContainerPanel.Location = new System.Drawing.Point(0, 0);
            this.chartContainerPanel.Name = "chartContainerPanel";
            this.chartContainerPanel.Size = new System.Drawing.Size(782, 416);
            this.chartContainerPanel.TabIndex = 3;
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 476);
            this.Controls.Add(this.chartContainerPanel);
            this.Controls.Add(this.footerPanel);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ChartForm";
            this.Text = "Chart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ChartForm_Load);
            this.footerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Button backToSimulation;
        private System.Windows.Forms.Button backToWelcomeBtn;
        private System.Windows.Forms.Button showMesuresBtn;
        private System.Windows.Forms.Panel chartContainerPanel;
    }
}