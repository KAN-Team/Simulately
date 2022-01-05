
namespace InventorySimulation.Forms
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
            this.footerPanel = new System.Windows.Forms.Panel();
            this.showMesuresBtn = new System.Windows.Forms.Button();
            this.backToWelcomeBtn = new System.Windows.Forms.Button();
            this.DailyCostPannel = new System.Windows.Forms.Panel();
            this.dayNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayWithinCycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beginingInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randomDigitsForDemand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endingInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShortageQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandomDigitForLeadTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeadTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysUntilOrderArrives = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dayNumber,
            this.cycle,
            this.dayWithinCycle,
            this.beginingInventory,
            this.randomDigitsForDemand,
            this.demand,
            this.endingInventory,
            this.ShortageQuantity,
            this.OrderQuantity,
            this.RandomDigitForLeadTime,
            this.LeadTime,
            this.DaysUntilOrderArrives});
            this.simulationDgv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simulationDgv.EnableHeadersVisualStyles = false;
            this.simulationDgv.GridColor = System.Drawing.Color.Silver;
            this.simulationDgv.Location = new System.Drawing.Point(0, 0);
            this.simulationDgv.Margin = new System.Windows.Forms.Padding(4);
            this.simulationDgv.Name = "simulationDgv";
            this.simulationDgv.ReadOnly = true;
            this.simulationDgv.RowHeadersVisible = false;
            this.simulationDgv.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.simulationDgv.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.simulationDgv.RowTemplate.Height = 30;
            this.simulationDgv.Size = new System.Drawing.Size(785, 414);
            this.simulationDgv.TabIndex = 0;
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.footerPanel.Controls.Add(this.showMesuresBtn);
            this.footerPanel.Controls.Add(this.backToWelcomeBtn);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 421);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(784, 55);
            this.footerPanel.TabIndex = 1;
            // 
            // showMesuresBtn
            // 
            this.showMesuresBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.showMesuresBtn.BackColor = System.Drawing.Color.Crimson;
            this.showMesuresBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showMesuresBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showMesuresBtn.ForeColor = System.Drawing.Color.White;
            this.showMesuresBtn.Location = new System.Drawing.Point(394, 2);
            this.showMesuresBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showMesuresBtn.Name = "showMesuresBtn";
            this.showMesuresBtn.Size = new System.Drawing.Size(240, 50);
            this.showMesuresBtn.TabIndex = 4;
            this.showMesuresBtn.Text = "Show Performance Mesures";
            this.showMesuresBtn.UseVisualStyleBackColor = false;
            this.showMesuresBtn.Click += new System.EventHandler(this.showMesuresBtn_Click);
            // 
            // backToWelcomeBtn
            // 
            this.backToWelcomeBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.backToWelcomeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(189)))), ((int)(((byte)(151)))));
            this.backToWelcomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToWelcomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToWelcomeBtn.ForeColor = System.Drawing.Color.White;
            this.backToWelcomeBtn.Location = new System.Drawing.Point(153, 2);
            this.backToWelcomeBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backToWelcomeBtn.Name = "backToWelcomeBtn";
            this.backToWelcomeBtn.Size = new System.Drawing.Size(240, 50);
            this.backToWelcomeBtn.TabIndex = 1;
            this.backToWelcomeBtn.Text = "Back to Welcome Screen";
            this.backToWelcomeBtn.UseVisualStyleBackColor = false;
            this.backToWelcomeBtn.Click += new System.EventHandler(this.backToWelcomeBtn_Click);
            // 
            // DailyCostPannel
            // 
            this.DailyCostPannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.DailyCostPannel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DailyCostPannel.Location = new System.Drawing.Point(0, 411);
            this.DailyCostPannel.Name = "DailyCostPannel";
            this.DailyCostPannel.Size = new System.Drawing.Size(784, 10);
            this.DailyCostPannel.TabIndex = 2;
            // 
            // dayNumber
            // 
            this.dayNumber.HeaderText = "Day";
            this.dayNumber.MinimumWidth = 6;
            this.dayNumber.Name = "dayNumber";
            this.dayNumber.ReadOnly = true;
            // 
            // cycle
            // 
            this.cycle.HeaderText = "Cycle";
            this.cycle.MinimumWidth = 6;
            this.cycle.Name = "cycle";
            this.cycle.ReadOnly = true;
            // 
            // dayWithinCycle
            // 
            this.dayWithinCycle.HeaderText = "Day within Cycle";
            this.dayWithinCycle.MinimumWidth = 6;
            this.dayWithinCycle.Name = "dayWithinCycle";
            this.dayWithinCycle.ReadOnly = true;
            // 
            // beginingInventory
            // 
            this.beginingInventory.HeaderText = "Begining Inventory";
            this.beginingInventory.Name = "beginingInventory";
            this.beginingInventory.ReadOnly = true;
            // 
            // randomDigitsForDemand
            // 
            this.randomDigitsForDemand.HeaderText = "Random Digits for Demand";
            this.randomDigitsForDemand.MinimumWidth = 6;
            this.randomDigitsForDemand.Name = "randomDigitsForDemand";
            this.randomDigitsForDemand.ReadOnly = true;
            // 
            // demand
            // 
            this.demand.HeaderText = "Demand";
            this.demand.MinimumWidth = 6;
            this.demand.Name = "demand";
            this.demand.ReadOnly = true;
            // 
            // endingInventory
            // 
            this.endingInventory.HeaderText = "Ending Inventory";
            this.endingInventory.Name = "endingInventory";
            this.endingInventory.ReadOnly = true;
            // 
            // ShortageQuantity
            // 
            this.ShortageQuantity.HeaderText = "Shortage Quantity";
            this.ShortageQuantity.MinimumWidth = 6;
            this.ShortageQuantity.Name = "ShortageQuantity";
            this.ShortageQuantity.ReadOnly = true;
            // 
            // OrderQuantity
            // 
            this.OrderQuantity.HeaderText = "OrderQuantity";
            this.OrderQuantity.MinimumWidth = 6;
            this.OrderQuantity.Name = "OrderQuantity";
            this.OrderQuantity.ReadOnly = true;
            // 
            // RandomDigitForLeadTime
            // 
            this.RandomDigitForLeadTime.HeaderText = "Random Digit for Lead Time";
            this.RandomDigitForLeadTime.MinimumWidth = 6;
            this.RandomDigitForLeadTime.Name = "RandomDigitForLeadTime";
            this.RandomDigitForLeadTime.ReadOnly = true;
            // 
            // LeadTime
            // 
            this.LeadTime.HeaderText = "Lead Time";
            this.LeadTime.MinimumWidth = 6;
            this.LeadTime.Name = "LeadTime";
            this.LeadTime.ReadOnly = true;
            // 
            // DaysUntilOrderArrives
            // 
            this.DaysUntilOrderArrives.HeaderText = "Days Until Order Arrives";
            this.DaysUntilOrderArrives.Name = "DaysUntilOrderArrives";
            this.DaysUntilOrderArrives.ReadOnly = true;
            // 
            // SimulationTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 476);
            this.Controls.Add(this.DailyCostPannel);
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
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Button backToWelcomeBtn;
        private System.Windows.Forms.Button showMesuresBtn;
        private System.Windows.Forms.Panel DailyCostPannel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn cycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayWithinCycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn beginingInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn randomDigitsForDemand;
        private System.Windows.Forms.DataGridViewTextBoxColumn demand;
        private System.Windows.Forms.DataGridViewTextBoxColumn endingInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortageQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandomDigitForLeadTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeadTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysUntilOrderArrives;
    }
}