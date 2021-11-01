
namespace MultiQueueSimulation.Forms
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
            this.performanceMesuresPic = new System.Windows.Forms.PictureBox();
            this.maxQueueLbl = new System.Windows.Forms.Label();
            this.averageWaitingTimeAnsLbl = new System.Windows.Forms.Label();
            this.probabilityWaitAnsLbl = new System.Windows.Forms.Label();
            this.maxQueueLengthAnsLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.performanceMesuresPic)).BeginInit();
            this.SuspendLayout();
            // 
            // performanceMesuresPic
            // 
            this.performanceMesuresPic.Image = ((System.Drawing.Image)(resources.GetObject("performanceMesuresPic.Image")));
            this.performanceMesuresPic.Location = new System.Drawing.Point(2, 20);
            this.performanceMesuresPic.Name = "performanceMesuresPic";
            this.performanceMesuresPic.Size = new System.Drawing.Size(469, 169);
            this.performanceMesuresPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.performanceMesuresPic.TabIndex = 1;
            this.performanceMesuresPic.TabStop = false;
            // 
            // maxQueueLbl
            // 
            this.maxQueueLbl.AutoSize = true;
            this.maxQueueLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.maxQueueLbl.Location = new System.Drawing.Point(133, 203);
            this.maxQueueLbl.Name = "maxQueueLbl";
            this.maxQueueLbl.Size = new System.Drawing.Size(338, 19);
            this.maxQueueLbl.TabIndex = 0;
            this.maxQueueLbl.Text = "Maximum queue length during simulation runtime = ";
            // 
            // averageWaitingTimeAnsLbl
            // 
            this.averageWaitingTimeAnsLbl.AutoSize = true;
            this.averageWaitingTimeAnsLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.averageWaitingTimeAnsLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.averageWaitingTimeAnsLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageWaitingTimeAnsLbl.ForeColor = System.Drawing.Color.Crimson;
            this.averageWaitingTimeAnsLbl.Location = new System.Drawing.Point(477, 63);
            this.averageWaitingTimeAnsLbl.Name = "averageWaitingTimeAnsLbl";
            this.averageWaitingTimeAnsLbl.Size = new System.Drawing.Size(60, 25);
            this.averageWaitingTimeAnsLbl.TabIndex = 2;
            this.averageWaitingTimeAnsLbl.Text = "Ans_1";
            // 
            // probabilityWaitAnsLbl
            // 
            this.probabilityWaitAnsLbl.AutoSize = true;
            this.probabilityWaitAnsLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.probabilityWaitAnsLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.probabilityWaitAnsLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.probabilityWaitAnsLbl.ForeColor = System.Drawing.Color.Crimson;
            this.probabilityWaitAnsLbl.Location = new System.Drawing.Point(477, 128);
            this.probabilityWaitAnsLbl.Name = "probabilityWaitAnsLbl";
            this.probabilityWaitAnsLbl.Size = new System.Drawing.Size(60, 25);
            this.probabilityWaitAnsLbl.TabIndex = 3;
            this.probabilityWaitAnsLbl.Text = "Ans_2";
            // 
            // maxQueueLengthAnsLbl
            // 
            this.maxQueueLengthAnsLbl.AutoSize = true;
            this.maxQueueLengthAnsLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.maxQueueLengthAnsLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxQueueLengthAnsLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxQueueLengthAnsLbl.ForeColor = System.Drawing.Color.Crimson;
            this.maxQueueLengthAnsLbl.Location = new System.Drawing.Point(477, 199);
            this.maxQueueLengthAnsLbl.Name = "maxQueueLengthAnsLbl";
            this.maxQueueLengthAnsLbl.Size = new System.Drawing.Size(60, 25);
            this.maxQueueLengthAnsLbl.TabIndex = 4;
            this.maxQueueLengthAnsLbl.Text = "Ans_3";
            // 
            // PerformanceMesuresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.maxQueueLengthAnsLbl);
            this.Controls.Add(this.probabilityWaitAnsLbl);
            this.Controls.Add(this.averageWaitingTimeAnsLbl);
            this.Controls.Add(this.performanceMesuresPic);
            this.Controls.Add(this.maxQueueLbl);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PerformanceMesuresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Performance Mesures";
            ((System.ComponentModel.ISupportInitialize)(this.performanceMesuresPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox performanceMesuresPic;
        private System.Windows.Forms.Label maxQueueLbl;
        private System.Windows.Forms.Label averageWaitingTimeAnsLbl;
        private System.Windows.Forms.Label probabilityWaitAnsLbl;
        private System.Windows.Forms.Label maxQueueLengthAnsLbl;
    }
}