
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
            this.StartOrderQuantity = new System.Windows.Forms.GroupBox();
            this.sellingPriceTxt = new System.Windows.Forms.TextBox();
            this.ReviewPeriod = new System.Windows.Forms.GroupBox();
            this.numberOfRecordsTxt = new System.Windows.Forms.TextBox();
            this.StartInventoryQuantity = new System.Windows.Forms.GroupBox();
            this.purchasePriceTxt = new System.Windows.Forms.TextBox();
            this.OrderUpTo = new System.Windows.Forms.GroupBox();
            this.numberOfNewspapersTxt = new System.Windows.Forms.TextBox();
            this.StartLeadDays = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NumberOfDays = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.containerPanel.SuspendLayout();
            this.StartOrderQuantity.SuspendLayout();
            this.ReviewPeriod.SuspendLayout();
            this.StartInventoryQuantity.SuspendLayout();
            this.OrderUpTo.SuspendLayout();
            this.StartLeadDays.SuspendLayout();
            this.NumberOfDays.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.containerPanel.Controls.Add(this.NumberOfDays);
            this.containerPanel.Controls.Add(this.StartLeadDays);
            this.containerPanel.Controls.Add(this.StartOrderQuantity);
            this.containerPanel.Controls.Add(this.ReviewPeriod);
            this.containerPanel.Controls.Add(this.StartInventoryQuantity);
            this.containerPanel.Controls.Add(this.OrderUpTo);
            this.containerPanel.Location = new System.Drawing.Point(10, 10);
            this.containerPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(580, 480);
            this.containerPanel.TabIndex = 1;
            // 
            // StartOrderQuantity
            // 
            this.StartOrderQuantity.Controls.Add(this.sellingPriceTxt);
            this.StartOrderQuantity.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.StartOrderQuantity.Location = new System.Drawing.Point(129, 321);
            this.StartOrderQuantity.Name = "StartOrderQuantity";
            this.StartOrderQuantity.Size = new System.Drawing.Size(359, 70);
            this.StartOrderQuantity.TabIndex = 11;
            this.StartOrderQuantity.TabStop = false;
            this.StartOrderQuantity.Text = "Start Order Quantity";
            // 
            // sellingPriceTxt
            // 
            this.sellingPriceTxt.Location = new System.Drawing.Point(81, 30);
            this.sellingPriceTxt.Name = "sellingPriceTxt";
            this.sellingPriceTxt.Size = new System.Drawing.Size(198, 30);
            this.sellingPriceTxt.TabIndex = 7;
            this.sellingPriceTxt.Text = "2";
            this.sellingPriceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ReviewPeriod
            // 
            this.ReviewPeriod.Controls.Add(this.numberOfRecordsTxt);
            this.ReviewPeriod.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ReviewPeriod.Location = new System.Drawing.Point(129, 90);
            this.ReviewPeriod.Name = "ReviewPeriod";
            this.ReviewPeriod.Size = new System.Drawing.Size(359, 70);
            this.ReviewPeriod.TabIndex = 11;
            this.ReviewPeriod.TabStop = false;
            this.ReviewPeriod.Text = "Review Period";
            // 
            // numberOfRecordsTxt
            // 
            this.numberOfRecordsTxt.Location = new System.Drawing.Point(81, 30);
            this.numberOfRecordsTxt.Name = "numberOfRecordsTxt";
            this.numberOfRecordsTxt.Size = new System.Drawing.Size(198, 30);
            this.numberOfRecordsTxt.TabIndex = 8;
            this.numberOfRecordsTxt.Text = "2";
            this.numberOfRecordsTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StartInventoryQuantity
            // 
            this.StartInventoryQuantity.Controls.Add(this.purchasePriceTxt);
            this.StartInventoryQuantity.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.StartInventoryQuantity.Location = new System.Drawing.Point(129, 167);
            this.StartInventoryQuantity.Name = "StartInventoryQuantity";
            this.StartInventoryQuantity.Size = new System.Drawing.Size(359, 70);
            this.StartInventoryQuantity.TabIndex = 10;
            this.StartInventoryQuantity.TabStop = false;
            this.StartInventoryQuantity.Text = "Start Inventory Quantity";
            // 
            // purchasePriceTxt
            // 
            this.purchasePriceTxt.Location = new System.Drawing.Point(81, 30);
            this.purchasePriceTxt.Name = "purchasePriceTxt";
            this.purchasePriceTxt.Size = new System.Drawing.Size(198, 30);
            this.purchasePriceTxt.TabIndex = 7;
            this.purchasePriceTxt.Text = "2";
            this.purchasePriceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OrderUpTo
            // 
            this.OrderUpTo.Controls.Add(this.numberOfNewspapersTxt);
            this.OrderUpTo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.OrderUpTo.Location = new System.Drawing.Point(129, 13);
            this.OrderUpTo.Name = "OrderUpTo";
            this.OrderUpTo.Size = new System.Drawing.Size(359, 70);
            this.OrderUpTo.TabIndex = 9;
            this.OrderUpTo.TabStop = false;
            this.OrderUpTo.Text = "Order Up To Level";
            // 
            // numberOfNewspapersTxt
            // 
            this.numberOfNewspapersTxt.Location = new System.Drawing.Point(81, 30);
            this.numberOfNewspapersTxt.Name = "numberOfNewspapersTxt";
            this.numberOfNewspapersTxt.Size = new System.Drawing.Size(198, 30);
            this.numberOfNewspapersTxt.TabIndex = 8;
            this.numberOfNewspapersTxt.Text = "2";
            this.numberOfNewspapersTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StartLeadDays
            // 
            this.StartLeadDays.Controls.Add(this.textBox1);
            this.StartLeadDays.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.StartLeadDays.Location = new System.Drawing.Point(129, 244);
            this.StartLeadDays.Name = "StartLeadDays";
            this.StartLeadDays.Size = new System.Drawing.Size(359, 70);
            this.StartLeadDays.TabIndex = 12;
            this.StartLeadDays.TabStop = false;
            this.StartLeadDays.Text = "Start Lead Days";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 30);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "2";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NumberOfDays
            // 
            this.NumberOfDays.Controls.Add(this.textBox2);
            this.NumberOfDays.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NumberOfDays.Location = new System.Drawing.Point(129, 398);
            this.NumberOfDays.Name = "NumberOfDays";
            this.NumberOfDays.Size = new System.Drawing.Size(359, 70);
            this.NumberOfDays.TabIndex = 12;
            this.NumberOfDays.TabStop = false;
            this.NumberOfDays.Text = "Number Of Days";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(81, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 30);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "2";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.StartOrderQuantity.ResumeLayout(false);
            this.StartOrderQuantity.PerformLayout();
            this.ReviewPeriod.ResumeLayout(false);
            this.ReviewPeriod.PerformLayout();
            this.StartInventoryQuantity.ResumeLayout(false);
            this.StartInventoryQuantity.PerformLayout();
            this.OrderUpTo.ResumeLayout(false);
            this.OrderUpTo.PerformLayout();
            this.StartLeadDays.ResumeLayout(false);
            this.StartLeadDays.PerformLayout();
            this.NumberOfDays.ResumeLayout(false);
            this.NumberOfDays.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.GroupBox OrderUpTo;
        private System.Windows.Forms.GroupBox StartInventoryQuantity;
        private System.Windows.Forms.TextBox purchasePriceTxt;
        private System.Windows.Forms.TextBox numberOfNewspapersTxt;
        private System.Windows.Forms.GroupBox StartOrderQuantity;
        private System.Windows.Forms.TextBox sellingPriceTxt;
        private System.Windows.Forms.GroupBox ReviewPeriod;
        private System.Windows.Forms.TextBox numberOfRecordsTxt;
        private System.Windows.Forms.GroupBox StartLeadDays;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox NumberOfDays;
        private System.Windows.Forms.TextBox textBox2;
    }
}
