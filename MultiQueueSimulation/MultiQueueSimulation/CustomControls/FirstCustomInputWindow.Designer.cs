
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
            this.StoppingNumberGroup = new System.Windows.Forms.GroupBox();
            this.stoppingNumberTxt = new System.Windows.Forms.TextBox();
            this.stoppingCriteriaGroup = new System.Windows.Forms.GroupBox();
            this.stoppingCriteriaCmb = new System.Windows.Forms.ComboBox();
            this.selectionMethodGroup = new System.Windows.Forms.GroupBox();
            this.selectionCmb = new System.Windows.Forms.ComboBox();
            this.howToSelectLbl = new System.Windows.Forms.Label();
            this.serversNumberGroup = new System.Windows.Forms.GroupBox();
            this.numberOfServersTxt = new System.Windows.Forms.TextBox();
            this.containerPanel.SuspendLayout();
            this.StoppingNumberGroup.SuspendLayout();
            this.stoppingCriteriaGroup.SuspendLayout();
            this.selectionMethodGroup.SuspendLayout();
            this.serversNumberGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.containerPanel.Controls.Add(this.StoppingNumberGroup);
            this.containerPanel.Controls.Add(this.stoppingCriteriaGroup);
            this.containerPanel.Controls.Add(this.selectionMethodGroup);
            this.containerPanel.Controls.Add(this.serversNumberGroup);
            this.containerPanel.Location = new System.Drawing.Point(10, 10);
            this.containerPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(580, 480);
            this.containerPanel.TabIndex = 1;
            // 
            // StoppingNumberGroup
            // 
            this.StoppingNumberGroup.Controls.Add(this.stoppingNumberTxt);
            this.StoppingNumberGroup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.StoppingNumberGroup.Location = new System.Drawing.Point(129, 363);
            this.StoppingNumberGroup.Name = "StoppingNumberGroup";
            this.StoppingNumberGroup.Size = new System.Drawing.Size(359, 70);
            this.StoppingNumberGroup.TabIndex = 10;
            this.StoppingNumberGroup.TabStop = false;
            this.StoppingNumberGroup.Text = "Stopping Number";
            // 
            // stoppingNumberTxt
            // 
            this.stoppingNumberTxt.Location = new System.Drawing.Point(81, 29);
            this.stoppingNumberTxt.Name = "stoppingNumberTxt";
            this.stoppingNumberTxt.Size = new System.Drawing.Size(198, 30);
            this.stoppingNumberTxt.TabIndex = 7;
            this.stoppingNumberTxt.Text = "2";
            this.stoppingNumberTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stoppingNumberTxt.TextChanged += new System.EventHandler(this.stoppingNumberTxt_TextChanged);
            this.stoppingNumberTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOfServersTxt_KeyPress);
            // 
            // stoppingCriteriaGroup
            // 
            this.stoppingCriteriaGroup.Controls.Add(this.stoppingCriteriaCmb);
            this.stoppingCriteriaGroup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.stoppingCriteriaGroup.Location = new System.Drawing.Point(129, 263);
            this.stoppingCriteriaGroup.Name = "stoppingCriteriaGroup";
            this.stoppingCriteriaGroup.Size = new System.Drawing.Size(359, 70);
            this.stoppingCriteriaGroup.TabIndex = 10;
            this.stoppingCriteriaGroup.TabStop = false;
            this.stoppingCriteriaGroup.Text = "Stopping Criteria";
            // 
            // stoppingCriteriaCmb
            // 
            this.stoppingCriteriaCmb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stoppingCriteriaCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stoppingCriteriaCmb.FormattingEnabled = true;
            this.stoppingCriteriaCmb.Items.AddRange(new object[] {
            "Number of Customers",
            "Simulation End Time"});
            this.stoppingCriteriaCmb.Location = new System.Drawing.Point(81, 29);
            this.stoppingCriteriaCmb.Name = "stoppingCriteriaCmb";
            this.stoppingCriteriaCmb.Size = new System.Drawing.Size(198, 31);
            this.stoppingCriteriaCmb.TabIndex = 9;
            this.stoppingCriteriaCmb.SelectedIndexChanged += new System.EventHandler(this.stoppingCriteriaCmb_SelectedIndexChanged);
            // 
            // selectionMethodGroup
            // 
            this.selectionMethodGroup.Controls.Add(this.selectionCmb);
            this.selectionMethodGroup.Controls.Add(this.howToSelectLbl);
            this.selectionMethodGroup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.selectionMethodGroup.Location = new System.Drawing.Point(129, 145);
            this.selectionMethodGroup.Name = "selectionMethodGroup";
            this.selectionMethodGroup.Size = new System.Drawing.Size(359, 88);
            this.selectionMethodGroup.TabIndex = 10;
            this.selectionMethodGroup.TabStop = false;
            this.selectionMethodGroup.Text = "Selection Method";
            // 
            // selectionCmb
            // 
            this.selectionCmb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectionCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectionCmb.FormattingEnabled = true;
            this.selectionCmb.Items.AddRange(new object[] {
            "Highest Priority",
            "Random",
            "Least Utilization"});
            this.selectionCmb.Location = new System.Drawing.Point(81, 45);
            this.selectionCmb.Name = "selectionCmb";
            this.selectionCmb.Size = new System.Drawing.Size(198, 31);
            this.selectionCmb.TabIndex = 8;
            this.selectionCmb.SelectedIndexChanged += new System.EventHandler(this.selectionCmb_SelectedIndexChanged);
            // 
            // howToSelectLbl
            // 
            this.howToSelectLbl.AutoSize = true;
            this.howToSelectLbl.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToSelectLbl.ForeColor = System.Drawing.Color.Crimson;
            this.howToSelectLbl.Location = new System.Drawing.Point(6, 22);
            this.howToSelectLbl.Name = "howToSelectLbl";
            this.howToSelectLbl.Size = new System.Drawing.Size(351, 16);
            this.howToSelectLbl.TabIndex = 5;
            this.howToSelectLbl.Text = "(How to select a server when more than one server is available)";
            // 
            // serversNumberGroup
            // 
            this.serversNumberGroup.Controls.Add(this.numberOfServersTxt);
            this.serversNumberGroup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.serversNumberGroup.Location = new System.Drawing.Point(129, 45);
            this.serversNumberGroup.Name = "serversNumberGroup";
            this.serversNumberGroup.Size = new System.Drawing.Size(359, 70);
            this.serversNumberGroup.TabIndex = 9;
            this.serversNumberGroup.TabStop = false;
            this.serversNumberGroup.Text = "Number of Servers";
            // 
            // numberOfServersTxt
            // 
            this.numberOfServersTxt.Location = new System.Drawing.Point(81, 29);
            this.numberOfServersTxt.Name = "numberOfServersTxt";
            this.numberOfServersTxt.Size = new System.Drawing.Size(198, 30);
            this.numberOfServersTxt.TabIndex = 7;
            this.numberOfServersTxt.Text = "1";
            this.numberOfServersTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numberOfServersTxt.TextChanged += new System.EventHandler(this.numberOfServersTxt_TextChanged);
            this.numberOfServersTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOfServersTxt_KeyPress);
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
            this.StoppingNumberGroup.ResumeLayout(false);
            this.StoppingNumberGroup.PerformLayout();
            this.stoppingCriteriaGroup.ResumeLayout(false);
            this.selectionMethodGroup.ResumeLayout(false);
            this.selectionMethodGroup.PerformLayout();
            this.serversNumberGroup.ResumeLayout(false);
            this.serversNumberGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.GroupBox serversNumberGroup;
        private System.Windows.Forms.TextBox numberOfServersTxt;
        private System.Windows.Forms.GroupBox selectionMethodGroup;
        private System.Windows.Forms.Label howToSelectLbl;
        private System.Windows.Forms.GroupBox StoppingNumberGroup;
        private System.Windows.Forms.TextBox stoppingNumberTxt;
        private System.Windows.Forms.GroupBox stoppingCriteriaGroup;
        private System.Windows.Forms.ComboBox selectionCmb;
        private System.Windows.Forms.ComboBox stoppingCriteriaCmb;
    }
}
