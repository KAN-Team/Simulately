
namespace NewspaperSellerSimulation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.validateBtn = new System.Windows.Forms.Button();
            this.demandDGV = new System.Windows.Forms.DataGridView();
            this.demand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.good2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fair2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poor2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceTimeLbl = new System.Windows.Forms.Label();
            this.dayTypeDGV = new System.Windows.Forms.DataGridView();
            this.good = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interarrivalLbl = new System.Windows.Forms.Label();
            this.toBeFocusedTxt = new System.Windows.Forms.TextBox();
            this.containerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.demandDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayTypeDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.containerPanel.Controls.Add(this.validateBtn);
            this.containerPanel.Controls.Add(this.demandDGV);
            this.containerPanel.Controls.Add(this.serviceTimeLbl);
            this.containerPanel.Controls.Add(this.dayTypeDGV);
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
            this.validateBtn.Location = new System.Drawing.Point(61, 100);
            this.validateBtn.Name = "validateBtn";
            this.validateBtn.Size = new System.Drawing.Size(90, 32);
            this.validateBtn.TabIndex = 8;
            this.validateBtn.Text = "Validate";
            this.validateBtn.UseVisualStyleBackColor = true;
            this.validateBtn.Click += new System.EventHandler(this.validateBtn_Click);
            // 
            // demandDGV
            // 
            this.demandDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.demandDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.demandDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.demandDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.demandDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.demandDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.demand,
            this.good2,
            this.fair2,
            this.poor2});
            this.demandDGV.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.demandDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.demandDGV.Location = new System.Drawing.Point(3, 138);
            this.demandDGV.Name = "demandDGV";
            this.demandDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.demandDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.demandDGV.RowHeadersVisible = false;
            this.demandDGV.Size = new System.Drawing.Size(574, 337);
            this.demandDGV.TabIndex = 7;
            this.demandDGV.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dayTypeDGV_EditingControlShowing);
            // 
            // demand
            // 
            this.demand.HeaderText = "Demand";
            this.demand.Name = "demand";
            // 
            // good2
            // 
            this.good2.HeaderText = "Good Prob";
            this.good2.Name = "good2";
            // 
            // fair2
            // 
            this.fair2.HeaderText = "Fair Prob";
            this.fair2.Name = "fair2";
            // 
            // poor2
            // 
            this.poor2.HeaderText = "Poor Prob";
            this.poor2.Name = "poor2";
            // 
            // serviceTimeLbl
            // 
            this.serviceTimeLbl.AutoSize = true;
            this.serviceTimeLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceTimeLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.serviceTimeLbl.Location = new System.Drawing.Point(197, 105);
            this.serviceTimeLbl.Name = "serviceTimeLbl";
            this.serviceTimeLbl.Size = new System.Drawing.Size(174, 23);
            this.serviceTimeLbl.TabIndex = 6;
            this.serviceTimeLbl.Text = "Demand Distributions";
            // 
            // dayTypeDGV
            // 
            this.dayTypeDGV.AllowUserToDeleteRows = false;
            this.dayTypeDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dayTypeDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dayTypeDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dayTypeDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dayTypeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dayTypeDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.good,
            this.fair,
            this.poor});
            this.dayTypeDGV.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dayTypeDGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.dayTypeDGV.Location = new System.Drawing.Point(3, 36);
            this.dayTypeDGV.Name = "dayTypeDGV";
            this.dayTypeDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dayTypeDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dayTypeDGV.RowHeadersVisible = false;
            this.dayTypeDGV.Size = new System.Drawing.Size(574, 60);
            this.dayTypeDGV.TabIndex = 5;
            this.dayTypeDGV.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dayTypeDGV_EditingControlShowing);
            this.dayTypeDGV.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dayTypeDGV_UserAddedRow);
            // 
            // good
            // 
            this.good.HeaderText = "Good Prob";
            this.good.Name = "good";
            // 
            // fair
            // 
            this.fair.HeaderText = "Fair Prob";
            this.fair.Name = "fair";
            // 
            // poor
            // 
            this.poor.HeaderText = "Poor Prob";
            this.poor.Name = "poor";
            // 
            // interarrivalLbl
            // 
            this.interarrivalLbl.AutoSize = true;
            this.interarrivalLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interarrivalLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.interarrivalLbl.Location = new System.Drawing.Point(190, 10);
            this.interarrivalLbl.Name = "interarrivalLbl";
            this.interarrivalLbl.Size = new System.Drawing.Size(183, 23);
            this.interarrivalLbl.TabIndex = 1;
            this.interarrivalLbl.Text = "DayType Distributions";
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
            ((System.ComponentModel.ISupportInitialize)(this.demandDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayTypeDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Label interarrivalLbl;
        private System.Windows.Forms.DataGridView dayTypeDGV;
        private System.Windows.Forms.DataGridView demandDGV;
        private System.Windows.Forms.Label serviceTimeLbl;
        private System.Windows.Forms.Button validateBtn;
        private System.Windows.Forms.TextBox toBeFocusedTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn demand;
        private System.Windows.Forms.DataGridViewTextBoxColumn good2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fair2;
        private System.Windows.Forms.DataGridViewTextBoxColumn poor2;
        private System.Windows.Forms.DataGridViewTextBoxColumn good;
        private System.Windows.Forms.DataGridViewTextBoxColumn fair;
        private System.Windows.Forms.DataGridViewTextBoxColumn poor;
    }
}
