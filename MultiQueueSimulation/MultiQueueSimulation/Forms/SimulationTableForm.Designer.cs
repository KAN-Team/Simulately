
namespace MultiQueueSimulation.Forms
{
    partial class SimulationTableForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimulationTableForm));
            this.simulationDgv = new System.Windows.Forms.DataGridView();
            this.customerNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randomDigits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeBetweenArrivals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cloclTimeOfArrivals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randomDigitsForService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeInQueue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.showMesuresBtn = new System.Windows.Forms.Button();
            this.chartBtn = new System.Windows.Forms.Button();
            this.backToWelcomeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.simulationDgv)).BeginInit();
            this.footerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // simulationDgv
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.simulationDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.simulationDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simulationDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.simulationDgv.BackgroundColor = System.Drawing.Color.DimGray;
            this.simulationDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.simulationDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.simulationDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.simulationDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerNumber,
            this.randomDigits,
            this.timeBetweenArrivals,
            this.cloclTimeOfArrivals,
            this.randomDigitsForService,
            this.serverID,
            this.serverBegin,
            this.serviceTime,
            this.serverEnd,
            this.timeInQueue});
            this.simulationDgv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simulationDgv.EnableHeadersVisualStyles = false;
            this.simulationDgv.GridColor = System.Drawing.Color.Silver;
            this.simulationDgv.Location = new System.Drawing.Point(0, 0);
            this.simulationDgv.Margin = new System.Windows.Forms.Padding(4);
            this.simulationDgv.Name = "simulationDgv";
            this.simulationDgv.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.simulationDgv.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.simulationDgv.RowTemplate.Height = 30;
            this.simulationDgv.Size = new System.Drawing.Size(784, 413);
            this.simulationDgv.TabIndex = 0;
            // 
            // customerNumber
            // 
            this.customerNumber.HeaderText = "Customer Number";
            this.customerNumber.Name = "customerNumber";
            // 
            // randomDigits
            // 
            this.randomDigits.HeaderText = "Random Digits For Arrival";
            this.randomDigits.Name = "randomDigits";
            // 
            // timeBetweenArrivals
            // 
            this.timeBetweenArrivals.HeaderText = "Time Between Arrivals";
            this.timeBetweenArrivals.Name = "timeBetweenArrivals";
            // 
            // cloclTimeOfArrivals
            // 
            this.cloclTimeOfArrivals.HeaderText = "Clocl Time of Arrivals";
            this.cloclTimeOfArrivals.Name = "cloclTimeOfArrivals";
            // 
            // randomDigitsForService
            // 
            this.randomDigitsForService.HeaderText = "Random Digits For Service";
            this.randomDigitsForService.Name = "randomDigitsForService";
            // 
            // serverID
            // 
            this.serverID.HeaderText = "Server ID";
            this.serverID.Name = "serverID";
            // 
            // serverBegin
            // 
            this.serverBegin.HeaderText = "Server Begin";
            this.serverBegin.Name = "serverBegin";
            // 
            // serviceTime
            // 
            this.serviceTime.HeaderText = "Service Time";
            this.serviceTime.Name = "serviceTime";
            // 
            // serverEnd
            // 
            this.serverEnd.HeaderText = "Server End";
            this.serverEnd.Name = "serverEnd";
            // 
            // timeInQueue
            // 
            this.timeInQueue.HeaderText = "Time In Queue";
            this.timeInQueue.Name = "timeInQueue";
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.Silver;
            this.footerPanel.Controls.Add(this.showMesuresBtn);
            this.footerPanel.Controls.Add(this.chartBtn);
            this.footerPanel.Controls.Add(this.backToWelcomeBtn);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 422);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(784, 54);
            this.footerPanel.TabIndex = 1;
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
            this.showMesuresBtn.TabIndex = 4;
            this.showMesuresBtn.Text = "Show Performance Mesures";
            this.showMesuresBtn.UseVisualStyleBackColor = false;
            this.showMesuresBtn.Click += new System.EventHandler(this.showMesuresBtn_Click);
            // 
            // chartBtn
            // 
            this.chartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chartBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.chartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chartBtn.ForeColor = System.Drawing.Color.White;
            this.chartBtn.Location = new System.Drawing.Point(423, 0);
            this.chartBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chartBtn.Name = "chartBtn";
            this.chartBtn.Size = new System.Drawing.Size(259, 54);
            this.chartBtn.TabIndex = 2;
            this.chartBtn.Text = "Represent in a Graph";
            this.chartBtn.UseVisualStyleBackColor = false;
            this.chartBtn.Click += new System.EventHandler(this.chartBtn_Click);
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
            // SimulationTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 476);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.simulationDgv);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SimulationTableForm";
            this.Text = "Simulation Table";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.simulationDgv)).EndInit();
            this.footerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView simulationDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn randomDigits;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeBetweenArrivals;
        private System.Windows.Forms.DataGridViewTextBoxColumn cloclTimeOfArrivals;
        private System.Windows.Forms.DataGridViewTextBoxColumn randomDigitsForService;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverID;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeInQueue;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Button backToWelcomeBtn;
        private System.Windows.Forms.Button chartBtn;
        private System.Windows.Forms.Button showMesuresBtn;
    }
}