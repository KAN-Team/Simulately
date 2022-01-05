
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
            this.EndingInventoryAverageLbl = new System.Windows.Forms.Label();
            this.EndingInventoryAverageAnsLbl = new System.Windows.Forms.Label();
            this.ShortageQuantityAverageAnsLbl = new System.Windows.Forms.Label();
            this.ShortageQuantityAverageLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EndingInventoryAverageLbl
            // 
            this.EndingInventoryAverageLbl.AutoSize = true;
            this.EndingInventoryAverageLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.EndingInventoryAverageLbl.Location = new System.Drawing.Point(14, 33);
            this.EndingInventoryAverageLbl.Name = "EndingInventoryAverageLbl";
            this.EndingInventoryAverageLbl.Size = new System.Drawing.Size(186, 19);
            this.EndingInventoryAverageLbl.TabIndex = 0;
            this.EndingInventoryAverageLbl.Text = "Ending Inventory Average =";
            // 
            // EndingInventoryAverageAnsLbl
            // 
            this.EndingInventoryAverageAnsLbl.AutoSize = true;
            this.EndingInventoryAverageAnsLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EndingInventoryAverageAnsLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EndingInventoryAverageAnsLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndingInventoryAverageAnsLbl.ForeColor = System.Drawing.Color.Crimson;
            this.EndingInventoryAverageAnsLbl.Location = new System.Drawing.Point(254, 33);
            this.EndingInventoryAverageAnsLbl.Name = "EndingInventoryAverageAnsLbl";
            this.EndingInventoryAverageAnsLbl.Size = new System.Drawing.Size(60, 25);
            this.EndingInventoryAverageAnsLbl.TabIndex = 2;
            this.EndingInventoryAverageAnsLbl.Text = "Ans_1";
            // 
            // ShortageQuantityAverageAnsLbl
            // 
            this.ShortageQuantityAverageAnsLbl.AutoSize = true;
            this.ShortageQuantityAverageAnsLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ShortageQuantityAverageAnsLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShortageQuantityAverageAnsLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShortageQuantityAverageAnsLbl.ForeColor = System.Drawing.Color.Crimson;
            this.ShortageQuantityAverageAnsLbl.Location = new System.Drawing.Point(254, 78);
            this.ShortageQuantityAverageAnsLbl.Name = "ShortageQuantityAverageAnsLbl";
            this.ShortageQuantityAverageAnsLbl.Size = new System.Drawing.Size(60, 25);
            this.ShortageQuantityAverageAnsLbl.TabIndex = 4;
            this.ShortageQuantityAverageAnsLbl.Text = "Ans_2";
            // 
            // ShortageQuantityAverageLbl
            // 
            this.ShortageQuantityAverageLbl.AutoSize = true;
            this.ShortageQuantityAverageLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ShortageQuantityAverageLbl.Location = new System.Drawing.Point(14, 79);
            this.ShortageQuantityAverageLbl.Name = "ShortageQuantityAverageLbl";
            this.ShortageQuantityAverageLbl.Size = new System.Drawing.Size(197, 19);
            this.ShortageQuantityAverageLbl.TabIndex = 3;
            this.ShortageQuantityAverageLbl.Text = "Shortage Quantity Average =";
            // 
            // PerformanceMesuresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(360, 133);
            this.Controls.Add(this.ShortageQuantityAverageAnsLbl);
            this.Controls.Add(this.ShortageQuantityAverageLbl);
            this.Controls.Add(this.EndingInventoryAverageAnsLbl);
            this.Controls.Add(this.EndingInventoryAverageLbl);
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
        private System.Windows.Forms.Label EndingInventoryAverageLbl;
        private System.Windows.Forms.Label EndingInventoryAverageAnsLbl;
        private System.Windows.Forms.Label ShortageQuantityAverageAnsLbl;
        private System.Windows.Forms.Label ShortageQuantityAverageLbl;
    }
}