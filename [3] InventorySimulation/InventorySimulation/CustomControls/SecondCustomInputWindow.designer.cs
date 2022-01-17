
namespace InventorySimulation
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
            this.probability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demandLbl = new System.Windows.Forms.Label();
            this.leadDaysDGV = new System.Windows.Forms.DataGridView();
            this.days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probability2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leadDaysLbl = new System.Windows.Forms.Label();
            this.toBeFocusedTxt = new System.Windows.Forms.TextBox();
            this.containerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.demandDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leadDaysDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.containerPanel.Controls.Add(this.validateBtn);
            this.containerPanel.Controls.Add(this.demandDGV);
            this.containerPanel.Controls.Add(this.demandLbl);
            this.containerPanel.Controls.Add(this.leadDaysDGV);
            this.containerPanel.Controls.Add(this.leadDaysLbl);
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
            this.validateBtn.Location = new System.Drawing.Point(54, 214);
            this.validateBtn.Name = "validateBtn";
            this.validateBtn.Size = new System.Drawing.Size(90, 32);
            this.validateBtn.TabIndex = 8;
            this.validateBtn.Text = "Validate";
            this.validateBtn.UseVisualStyleBackColor = true;
            this.validateBtn.Click += new System.EventHandler(this.validateBtn_Click);
            // 
            // demandDGV
            // 
            this.demandDGV.AccessibleName = "Demand";
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
            this.probability});
            this.demandDGV.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.demandDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.demandDGV.Location = new System.Drawing.Point(3, 245);
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
            this.demandDGV.Size = new System.Drawing.Size(574, 230);
            this.demandDGV.TabIndex = 7;
            this.demandDGV.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.leadDaysDGV_EditingControlShowing);
            // 
            // demand
            // 
            this.demand.HeaderText = "Demand";
            this.demand.Name = "demand";
            // 
            // probability
            // 
            this.probability.HeaderText = "Probability";
            this.probability.Name = "probability";
            // 
            // demandLbl
            // 
            this.demandLbl.AutoSize = true;
            this.demandLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demandLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.demandLbl.Location = new System.Drawing.Point(190, 219);
            this.demandLbl.Name = "demandLbl";
            this.demandLbl.Size = new System.Drawing.Size(174, 23);
            this.demandLbl.TabIndex = 6;
            this.demandLbl.Text = "Demand Distributions";
            // 
            // leadDaysDGV
            // 
            this.leadDaysDGV.AccessibleName = "Lead Days";
            this.leadDaysDGV.AllowUserToDeleteRows = false;
            this.leadDaysDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.leadDaysDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.leadDaysDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.leadDaysDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.leadDaysDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leadDaysDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.days,
            this.probability2});
            this.leadDaysDGV.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.leadDaysDGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.leadDaysDGV.Location = new System.Drawing.Point(3, 36);
            this.leadDaysDGV.Name = "leadDaysDGV";
            this.leadDaysDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.leadDaysDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.leadDaysDGV.RowHeadersVisible = false;
            this.leadDaysDGV.Size = new System.Drawing.Size(574, 172);
            this.leadDaysDGV.TabIndex = 5;
            this.leadDaysDGV.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.leadDaysDGV_EditingControlShowing);
            // 
            // days
            // 
            this.days.HeaderText = "Days";
            this.days.Name = "days";
            // 
            // probability2
            // 
            this.probability2.HeaderText = "Probability";
            this.probability2.Name = "probability2";
            // 
            // leadDaysLbl
            // 
            this.leadDaysLbl.AutoSize = true;
            this.leadDaysLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leadDaysLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.leadDaysLbl.Location = new System.Drawing.Point(190, 10);
            this.leadDaysLbl.Name = "leadDaysLbl";
            this.leadDaysLbl.Size = new System.Drawing.Size(188, 23);
            this.leadDaysLbl.TabIndex = 1;
            this.leadDaysLbl.Text = "Lead Days Distribution";
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
            ((System.ComponentModel.ISupportInitialize)(this.leadDaysDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Label leadDaysLbl;
        private System.Windows.Forms.DataGridView leadDaysDGV;
        private System.Windows.Forms.DataGridView demandDGV;
        private System.Windows.Forms.Label demandLbl;
        private System.Windows.Forms.Button validateBtn;
        private System.Windows.Forms.TextBox toBeFocusedTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn demand;
        private System.Windows.Forms.DataGridViewTextBoxColumn probability;
        private System.Windows.Forms.DataGridViewTextBoxColumn days;
        private System.Windows.Forms.DataGridViewTextBoxColumn probability2;
    }
}
