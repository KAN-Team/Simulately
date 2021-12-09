
namespace InventorySimulation.Forms
{
    partial class PerformanceMesuresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerformanceMesuresForm));
            this.nameYourLbl = new System.Windows.Forms.Label();
            this.ans_1 = new System.Windows.Forms.Label();
            this.totalCostAnsLbl = new System.Windows.Forms.Label();
            this.totalCostLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameYourLbl
            // 
            this.nameYourLbl.AutoSize = true;
            this.nameYourLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nameYourLbl.Location = new System.Drawing.Point(14, 33);
            this.nameYourLbl.Name = "nameYourLbl";
            this.nameYourLbl.Size = new System.Drawing.Size(148, 19);
            this.nameYourLbl.TabIndex = 0;
            this.nameYourLbl.Text = "Name Your Mesure = ";
            // 
            // ans_1
            // 
            this.ans_1.AutoSize = true;
            this.ans_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ans_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ans_1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ans_1.ForeColor = System.Drawing.Color.Crimson;
            this.ans_1.Location = new System.Drawing.Point(207, 33);
            this.ans_1.Name = "ans_1";
            this.ans_1.Size = new System.Drawing.Size(60, 25);
            this.ans_1.TabIndex = 2;
            this.ans_1.Text = "Ans_1";
            // 
            // totalCostAnsLbl
            // 
            this.totalCostAnsLbl.AutoSize = true;
            this.totalCostAnsLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalCostAnsLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalCostAnsLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostAnsLbl.ForeColor = System.Drawing.Color.Crimson;
            this.totalCostAnsLbl.Location = new System.Drawing.Point(207, 78);
            this.totalCostAnsLbl.Name = "totalCostAnsLbl";
            this.totalCostAnsLbl.Size = new System.Drawing.Size(60, 25);
            this.totalCostAnsLbl.TabIndex = 4;
            this.totalCostAnsLbl.Text = "Ans_2";
            // 
            // totalCostLbl
            // 
            this.totalCostLbl.AutoSize = true;
            this.totalCostLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.totalCostLbl.Location = new System.Drawing.Point(14, 79);
            this.totalCostLbl.Name = "totalCostLbl";
            this.totalCostLbl.Size = new System.Drawing.Size(87, 19);
            this.totalCostLbl.TabIndex = 3;
            this.totalCostLbl.Text = "Mesure 2 = ";
            // 
            // PerformanceMesuresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(302, 143);
            this.Controls.Add(this.totalCostAnsLbl);
            this.Controls.Add(this.totalCostLbl);
            this.Controls.Add(this.ans_1);
            this.Controls.Add(this.nameYourLbl);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PerformanceMesuresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Performance Mesures";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameYourLbl;
        private System.Windows.Forms.Label ans_1;
        private System.Windows.Forms.Label totalCostAnsLbl;
        private System.Windows.Forms.Label totalCostLbl;
    }
}