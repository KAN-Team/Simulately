
namespace MultiQueueSimulation
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
            this.PurchasePriceGroup = new System.Windows.Forms.GroupBox();
            this.PurchasePriceTxt = new System.Windows.Forms.TextBox();
            this.scrapPriceGroup = new System.Windows.Forms.GroupBox();
            this.howToSelectLbl = new System.Windows.Forms.Label();
            this.newspapersNumGroup = new System.Windows.Forms.GroupBox();
            this.numOfNewspapersTxt = new System.Windows.Forms.TextBox();
            this.ScrapPriceTxt = new System.Windows.Forms.TextBox();
            this.recordsNumGroup = new System.Windows.Forms.GroupBox();
            this.numOfRecordsTxt = new System.Windows.Forms.TextBox();
            this.sellingPriceGroup = new System.Windows.Forms.GroupBox();
            this.sellingPriceTxt = new System.Windows.Forms.TextBox();
            this.containerPanel.SuspendLayout();
            this.PurchasePriceGroup.SuspendLayout();
            this.scrapPriceGroup.SuspendLayout();
            this.newspapersNumGroup.SuspendLayout();
            this.recordsNumGroup.SuspendLayout();
            this.sellingPriceGroup.SuspendLayout();
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
            // PurchasePriceGroup
            // 
            this.PurchasePriceGroup.Controls.Add(this.PurchasePriceTxt);
            this.PurchasePriceGroup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PurchasePriceGroup.Location = new System.Drawing.Point(129, 203);
            this.PurchasePriceGroup.Name = "PurchasePriceGroup";
            this.PurchasePriceGroup.Size = new System.Drawing.Size(359, 70);
            this.PurchasePriceGroup.TabIndex = 10;
            this.PurchasePriceGroup.TabStop = false;
            this.PurchasePriceGroup.Text = "Purchase Price";
            // 
            // PurchasePriceTxt
            // 
            this.PurchasePriceTxt.Location = new System.Drawing.Point(81, 30);
            this.PurchasePriceTxt.Name = "PurchasePriceTxt";
            this.PurchasePriceTxt.Size = new System.Drawing.Size(198, 30);
            this.PurchasePriceTxt.TabIndex = 7;
            this.PurchasePriceTxt.Text = "2";
            this.PurchasePriceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PurchasePriceTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOfServersTxt_KeyPress);
            // 
            // scrapPriceGroup
            // 
            this.scrapPriceGroup.Controls.Add(this.ScrapPriceTxt);
            this.scrapPriceGroup.Controls.Add(this.howToSelectLbl);
            this.scrapPriceGroup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.scrapPriceGroup.Location = new System.Drawing.Point(129, 282);
            this.scrapPriceGroup.Name = "scrapPriceGroup";
            this.scrapPriceGroup.Size = new System.Drawing.Size(359, 88);
            this.scrapPriceGroup.TabIndex = 10;
            this.scrapPriceGroup.TabStop = false;
            this.scrapPriceGroup.Text = "Scrap Price";
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
            this.newspapersNumGroup.Controls.Add(this.numOfNewspapersTxt);
            this.newspapersNumGroup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.newspapersNumGroup.Location = new System.Drawing.Point(129, 45);
            this.newspapersNumGroup.Name = "newspapersNumGroup";
            this.newspapersNumGroup.Size = new System.Drawing.Size(359, 70);
            this.newspapersNumGroup.TabIndex = 9;
            this.newspapersNumGroup.TabStop = false;
            this.newspapersNumGroup.Text = "Number of Newspapers";
            // 
            // numOfNewspapersTxt
            // 
            this.numOfNewspapersTxt.Location = new System.Drawing.Point(81, 30);
            this.numOfNewspapersTxt.Name = "numOfNewspapersTxt";
            this.numOfNewspapersTxt.Size = new System.Drawing.Size(198, 30);
            this.numOfNewspapersTxt.TabIndex = 8;
            this.numOfNewspapersTxt.Text = "2";
            this.numOfNewspapersTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numOfNewspapersTxt.TextChanged += new System.EventHandler(this.numberOfServersTxt_TextChanged);
            this.numOfNewspapersTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOfServersTxt_KeyPress);
            // 
            // ScrapPriceTxt
            // 
            this.ScrapPriceTxt.Location = new System.Drawing.Point(81, 47);
            this.ScrapPriceTxt.Name = "ScrapPriceTxt";
            this.ScrapPriceTxt.Size = new System.Drawing.Size(198, 30);
            this.ScrapPriceTxt.TabIndex = 9;
            this.ScrapPriceTxt.Text = "2";
            this.ScrapPriceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // recordsNumGroup
            // 
            this.recordsNumGroup.Controls.Add(this.numOfRecordsTxt);
            this.recordsNumGroup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.recordsNumGroup.Location = new System.Drawing.Point(129, 124);
            this.recordsNumGroup.Name = "recordsNumGroup";
            this.recordsNumGroup.Size = new System.Drawing.Size(359, 70);
            this.recordsNumGroup.TabIndex = 11;
            this.recordsNumGroup.TabStop = false;
            this.recordsNumGroup.Text = "Number of Records";
            // 
            // numOfRecordsTxt
            // 
            this.numOfRecordsTxt.Location = new System.Drawing.Point(81, 30);
            this.numOfRecordsTxt.Name = "numOfRecordsTxt";
            this.numOfRecordsTxt.Size = new System.Drawing.Size(198, 30);
            this.numOfRecordsTxt.TabIndex = 8;
            this.numOfRecordsTxt.Text = "2";
            this.numOfRecordsTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.PurchasePriceGroup.ResumeLayout(false);
            this.PurchasePriceGroup.PerformLayout();
            this.scrapPriceGroup.ResumeLayout(false);
            this.scrapPriceGroup.PerformLayout();
            this.newspapersNumGroup.ResumeLayout(false);
            this.newspapersNumGroup.PerformLayout();
            this.recordsNumGroup.ResumeLayout(false);
            this.recordsNumGroup.PerformLayout();
            this.sellingPriceGroup.ResumeLayout(false);
            this.sellingPriceGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.GroupBox newspapersNumGroup;
        private System.Windows.Forms.GroupBox scrapPriceGroup;
        private System.Windows.Forms.Label howToSelectLbl;
        private System.Windows.Forms.GroupBox PurchasePriceGroup;
        private System.Windows.Forms.TextBox PurchasePriceTxt;
        private System.Windows.Forms.TextBox numOfNewspapersTxt;
        private System.Windows.Forms.TextBox ScrapPriceTxt;
        private System.Windows.Forms.GroupBox sellingPriceGroup;
        private System.Windows.Forms.TextBox sellingPriceTxt;
        private System.Windows.Forms.GroupBox recordsNumGroup;
        private System.Windows.Forms.TextBox numOfRecordsTxt;
    }
}
