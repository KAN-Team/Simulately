
namespace MultiQueueSimulation.Forms
{
    partial class PerformanceMesuresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerformanceMesuresForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.performanceMesuresPic = new System.Windows.Forms.PictureBox();
            this.maxQueueLbl = new System.Windows.Forms.Label();
            this.averageWaitingTimeAnsLbl = new System.Windows.Forms.Label();
            this.probabilityWaitAnsLbl = new System.Windows.Forms.Label();
            this.maxQueueLengthAnsLbl = new System.Windows.Forms.Label();
            this.systemPerformanceGroup = new System.Windows.Forms.GroupBox();
            this.serversPerformanceGroup = new System.Windows.Forms.GroupBox();
            this.performanceDgv = new System.Windows.Forms.DataGridView();
            this.serverID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idleStateProbability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averageServiceTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.performanceMesuresPic)).BeginInit();
            this.systemPerformanceGroup.SuspendLayout();
            this.serversPerformanceGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // performanceMesuresPic
            // 
            this.performanceMesuresPic.Image = ((System.Drawing.Image)(resources.GetObject("performanceMesuresPic.Image")));
            this.performanceMesuresPic.Location = new System.Drawing.Point(6, 25);
            this.performanceMesuresPic.Name = "performanceMesuresPic";
            this.performanceMesuresPic.Size = new System.Drawing.Size(469, 169);
            this.performanceMesuresPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.performanceMesuresPic.TabIndex = 1;
            this.performanceMesuresPic.TabStop = false;
            // 
            // maxQueueLbl
            // 
            this.maxQueueLbl.AutoSize = true;
            this.maxQueueLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.maxQueueLbl.Location = new System.Drawing.Point(137, 208);
            this.maxQueueLbl.Name = "maxQueueLbl";
            this.maxQueueLbl.Size = new System.Drawing.Size(338, 19);
            this.maxQueueLbl.TabIndex = 0;
            this.maxQueueLbl.Text = "Maximum queue length during simulation runtime = ";
            // 
            // averageWaitingTimeAnsLbl
            // 
            this.averageWaitingTimeAnsLbl.AutoSize = true;
            this.averageWaitingTimeAnsLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.averageWaitingTimeAnsLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.averageWaitingTimeAnsLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageWaitingTimeAnsLbl.ForeColor = System.Drawing.Color.Crimson;
            this.averageWaitingTimeAnsLbl.Location = new System.Drawing.Point(481, 68);
            this.averageWaitingTimeAnsLbl.Name = "averageWaitingTimeAnsLbl";
            this.averageWaitingTimeAnsLbl.Size = new System.Drawing.Size(60, 25);
            this.averageWaitingTimeAnsLbl.TabIndex = 2;
            this.averageWaitingTimeAnsLbl.Text = "Ans_1";
            // 
            // probabilityWaitAnsLbl
            // 
            this.probabilityWaitAnsLbl.AutoSize = true;
            this.probabilityWaitAnsLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.probabilityWaitAnsLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.probabilityWaitAnsLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.probabilityWaitAnsLbl.ForeColor = System.Drawing.Color.Crimson;
            this.probabilityWaitAnsLbl.Location = new System.Drawing.Point(481, 133);
            this.probabilityWaitAnsLbl.Name = "probabilityWaitAnsLbl";
            this.probabilityWaitAnsLbl.Size = new System.Drawing.Size(60, 25);
            this.probabilityWaitAnsLbl.TabIndex = 3;
            this.probabilityWaitAnsLbl.Text = "Ans_2";
            // 
            // maxQueueLengthAnsLbl
            // 
            this.maxQueueLengthAnsLbl.AutoSize = true;
            this.maxQueueLengthAnsLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.maxQueueLengthAnsLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxQueueLengthAnsLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxQueueLengthAnsLbl.ForeColor = System.Drawing.Color.Crimson;
            this.maxQueueLengthAnsLbl.Location = new System.Drawing.Point(481, 204);
            this.maxQueueLengthAnsLbl.Name = "maxQueueLengthAnsLbl";
            this.maxQueueLengthAnsLbl.Size = new System.Drawing.Size(60, 25);
            this.maxQueueLengthAnsLbl.TabIndex = 4;
            this.maxQueueLengthAnsLbl.Text = "Ans_3";
            // 
            // systemPerformanceGroup
            // 
            this.systemPerformanceGroup.Controls.Add(this.maxQueueLengthAnsLbl);
            this.systemPerformanceGroup.Controls.Add(this.performanceMesuresPic);
            this.systemPerformanceGroup.Controls.Add(this.probabilityWaitAnsLbl);
            this.systemPerformanceGroup.Controls.Add(this.maxQueueLbl);
            this.systemPerformanceGroup.Controls.Add(this.averageWaitingTimeAnsLbl);
            this.systemPerformanceGroup.ForeColor = System.Drawing.Color.Goldenrod;
            this.systemPerformanceGroup.Location = new System.Drawing.Point(12, 12);
            this.systemPerformanceGroup.Name = "systemPerformanceGroup";
            this.systemPerformanceGroup.Size = new System.Drawing.Size(560, 241);
            this.systemPerformanceGroup.TabIndex = 5;
            this.systemPerformanceGroup.TabStop = false;
            this.systemPerformanceGroup.Text = "System Performance";
            // 
            // serversPerformanceGroup
            // 
            this.serversPerformanceGroup.Controls.Add(this.performanceDgv);
            this.serversPerformanceGroup.ForeColor = System.Drawing.Color.Goldenrod;
            this.serversPerformanceGroup.Location = new System.Drawing.Point(12, 259);
            this.serversPerformanceGroup.Name = "serversPerformanceGroup";
            this.serversPerformanceGroup.Size = new System.Drawing.Size(560, 290);
            this.serversPerformanceGroup.TabIndex = 6;
            this.serversPerformanceGroup.TabStop = false;
            this.serversPerformanceGroup.Text = "Servers Performance";
            // 
            // performanceDgv
            // 
            this.performanceDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.performanceDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.performanceDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.performanceDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.performanceDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.performanceDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serverID,
            this.idleStateProbability,
            this.averageServiceTime,
            this.utilization});
            this.performanceDgv.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.performanceDgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.performanceDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.performanceDgv.Location = new System.Drawing.Point(3, 22);
            this.performanceDgv.Name = "performanceDgv";
            this.performanceDgv.ReadOnly = true;
            this.performanceDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.performanceDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.performanceDgv.RowHeadersVisible = false;
            this.performanceDgv.Size = new System.Drawing.Size(554, 265);
            this.performanceDgv.TabIndex = 6;
            // 
            // serverID
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSalmon;
            this.serverID.DefaultCellStyle = dataGridViewCellStyle2;
            this.serverID.FillWeight = 10F;
            this.serverID.HeaderText = "Server ID";
            this.serverID.Name = "serverID";
            this.serverID.ReadOnly = true;
            // 
            // idleStateProbability
            // 
            this.idleStateProbability.FillWeight = 30F;
            this.idleStateProbability.HeaderText = "Idle State Probability";
            this.idleStateProbability.Name = "idleStateProbability";
            this.idleStateProbability.ReadOnly = true;
            // 
            // averageServiceTime
            // 
            this.averageServiceTime.FillWeight = 30F;
            this.averageServiceTime.HeaderText = "Average Service Time";
            this.averageServiceTime.Name = "averageServiceTime";
            this.averageServiceTime.ReadOnly = true;
            // 
            // utilization
            // 
            this.utilization.FillWeight = 30F;
            this.utilization.HeaderText = "Utilization";
            this.utilization.Name = "utilization";
            this.utilization.ReadOnly = true;
            // 
            // PerformanceMesuresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.serversPerformanceGroup);
            this.Controls.Add(this.systemPerformanceGroup);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PerformanceMesuresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Performance Mesures";
            ((System.ComponentModel.ISupportInitialize)(this.performanceMesuresPic)).EndInit();
            this.systemPerformanceGroup.ResumeLayout(false);
            this.systemPerformanceGroup.PerformLayout();
            this.serversPerformanceGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.performanceDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox performanceMesuresPic;
        private System.Windows.Forms.Label maxQueueLbl;
        private System.Windows.Forms.Label averageWaitingTimeAnsLbl;
        private System.Windows.Forms.Label probabilityWaitAnsLbl;
        private System.Windows.Forms.Label maxQueueLengthAnsLbl;
        private System.Windows.Forms.GroupBox systemPerformanceGroup;
        private System.Windows.Forms.GroupBox serversPerformanceGroup;
        private System.Windows.Forms.DataGridView performanceDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverID;
        private System.Windows.Forms.DataGridViewTextBoxColumn idleStateProbability;
        private System.Windows.Forms.DataGridViewTextBoxColumn averageServiceTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilization;
    }
}