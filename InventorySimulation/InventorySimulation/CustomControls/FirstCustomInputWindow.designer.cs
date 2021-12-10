
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
            this.numberOfDaysGroup = new System.Windows.Forms.GroupBox();
            this.numberOfDaysTxt = new System.Windows.Forms.TextBox();
            this.startOrderQuantityGroup = new System.Windows.Forms.GroupBox();
            this.startOrderQuantityTxt = new System.Windows.Forms.TextBox();
            this.reviewPeriodGroup = new System.Windows.Forms.GroupBox();
            this.reviewPeriodTxt = new System.Windows.Forms.TextBox();
            this.startInventoryQuantityGroup = new System.Windows.Forms.GroupBox();
            this.startInventoryQuantityTxt = new System.Windows.Forms.TextBox();
            this.startLeadDaysGroup = new System.Windows.Forms.GroupBox();
            this.startLeadDaysTxt = new System.Windows.Forms.TextBox();
            this.orderUpToGroup = new System.Windows.Forms.GroupBox();
            this.orderUpToTxt = new System.Windows.Forms.TextBox();
            this.containerPanel.SuspendLayout();
            this.numberOfDaysGroup.SuspendLayout();
            this.startOrderQuantityGroup.SuspendLayout();
            this.reviewPeriodGroup.SuspendLayout();
            this.startInventoryQuantityGroup.SuspendLayout();
            this.startLeadDaysGroup.SuspendLayout();
            this.orderUpToGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.containerPanel.Controls.Add(this.numberOfDaysGroup);
            this.containerPanel.Controls.Add(this.startOrderQuantityGroup);
            this.containerPanel.Controls.Add(this.reviewPeriodGroup);
            this.containerPanel.Controls.Add(this.startInventoryQuantityGroup);
            this.containerPanel.Controls.Add(this.startLeadDaysGroup);
            this.containerPanel.Controls.Add(this.orderUpToGroup);
            this.containerPanel.Location = new System.Drawing.Point(10, 10);
            this.containerPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(580, 480);
            this.containerPanel.TabIndex = 1;
            this.containerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.containerPanel_Paint);
            // 
            // numberOfDaysGroup
            // 
            this.numberOfDaysGroup.Controls.Add(this.numberOfDaysTxt);
            this.numberOfDaysGroup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.numberOfDaysGroup.Location = new System.Drawing.Point(124, 402);
            this.numberOfDaysGroup.Name = "numberOfDaysGroup";
            this.numberOfDaysGroup.Size = new System.Drawing.Size(359, 70);
            this.numberOfDaysGroup.TabIndex = 12;
            this.numberOfDaysGroup.TabStop = false;
            this.numberOfDaysGroup.Text = "NumberOfDays";
            this.numberOfDaysGroup.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // numberOfDaysTxt
            // 
            this.numberOfDaysTxt.Location = new System.Drawing.Point(81, 30);
            this.numberOfDaysTxt.Name = "numberOfDaysTxt";
            this.numberOfDaysTxt.Size = new System.Drawing.Size(198, 30);
            this.numberOfDaysTxt.TabIndex = 7;
            this.numberOfDaysTxt.Text = "25";
            this.numberOfDaysTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startOrderQuantityGroup
            // 
            this.startOrderQuantityGroup.Controls.Add(this.startOrderQuantityTxt);
            this.startOrderQuantityGroup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.startOrderQuantityGroup.Location = new System.Drawing.Point(124, 326);
            this.startOrderQuantityGroup.Name = "startOrderQuantityGroup";
            this.startOrderQuantityGroup.Size = new System.Drawing.Size(359, 70);
            this.startOrderQuantityGroup.TabIndex = 11;
            this.startOrderQuantityGroup.TabStop = false;
            this.startOrderQuantityGroup.Text = "StartOrderQuantity";
            // 
            // startOrderQuantityTxt
            // 
            this.startOrderQuantityTxt.Location = new System.Drawing.Point(81, 30);
            this.startOrderQuantityTxt.Name = "startOrderQuantityTxt";
            this.startOrderQuantityTxt.Size = new System.Drawing.Size(198, 30);
            this.startOrderQuantityTxt.TabIndex = 7;
            this.startOrderQuantityTxt.Text = "8";
            this.startOrderQuantityTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startOrderQuantityTxt.TextChanged += new System.EventHandler(this.numberOfNewspapersTxt_TextChanged);
            this.startOrderQuantityTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PurchasePriceTxt_KeyPress);
            // 
            // reviewPeriodGroup
            // 
            this.reviewPeriodGroup.Controls.Add(this.reviewPeriodTxt);
            this.reviewPeriodGroup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.reviewPeriodGroup.Location = new System.Drawing.Point(124, 92);
            this.reviewPeriodGroup.Name = "reviewPeriodGroup";
            this.reviewPeriodGroup.Size = new System.Drawing.Size(359, 70);
            this.reviewPeriodGroup.TabIndex = 11;
            this.reviewPeriodGroup.TabStop = false;
            this.reviewPeriodGroup.Text = "ReviewPeriod";
            // 
            // reviewPeriodTxt
            // 
            this.reviewPeriodTxt.Location = new System.Drawing.Point(81, 30);
            this.reviewPeriodTxt.Name = "reviewPeriodTxt";
            this.reviewPeriodTxt.Size = new System.Drawing.Size(198, 30);
            this.reviewPeriodTxt.TabIndex = 8;
            this.reviewPeriodTxt.Text = "5";
            this.reviewPeriodTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.reviewPeriodTxt.TextChanged += new System.EventHandler(this.numberOfNewspapersTxt_TextChanged);
            this.reviewPeriodTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOfNewspapersTxt_KeyPress);
            // 
            // startInventoryQuantityGroup
            // 
            this.startInventoryQuantityGroup.Controls.Add(this.startInventoryQuantityTxt);
            this.startInventoryQuantityGroup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.startInventoryQuantityGroup.Location = new System.Drawing.Point(124, 171);
            this.startInventoryQuantityGroup.Name = "startInventoryQuantityGroup";
            this.startInventoryQuantityGroup.Size = new System.Drawing.Size(359, 70);
            this.startInventoryQuantityGroup.TabIndex = 10;
            this.startInventoryQuantityGroup.TabStop = false;
            this.startInventoryQuantityGroup.Text = "StartInventoryQuantity";
            // 
            // startInventoryQuantityTxt
            // 
            this.startInventoryQuantityTxt.Location = new System.Drawing.Point(81, 30);
            this.startInventoryQuantityTxt.Name = "startInventoryQuantityTxt";
            this.startInventoryQuantityTxt.Size = new System.Drawing.Size(198, 30);
            this.startInventoryQuantityTxt.TabIndex = 7;
            this.startInventoryQuantityTxt.Text = "3";
            this.startInventoryQuantityTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startInventoryQuantityTxt.TextChanged += new System.EventHandler(this.numberOfNewspapersTxt_TextChanged);
            this.startInventoryQuantityTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PurchasePriceTxt_KeyPress);
            // 
            // startLeadDaysGroup
            // 
            this.startLeadDaysGroup.Controls.Add(this.startLeadDaysTxt);
            this.startLeadDaysGroup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.startLeadDaysGroup.Location = new System.Drawing.Point(124, 247);
            this.startLeadDaysGroup.Name = "startLeadDaysGroup";
            this.startLeadDaysGroup.Size = new System.Drawing.Size(359, 73);
            this.startLeadDaysGroup.TabIndex = 10;
            this.startLeadDaysGroup.TabStop = false;
            this.startLeadDaysGroup.Text = "StartLeadDays";
            this.startLeadDaysGroup.Enter += new System.EventHandler(this.scrapPriceGroup_Enter);
            // 
            // startLeadDaysTxt
            // 
            this.startLeadDaysTxt.Location = new System.Drawing.Point(81, 29);
            this.startLeadDaysTxt.Name = "startLeadDaysTxt";
            this.startLeadDaysTxt.Size = new System.Drawing.Size(198, 30);
            this.startLeadDaysTxt.TabIndex = 9;
            this.startLeadDaysTxt.Text = "2";
            this.startLeadDaysTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startLeadDaysTxt.TextChanged += new System.EventHandler(this.numberOfNewspapersTxt_TextChanged);
            this.startLeadDaysTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PurchasePriceTxt_KeyPress);
            // 
            // orderUpToGroup
            // 
            this.orderUpToGroup.Controls.Add(this.orderUpToTxt);
            this.orderUpToGroup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.orderUpToGroup.Location = new System.Drawing.Point(124, 13);
            this.orderUpToGroup.Name = "orderUpToGroup";
            this.orderUpToGroup.Size = new System.Drawing.Size(359, 70);
            this.orderUpToGroup.TabIndex = 9;
            this.orderUpToGroup.TabStop = false;
            this.orderUpToGroup.Text = "OrderUpTo";
            this.orderUpToGroup.Enter += new System.EventHandler(this.newspapersNumGroup_Enter);
            // 
            // orderUpToTxt
            // 
            this.orderUpToTxt.Location = new System.Drawing.Point(81, 30);
            this.orderUpToTxt.Name = "orderUpToTxt";
            this.orderUpToTxt.Size = new System.Drawing.Size(198, 30);
            this.orderUpToTxt.TabIndex = 8;
            this.orderUpToTxt.Text = "11";
            this.orderUpToTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.orderUpToTxt.TextChanged += new System.EventHandler(this.numberOfNewspapersTxt_TextChanged);
            this.orderUpToTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOfNewspapersTxt_KeyPress);
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
            this.numberOfDaysGroup.ResumeLayout(false);
            this.numberOfDaysGroup.PerformLayout();
            this.startOrderQuantityGroup.ResumeLayout(false);
            this.startOrderQuantityGroup.PerformLayout();
            this.reviewPeriodGroup.ResumeLayout(false);
            this.reviewPeriodGroup.PerformLayout();
            this.startInventoryQuantityGroup.ResumeLayout(false);
            this.startInventoryQuantityGroup.PerformLayout();
            this.startLeadDaysGroup.ResumeLayout(false);
            this.startLeadDaysGroup.PerformLayout();
            this.orderUpToGroup.ResumeLayout(false);
            this.orderUpToGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.GroupBox orderUpToGroup;
        private System.Windows.Forms.TextBox orderUpToTxt;
        private System.Windows.Forms.GroupBox startLeadDaysGroup;
        private System.Windows.Forms.TextBox startLeadDaysTxt;
        private System.Windows.Forms.GroupBox startInventoryQuantityGroup;
        private System.Windows.Forms.TextBox startInventoryQuantityTxt;
        private System.Windows.Forms.GroupBox startOrderQuantityGroup;
        private System.Windows.Forms.TextBox startOrderQuantityTxt;
        private System.Windows.Forms.GroupBox reviewPeriodGroup;
        private System.Windows.Forms.TextBox reviewPeriodTxt;
        private System.Windows.Forms.GroupBox numberOfDaysGroup;
        private System.Windows.Forms.TextBox numberOfDaysTxt;
    }
}
