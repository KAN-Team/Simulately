
namespace MultiQueueSimulation
{
    partial class SecondCustomInputWindow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.validateBtn = new System.Windows.Forms.Button();
            this.serviceTimeDgv = new System.Windows.Forms.DataGridView();
            this.serviceTimeLbl = new System.Windows.Forms.Label();
            this.interarrivalDgv = new System.Windows.Forms.DataGridView();
            this.interarrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interarrivalLbl = new System.Windows.Forms.Label();
            this.toBeFocusedTxt = new System.Windows.Forms.TextBox();
            this.containerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceTimeDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interarrivalDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.containerPanel.Controls.Add(this.validateBtn);
            this.containerPanel.Controls.Add(this.serviceTimeDgv);
            this.containerPanel.Controls.Add(this.serviceTimeLbl);
            this.containerPanel.Controls.Add(this.interarrivalDgv);
            this.containerPanel.Controls.Add(this.interarrivalLbl);
            this.containerPanel.Controls.Add(this.toBeFocusedTxt);
            this.containerPanel.Location = new System.Drawing.Point(10, 10);
            this.containerPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(580, 480);
            this.containerPanel.TabIndex = 2;
            // 
            // validateBtn
            // 
            this.validateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.validateBtn.Location = new System.Drawing.Point(61, 225);
            this.validateBtn.Name = "validateBtn";
            this.validateBtn.Size = new System.Drawing.Size(90, 32);
            this.validateBtn.TabIndex = 8;
            this.validateBtn.Text = "Validate";
            this.validateBtn.UseVisualStyleBackColor = true;
            this.validateBtn.Visible = false;
            this.validateBtn.Click += new System.EventHandler(this.validateBtn_Click);
            // 
            // serviceTimeDgv
            // 
            this.serviceTimeDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.serviceTimeDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.serviceTimeDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.serviceTimeDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.serviceTimeDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceTimeDgv.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.serviceTimeDgv.DefaultCellStyle = dataGridViewCellStyle8;
            this.serviceTimeDgv.Location = new System.Drawing.Point(3, 255);
            this.serviceTimeDgv.Name = "serviceTimeDgv";
            this.serviceTimeDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.serviceTimeDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.serviceTimeDgv.RowHeadersVisible = false;
            this.serviceTimeDgv.Size = new System.Drawing.Size(574, 220);
            this.serviceTimeDgv.TabIndex = 7;
            this.serviceTimeDgv.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgv_EditingControlShowing);
            // 
            // serviceTimeLbl
            // 
            this.serviceTimeLbl.AutoSize = true;
            this.serviceTimeLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.serviceTimeLbl.Location = new System.Drawing.Point(188, 230);
            this.serviceTimeLbl.Name = "serviceTimeLbl";
            this.serviceTimeLbl.Size = new System.Drawing.Size(206, 23);
            this.serviceTimeLbl.TabIndex = 6;
            this.serviceTimeLbl.Text = "Service Time Distribution ";
            // 
            // interarrivalDgv
            // 
            this.interarrivalDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.interarrivalDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.interarrivalDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.interarrivalDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.interarrivalDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.interarrivalDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.interarrivalTime,
            this.probability});
            this.interarrivalDgv.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.interarrivalDgv.DefaultCellStyle = dataGridViewCellStyle11;
            this.interarrivalDgv.Location = new System.Drawing.Point(3, 36);
            this.interarrivalDgv.Name = "interarrivalDgv";
            this.interarrivalDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.interarrivalDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.interarrivalDgv.RowHeadersVisible = false;
            this.interarrivalDgv.Size = new System.Drawing.Size(574, 190);
            this.interarrivalDgv.TabIndex = 5;
            this.interarrivalDgv.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgv_EditingControlShowing);
            // 
            // interarrivalTime
            // 
            this.interarrivalTime.HeaderText = "Interarrival  Time";
            this.interarrivalTime.Name = "interarrivalTime";
            // 
            // probability
            // 
            this.probability.HeaderText = "Probability";
            this.probability.Name = "probability";
            // 
            // interarrivalLbl
            // 
            this.interarrivalLbl.AutoSize = true;
            this.interarrivalLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.interarrivalLbl.Location = new System.Drawing.Point(190, 10);
            this.interarrivalLbl.Name = "interarrivalLbl";
            this.interarrivalLbl.Size = new System.Drawing.Size(203, 23);
            this.interarrivalLbl.TabIndex = 1;
            this.interarrivalLbl.Text = "Interarrival Disturibution";
            // 
            // toBeFocusedTxt
            // 
            this.toBeFocusedTxt.Location = new System.Drawing.Point(12, 36);
            this.toBeFocusedTxt.Name = "toBeFocusedTxt";
            this.toBeFocusedTxt.Size = new System.Drawing.Size(10, 30);
            this.toBeFocusedTxt.TabIndex = 9;
            // 
            // SecondCustomInputWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.containerPanel);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SecondCustomInputWindow";
            this.Size = new System.Drawing.Size(600, 500);
            this.containerPanel.ResumeLayout(false);
            this.containerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceTimeDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interarrivalDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Label interarrivalLbl;
        private System.Windows.Forms.DataGridView interarrivalDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn interarrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn probability;
        private System.Windows.Forms.DataGridView serviceTimeDgv;
        private System.Windows.Forms.Label serviceTimeLbl;
        private System.Windows.Forms.Button validateBtn;
        private System.Windows.Forms.TextBox toBeFocusedTxt;
    }
}
