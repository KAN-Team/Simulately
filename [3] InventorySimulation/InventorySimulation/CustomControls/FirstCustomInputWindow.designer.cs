
namespace InventorySimulation
{
    partial class FirstCustomInputWindow
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
            this.containerPanel = new System.Windows.Forms.Panel();
            this.NumberOfDaysGroup = new System.Windows.Forms.GroupBox();
            this.numberOfDaysTxt = new System.Windows.Forms.TextBox();
            this.StartLeadDaysGroup = new System.Windows.Forms.GroupBox();
            this.startLeadDaysTxt = new System.Windows.Forms.TextBox();
            this.StartOrderQuantityGroup = new System.Windows.Forms.GroupBox();
            this.startOrderQuantityTxt = new System.Windows.Forms.TextBox();
            this.ReviewPeriodGroup = new System.Windows.Forms.GroupBox();
            this.reviewPeriodTxt = new System.Windows.Forms.TextBox();
            this.StartInventoryQuantityGroup = new System.Windows.Forms.GroupBox();
            this.startInventoryQuantityTxt = new System.Windows.Forms.TextBox();
            this.OrderUpToGroup = new System.Windows.Forms.GroupBox();
            this.orderUpToTxt = new System.Windows.Forms.TextBox();
            this.containerPanel.SuspendLayout();
            this.NumberOfDaysGroup.SuspendLayout();
            this.StartLeadDaysGroup.SuspendLayout();
            this.StartOrderQuantityGroup.SuspendLayout();
            this.ReviewPeriodGroup.SuspendLayout();
            this.StartInventoryQuantityGroup.SuspendLayout();
            this.OrderUpToGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.containerPanel.Controls.Add(this.NumberOfDaysGroup);
            this.containerPanel.Controls.Add(this.StartLeadDaysGroup);
            this.containerPanel.Controls.Add(this.StartOrderQuantityGroup);
            this.containerPanel.Controls.Add(this.ReviewPeriodGroup);
            this.containerPanel.Controls.Add(this.StartInventoryQuantityGroup);
            this.containerPanel.Controls.Add(this.OrderUpToGroup);
            this.containerPanel.Location = new System.Drawing.Point(10, 10);
            this.containerPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(580, 480);
            this.containerPanel.TabIndex = 1;
            // 
            // NumberOfDaysGroup
            // 
            this.NumberOfDaysGroup.Controls.Add(this.numberOfDaysTxt);
            this.NumberOfDaysGroup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NumberOfDaysGroup.Location = new System.Drawing.Point(129, 398);
            this.NumberOfDaysGroup.Name = "NumberOfDaysGroup";
            this.NumberOfDaysGroup.Size = new System.Drawing.Size(359, 70);
            this.NumberOfDaysGroup.TabIndex = 12;
            this.NumberOfDaysGroup.TabStop = false;
            this.NumberOfDaysGroup.Text = "Number Of Days";
            // 
            // numberOfDaysTxt
            // 
            this.numberOfDaysTxt.Location = new System.Drawing.Point(81, 30);
            this.numberOfDaysTxt.Name = "numberOfDaysTxt";
            this.numberOfDaysTxt.Size = new System.Drawing.Size(198, 30);
            this.numberOfDaysTxt.TabIndex = 7;
            this.numberOfDaysTxt.Text = "2";
            this.numberOfDaysTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numberOfDaysTxt.TextChanged += new System.EventHandler(this.orderUpToTxt_TextChanged);
            this.numberOfDaysTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.orderUpToTxt_KeyPress);
            // 
            // StartLeadDaysGroup
            // 
            this.StartLeadDaysGroup.Controls.Add(this.startLeadDaysTxt);
            this.StartLeadDaysGroup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.StartLeadDaysGroup.Location = new System.Drawing.Point(129, 244);
            this.StartLeadDaysGroup.Name = "StartLeadDaysGroup";
            this.StartLeadDaysGroup.Size = new System.Drawing.Size(359, 70);
            this.StartLeadDaysGroup.TabIndex = 12;
            this.StartLeadDaysGroup.TabStop = false;
            this.StartLeadDaysGroup.Text = "Start Lead Days";
            // 
            // startLeadDaysTxt
            // 
            this.startLeadDaysTxt.Location = new System.Drawing.Point(81, 30);
            this.startLeadDaysTxt.Name = "startLeadDaysTxt";
            this.startLeadDaysTxt.Size = new System.Drawing.Size(198, 30);
            this.startLeadDaysTxt.TabIndex = 7;
            this.startLeadDaysTxt.Text = "2";
            this.startLeadDaysTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startLeadDaysTxt.TextChanged += new System.EventHandler(this.orderUpToTxt_TextChanged);
            this.startLeadDaysTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.orderUpToTxt_KeyPress);
            // 
            // StartOrderQuantityGroup
            // 
            this.StartOrderQuantityGroup.Controls.Add(this.startOrderQuantityTxt);
            this.StartOrderQuantityGroup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.StartOrderQuantityGroup.Location = new System.Drawing.Point(129, 321);
            this.StartOrderQuantityGroup.Name = "StartOrderQuantityGroup";
            this.StartOrderQuantityGroup.Size = new System.Drawing.Size(359, 70);
            this.StartOrderQuantityGroup.TabIndex = 11;
            this.StartOrderQuantityGroup.TabStop = false;
            this.StartOrderQuantityGroup.Text = "Start Order Quantity";
            // 
            // startOrderQuantityTxt
            // 
            this.startOrderQuantityTxt.Location = new System.Drawing.Point(81, 30);
            this.startOrderQuantityTxt.Name = "startOrderQuantityTxt";
            this.startOrderQuantityTxt.Size = new System.Drawing.Size(198, 30);
            this.startOrderQuantityTxt.TabIndex = 7;
            this.startOrderQuantityTxt.Text = "2";
            this.startOrderQuantityTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startOrderQuantityTxt.TextChanged += new System.EventHandler(this.orderUpToTxt_TextChanged);
            this.startOrderQuantityTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.orderUpToTxt_KeyPress);
            // 
            // ReviewPeriodGroup
            // 
            this.ReviewPeriodGroup.Controls.Add(this.reviewPeriodTxt);
            this.ReviewPeriodGroup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ReviewPeriodGroup.Location = new System.Drawing.Point(129, 90);
            this.ReviewPeriodGroup.Name = "ReviewPeriodGroup";
            this.ReviewPeriodGroup.Size = new System.Drawing.Size(359, 70);
            this.ReviewPeriodGroup.TabIndex = 11;
            this.ReviewPeriodGroup.TabStop = false;
            this.ReviewPeriodGroup.Text = "Review Period";
            // 
            // reviewPeriodTxt
            // 
            this.reviewPeriodTxt.Location = new System.Drawing.Point(81, 30);
            this.reviewPeriodTxt.Name = "reviewPeriodTxt";
            this.reviewPeriodTxt.Size = new System.Drawing.Size(198, 30);
            this.reviewPeriodTxt.TabIndex = 8;
            this.reviewPeriodTxt.Text = "2";
            this.reviewPeriodTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.reviewPeriodTxt.TextChanged += new System.EventHandler(this.orderUpToTxt_TextChanged);
            this.reviewPeriodTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.orderUpToTxt_KeyPress);
            // 
            // StartInventoryQuantityGroup
            // 
            this.StartInventoryQuantityGroup.Controls.Add(this.startInventoryQuantityTxt);
            this.StartInventoryQuantityGroup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.StartInventoryQuantityGroup.Location = new System.Drawing.Point(129, 167);
            this.StartInventoryQuantityGroup.Name = "StartInventoryQuantityGroup";
            this.StartInventoryQuantityGroup.Size = new System.Drawing.Size(359, 70);
            this.StartInventoryQuantityGroup.TabIndex = 10;
            this.StartInventoryQuantityGroup.TabStop = false;
            this.StartInventoryQuantityGroup.Text = "Start Inventory Quantity";
            // 
            // startInventoryQuantityTxt
            // 
            this.startInventoryQuantityTxt.Location = new System.Drawing.Point(81, 30);
            this.startInventoryQuantityTxt.Name = "startInventoryQuantityTxt";
            this.startInventoryQuantityTxt.Size = new System.Drawing.Size(198, 30);
            this.startInventoryQuantityTxt.TabIndex = 7;
            this.startInventoryQuantityTxt.Text = "2";
            this.startInventoryQuantityTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startInventoryQuantityTxt.TextChanged += new System.EventHandler(this.orderUpToTxt_TextChanged);
            this.startInventoryQuantityTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.orderUpToTxt_KeyPress);
            // 
            // OrderUpToGroup
            // 
            this.OrderUpToGroup.Controls.Add(this.orderUpToTxt);
            this.OrderUpToGroup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.OrderUpToGroup.Location = new System.Drawing.Point(129, 13);
            this.OrderUpToGroup.Name = "OrderUpToGroup";
            this.OrderUpToGroup.Size = new System.Drawing.Size(359, 70);
            this.OrderUpToGroup.TabIndex = 9;
            this.OrderUpToGroup.TabStop = false;
            this.OrderUpToGroup.Text = "Order Up To Level";
            // 
            // orderUpToTxt
            // 
            this.orderUpToTxt.Location = new System.Drawing.Point(81, 30);
            this.orderUpToTxt.Name = "orderUpToTxt";
            this.orderUpToTxt.Size = new System.Drawing.Size(198, 30);
            this.orderUpToTxt.TabIndex = 8;
            this.orderUpToTxt.Text = "2";
            this.orderUpToTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.orderUpToTxt.TextChanged += new System.EventHandler(this.orderUpToTxt_TextChanged);
            this.orderUpToTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.orderUpToTxt_KeyPress);
            // 
            // FirstCustomInputWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.containerPanel);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FirstCustomInputWindow";
            this.Size = new System.Drawing.Size(600, 500);
            this.containerPanel.ResumeLayout(false);
            this.NumberOfDaysGroup.ResumeLayout(false);
            this.NumberOfDaysGroup.PerformLayout();
            this.StartLeadDaysGroup.ResumeLayout(false);
            this.StartLeadDaysGroup.PerformLayout();
            this.StartOrderQuantityGroup.ResumeLayout(false);
            this.StartOrderQuantityGroup.PerformLayout();
            this.ReviewPeriodGroup.ResumeLayout(false);
            this.ReviewPeriodGroup.PerformLayout();
            this.StartInventoryQuantityGroup.ResumeLayout(false);
            this.StartInventoryQuantityGroup.PerformLayout();
            this.OrderUpToGroup.ResumeLayout(false);
            this.OrderUpToGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.GroupBox OrderUpToGroup;
        private System.Windows.Forms.GroupBox StartInventoryQuantityGroup;
        private System.Windows.Forms.TextBox startInventoryQuantityTxt;
        private System.Windows.Forms.TextBox orderUpToTxt;
        private System.Windows.Forms.GroupBox StartOrderQuantityGroup;
        private System.Windows.Forms.TextBox startOrderQuantityTxt;
        private System.Windows.Forms.GroupBox ReviewPeriodGroup;
        private System.Windows.Forms.TextBox reviewPeriodTxt;
        private System.Windows.Forms.GroupBox StartLeadDaysGroup;
        private System.Windows.Forms.TextBox startLeadDaysTxt;
        private System.Windows.Forms.GroupBox NumberOfDaysGroup;
        private System.Windows.Forms.TextBox numberOfDaysTxt;
    }
}
