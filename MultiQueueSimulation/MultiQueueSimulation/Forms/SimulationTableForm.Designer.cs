
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1045, 528);
            this.dataGridView1.TabIndex = 0;
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
            // SimulationTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 528);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SimulationTableForm";
            this.Text = "SimulationTableForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}