namespace InventorySimulation
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.orderUpToGroup = new System.Windows.Forms.GroupBox();
            this.reviewPeriodGroup = new System.Windows.Forms.GroupBox();
            this.startInventoryQuantityGroup = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.startLeadDaysGroup = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.startOrderQuantityGroup = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.numberOfDaysGroup = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.leadDaysDGV = new System.Windows.Forms.DataGridView();
            this.demand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interarrivalLbl = new System.Windows.Forms.Label();
            this.demandDGV = new System.Windows.Forms.DataGridView();
            this.leadDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probability2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceTimeLbl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.orderUpToGroup.SuspendLayout();
            this.reviewPeriodGroup.SuspendLayout();
            this.startInventoryQuantityGroup.SuspendLayout();
            this.startLeadDaysGroup.SuspendLayout();
            this.startOrderQuantityGroup.SuspendLayout();
            this.numberOfDaysGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leadDaysDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demandDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 29);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(83, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(39, 29);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(92, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 8);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1311, 378);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Indigo;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(488, 568);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 77);
            this.button1.TabIndex = 13;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // orderUpToGroup
            // 
            this.orderUpToGroup.Controls.Add(this.textBox1);
            this.orderUpToGroup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.orderUpToGroup.Location = new System.Drawing.Point(13, 404);
            this.orderUpToGroup.Name = "orderUpToGroup";
            this.orderUpToGroup.Size = new System.Drawing.Size(168, 65);
            this.orderUpToGroup.TabIndex = 14;
            this.orderUpToGroup.TabStop = false;
            this.orderUpToGroup.Text = "OrderUpTo";
            this.orderUpToGroup.Enter += new System.EventHandler(this.orderUpToGroup_Enter);
            // 
            // reviewPeriodGroup
            // 
            this.reviewPeriodGroup.Controls.Add(this.textBox2);
            this.reviewPeriodGroup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.reviewPeriodGroup.Location = new System.Drawing.Point(215, 404);
            this.reviewPeriodGroup.Name = "reviewPeriodGroup";
            this.reviewPeriodGroup.Size = new System.Drawing.Size(165, 65);
            this.reviewPeriodGroup.TabIndex = 15;
            this.reviewPeriodGroup.TabStop = false;
            this.reviewPeriodGroup.Text = "ReviewPeriod";
            // 
            // startInventoryQuantityGroup
            // 
            this.startInventoryQuantityGroup.Controls.Add(this.textBox3);
            this.startInventoryQuantityGroup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.startInventoryQuantityGroup.Location = new System.Drawing.Point(422, 404);
            this.startInventoryQuantityGroup.Name = "startInventoryQuantityGroup";
            this.startInventoryQuantityGroup.Size = new System.Drawing.Size(172, 65);
            this.startInventoryQuantityGroup.TabIndex = 16;
            this.startInventoryQuantityGroup.TabStop = false;
            this.startInventoryQuantityGroup.Text = "StartInventoryQuantity";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(46, 29);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(92, 20);
            this.textBox3.TabIndex = 3;
            // 
            // startLeadDaysGroup
            // 
            this.startLeadDaysGroup.Controls.Add(this.textBox4);
            this.startLeadDaysGroup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.startLeadDaysGroup.Location = new System.Drawing.Point(629, 404);
            this.startLeadDaysGroup.Name = "startLeadDaysGroup";
            this.startLeadDaysGroup.Size = new System.Drawing.Size(175, 65);
            this.startLeadDaysGroup.TabIndex = 17;
            this.startLeadDaysGroup.TabStop = false;
            this.startLeadDaysGroup.Text = "StartLeadDays";
            this.startLeadDaysGroup.Enter += new System.EventHandler(this.startLeadDaysGroup_Enter);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(49, 29);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(92, 20);
            this.textBox4.TabIndex = 4;
            // 
            // startOrderQuantityGroup
            // 
            this.startOrderQuantityGroup.Controls.Add(this.textBox5);
            this.startOrderQuantityGroup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.startOrderQuantityGroup.Location = new System.Drawing.Point(841, 404);
            this.startOrderQuantityGroup.Name = "startOrderQuantityGroup";
            this.startOrderQuantityGroup.Size = new System.Drawing.Size(187, 65);
            this.startOrderQuantityGroup.TabIndex = 18;
            this.startOrderQuantityGroup.TabStop = false;
            this.startOrderQuantityGroup.Text = "StartOrderQuantity";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(56, 25);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(92, 20);
            this.textBox5.TabIndex = 5;
            // 
            // numberOfDaysGroup
            // 
            this.numberOfDaysGroup.Controls.Add(this.textBox6);
            this.numberOfDaysGroup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.numberOfDaysGroup.Location = new System.Drawing.Point(1058, 404);
            this.numberOfDaysGroup.Name = "numberOfDaysGroup";
            this.numberOfDaysGroup.Size = new System.Drawing.Size(193, 65);
            this.numberOfDaysGroup.TabIndex = 19;
            this.numberOfDaysGroup.TabStop = false;
            this.numberOfDaysGroup.Text = "NumberOfDays";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(51, 25);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(92, 20);
            this.textBox6.TabIndex = 13;
            // 
            // leadDaysDGV
            // 
            this.leadDaysDGV.AllowUserToDeleteRows = false;
            this.leadDaysDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.leadDaysDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.leadDaysDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.leadDaysDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.leadDaysDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leadDaysDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.demand,
            this.probability});
            this.leadDaysDGV.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.leadDaysDGV.DefaultCellStyle = dataGridViewCellStyle20;
            this.leadDaysDGV.Location = new System.Drawing.Point(13, 500);
            this.leadDaysDGV.Name = "leadDaysDGV";
            this.leadDaysDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.leadDaysDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.leadDaysDGV.RowHeadersVisible = false;
            this.leadDaysDGV.Size = new System.Drawing.Size(458, 151);
            this.leadDaysDGV.TabIndex = 20;
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
            // interarrivalLbl
            // 
            this.interarrivalLbl.AutoSize = true;
            this.interarrivalLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.interarrivalLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interarrivalLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.interarrivalLbl.Location = new System.Drawing.Point(162, 474);
            this.interarrivalLbl.Name = "interarrivalLbl";
            this.interarrivalLbl.Size = new System.Drawing.Size(166, 23);
            this.interarrivalLbl.TabIndex = 21;
            this.interarrivalLbl.Text = "Demand Distribution";
            // 
            // demandDGV
            // 
            this.demandDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.demandDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.demandDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.demandDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.demandDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.demandDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.leadDays,
            this.probability2});
            this.demandDGV.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.demandDGV.DefaultCellStyle = dataGridViewCellStyle23;
            this.demandDGV.Location = new System.Drawing.Point(678, 500);
            this.demandDGV.Name = "demandDGV";
            this.demandDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.demandDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.demandDGV.RowHeadersVisible = false;
            this.demandDGV.Size = new System.Drawing.Size(574, 151);
            this.demandDGV.TabIndex = 22;
            // 
            // leadDays
            // 
            this.leadDays.HeaderText = "Lead Days";
            this.leadDays.Name = "leadDays";
            // 
            // probability2
            // 
            this.probability2.HeaderText = "Probability";
            this.probability2.Name = "probability2";
            // 
            // serviceTimeLbl
            // 
            this.serviceTimeLbl.AutoSize = true;
            this.serviceTimeLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.serviceTimeLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceTimeLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.serviceTimeLbl.Location = new System.Drawing.Point(875, 474);
            this.serviceTimeLbl.Name = "serviceTimeLbl";
            this.serviceTimeLbl.Size = new System.Drawing.Size(188, 23);
            this.serviceTimeLbl.TabIndex = 23;
            this.serviceTimeLbl.Text = "Lead Days Distribution";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.YellowGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(488, 525);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 39);
            this.button2.TabIndex = 24;
            this.button2.Text = "Load File";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1325, 656);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.serviceTimeLbl);
            this.Controls.Add(this.demandDGV);
            this.Controls.Add(this.interarrivalLbl);
            this.Controls.Add(this.leadDaysDGV);
            this.Controls.Add(this.numberOfDaysGroup);
            this.Controls.Add(this.startOrderQuantityGroup);
            this.Controls.Add(this.startLeadDaysGroup);
            this.Controls.Add(this.startInventoryQuantityGroup);
            this.Controls.Add(this.reviewPeriodGroup);
            this.Controls.Add(this.orderUpToGroup);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.orderUpToGroup.ResumeLayout(false);
            this.orderUpToGroup.PerformLayout();
            this.reviewPeriodGroup.ResumeLayout(false);
            this.reviewPeriodGroup.PerformLayout();
            this.startInventoryQuantityGroup.ResumeLayout(false);
            this.startInventoryQuantityGroup.PerformLayout();
            this.startLeadDaysGroup.ResumeLayout(false);
            this.startLeadDaysGroup.PerformLayout();
            this.startOrderQuantityGroup.ResumeLayout(false);
            this.startOrderQuantityGroup.PerformLayout();
            this.numberOfDaysGroup.ResumeLayout(false);
            this.numberOfDaysGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leadDaysDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demandDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox orderUpToGroup;
        private System.Windows.Forms.GroupBox reviewPeriodGroup;
        private System.Windows.Forms.GroupBox startInventoryQuantityGroup;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox startLeadDaysGroup;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox startOrderQuantityGroup;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox numberOfDaysGroup;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridView leadDaysDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn demand;
        private System.Windows.Forms.DataGridViewTextBoxColumn probability;
        private System.Windows.Forms.Label interarrivalLbl;
        private System.Windows.Forms.DataGridView demandDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn leadDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn probability2;
        private System.Windows.Forms.Label serviceTimeLbl;
        private System.Windows.Forms.Button button2;
    }
}

