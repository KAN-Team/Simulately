
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
            this.sellingPriceGroup = new System.Windows.Forms.GroupBox();
            this.sellingPriceTxt = new System.Windows.Forms.TextBox();
            this.recordsNumGroup = new System.Windows.Forms.GroupBox();
            this.numberOfRecordsTxt = new System.Windows.Forms.TextBox();
            this.PurchasePriceGroup = new System.Windows.Forms.GroupBox();
            this.purchasePriceTxt = new System.Windows.Forms.TextBox();
            this.scrapPriceGroup = new System.Windows.Forms.GroupBox();
            this.scrapPriceTxt = new System.Windows.Forms.TextBox();
            this.howToSelectLbl = new System.Windows.Forms.Label();
            this.newspapersNumGroup = new System.Windows.Forms.GroupBox();
            this.numberOfNewspapersTxt = new System.Windows.Forms.TextBox();
            this.containerPanel.SuspendLayout();
            this.sellingPriceGroup.SuspendLayout();
            this.recordsNumGroup.SuspendLayout();
            this.PurchasePriceGroup.SuspendLayout();
            this.scrapPriceGroup.SuspendLayout();
            this.newspapersNumGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.containerPanel.Controls.Add(this.sellingPriceGroup);
            this.containerPanel.Controls.Add(this.recordsNumGroup);
            this.containerPanel.Controls.Add(this.PurchasePriceGroup);
            this.containerPanel.Controls.Add(this.scrapPriceGroup);
            this.containerPanel.Controls.Add(this.newspapersNumGroup);
            this.containerPanel.Location = new System.Drawing.Point(10, 10);
            this.containerPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(580, 480);
            this.containerPanel.TabIndex = 1;
            // 
            // sellingPriceGroup
            // 
            this.sellingPriceGroup.Controls.Add(this.sellingPriceTxt);
            this.sellingPriceGroup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.sellingPriceGroup.Location = new System.Drawing.Point(129, 379);
            this.sellingPriceGroup.Name = "sellingPriceGroup";
            this.sellingPriceGroup.Size = new System.Drawing.Size(359, 70);
            this.sellingPriceGroup.TabIndex = 11;
            this.sellingPriceGroup.TabStop = false;
            this.sellingPriceGroup.Text = "Selling Price";
            // 
            // sellingPriceTxt
            // 
            this.sellingPriceTxt.Location = new System.Drawing.Point(81, 30);
            this.sellingPriceTxt.Name = "sellingPriceTxt";
            this.sellingPriceTxt.Size = new System.Drawing.Size(198, 30);
            this.sellingPriceTxt.TabIndex = 7;
            this.sellingPriceTxt.Text = "2";
            this.sellingPriceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sellingPriceTxt.TextChanged += new System.EventHandler(this.numberOfNewspapersTxt_TextChanged);
            this.sellingPriceTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PurchasePriceTxt_KeyPress);
            // 
            // recordsNumGroup
            // 
            this.recordsNumGroup.Controls.Add(this.numberOfRecordsTxt);
            this.recordsNumGroup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.recordsNumGroup.Location = new System.Drawing.Point(129, 124);
            this.recordsNumGroup.Name = "recordsNumGroup";
            this.recordsNumGroup.Size = new System.Drawing.Size(359, 70);
            this.recordsNumGroup.TabIndex = 11;
            this.recordsNumGroup.TabStop = false;
            this.recordsNumGroup.Text = "Number of Records";
            // 
            // numberOfRecordsTxt
            // 
            this.numberOfRecordsTxt.Location = new System.Drawing.Point(81, 30);
            this.numberOfRecordsTxt.Name = "numberOfRecordsTxt";
            this.numberOfRecordsTxt.Size = new System.Drawing.Size(198, 30);
            this.numberOfRecordsTxt.TabIndex = 8;
            this.numberOfRecordsTxt.Text = "2";
            this.numberOfRecordsTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numberOfRecordsTxt.TextChanged += new System.EventHandler(this.numberOfNewspapersTxt_TextChanged);
            this.numberOfRecordsTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOfNewspapersTxt_KeyPress);
            // 
            // PurchasePriceGroup
            // 
            this.PurchasePriceGroup.Controls.Add(this.purchasePriceTxt);
            this.PurchasePriceGroup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PurchasePriceGroup.Location = new System.Drawing.Point(129, 203);
            this.PurchasePriceGroup.Name = "PurchasePriceGroup";
            this.PurchasePriceGroup.Size = new System.Drawing.Size(359, 70);
            this.PurchasePriceGroup.TabIndex = 10;
            this.PurchasePriceGroup.TabStop = false;
            this.PurchasePriceGroup.Text = "Purchase Price";
            // 
            // purchasePriceTxt
            // 
            this.purchasePriceTxt.Location = new System.Drawing.Point(81, 30);
            this.purchasePriceTxt.Name = "purchasePriceTxt";
            this.purchasePriceTxt.Size = new System.Drawing.Size(198, 30);
            this.purchasePriceTxt.TabIndex = 7;
            this.purchasePriceTxt.Text = "2";
            this.purchasePriceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.purchasePriceTxt.TextChanged += new System.EventHandler(this.numberOfNewspapersTxt_TextChanged);
            this.purchasePriceTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PurchasePriceTxt_KeyPress);
            // 
            // scrapPriceGroup
            // 
            this.scrapPriceGroup.Controls.Add(this.scrapPriceTxt);
            this.scrapPriceGroup.Controls.Add(this.howToSelectLbl);
            this.scrapPriceGroup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.scrapPriceGroup.Location = new System.Drawing.Point(129, 282);
            this.scrapPriceGroup.Name = "scrapPriceGroup";
            this.scrapPriceGroup.Size = new System.Drawing.Size(359, 88);
            this.scrapPriceGroup.TabIndex = 10;
            this.scrapPriceGroup.TabStop = false;
            this.scrapPriceGroup.Text = "Scrap Price";
            // 
            // scrapPriceTxt
            // 
            this.scrapPriceTxt.Location = new System.Drawing.Point(81, 47);
            this.scrapPriceTxt.Name = "scrapPriceTxt";
            this.scrapPriceTxt.Size = new System.Drawing.Size(198, 30);
            this.scrapPriceTxt.TabIndex = 9;
            this.scrapPriceTxt.Text = "2";
            this.scrapPriceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.scrapPriceTxt.TextChanged += new System.EventHandler(this.numberOfNewspapersTxt_TextChanged);
            this.scrapPriceTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PurchasePriceTxt_KeyPress);
            // 
            // howToSelectLbl
            // 
            this.howToSelectLbl.AutoSize = true;
            this.howToSelectLbl.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToSelectLbl.ForeColor = System.Drawing.Color.Crimson;
            this.howToSelectLbl.Location = new System.Drawing.Point(37, 23);
            this.howToSelectLbl.Name = "howToSelectLbl";
            this.howToSelectLbl.Size = new System.Drawing.Size(301, 16);
            this.howToSelectLbl.TabIndex = 5;
            this.howToSelectLbl.Text = "(Price of Newspapers not sold at the end of the day.)";
            // 
            // newspapersNumGroup
            // 
            this.newspapersNumGroup.Controls.Add(this.numberOfNewspapersTxt);
            this.newspapersNumGroup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.newspapersNumGroup.Location = new System.Drawing.Point(129, 45);
            this.newspapersNumGroup.Name = "newspapersNumGroup";
            this.newspapersNumGroup.Size = new System.Drawing.Size(359, 70);
            this.newspapersNumGroup.TabIndex = 9;
            this.newspapersNumGroup.TabStop = false;
            this.newspapersNumGroup.Text = "Number of Newspapers";
            // 
            // numberOfNewspapersTxt
            // 
            this.numberOfNewspapersTxt.Location = new System.Drawing.Point(81, 30);
            this.numberOfNewspapersTxt.Name = "numberOfNewspapersTxt";
            this.numberOfNewspapersTxt.Size = new System.Drawing.Size(198, 30);
            this.numberOfNewspapersTxt.TabIndex = 8;
            this.numberOfNewspapersTxt.Text = "2";
            this.numberOfNewspapersTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numberOfNewspapersTxt.TextChanged += new System.EventHandler(this.numberOfNewspapersTxt_TextChanged);
            this.numberOfNewspapersTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOfNewspapersTxt_KeyPress);
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
            this.sellingPriceGroup.ResumeLayout(false);
            this.sellingPriceGroup.PerformLayout();
            this.recordsNumGroup.ResumeLayout(false);
            this.recordsNumGroup.PerformLayout();
            this.PurchasePriceGroup.ResumeLayout(false);
            this.PurchasePriceGroup.PerformLayout();
            this.scrapPriceGroup.ResumeLayout(false);
            this.scrapPriceGroup.PerformLayout();
            this.newspapersNumGroup.ResumeLayout(false);
            this.newspapersNumGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.GroupBox newspapersNumGroup;
        private System.Windows.Forms.GroupBox scrapPriceGroup;
        private System.Windows.Forms.Label howToSelectLbl;
        private System.Windows.Forms.GroupBox PurchasePriceGroup;
        private System.Windows.Forms.TextBox purchasePriceTxt;
        private System.Windows.Forms.TextBox numberOfNewspapersTxt;
        private System.Windows.Forms.TextBox scrapPriceTxt;
        private System.Windows.Forms.GroupBox sellingPriceGroup;
        private System.Windows.Forms.TextBox sellingPriceTxt;
        private System.Windows.Forms.GroupBox recordsNumGroup;
        private System.Windows.Forms.TextBox numberOfRecordsTxt;
    }
}
