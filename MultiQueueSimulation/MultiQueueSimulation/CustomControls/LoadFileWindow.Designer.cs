
namespace MultiQueueSimulation
{
    partial class LoadFileWindow
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loadFromFileBtn = new System.Windows.Forms.Button();
            this.containerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.containerPanel.Controls.Add(this.label3);
            this.containerPanel.Controls.Add(this.label2);
            this.containerPanel.Controls.Add(this.label1);
            this.containerPanel.Controls.Add(this.loadFromFileBtn);
            this.containerPanel.Location = new System.Drawing.Point(14, 15);
            this.containerPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(472, 372);
            this.containerPanel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(24, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(428, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "You can skip this window if you want to put manual inputs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(219, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "OR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(32, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "You can load an input file by clicking the button bellow";
            // 
            // loadFromFileBtn
            // 
            this.loadFromFileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(189)))), ((int)(((byte)(151)))));
            this.loadFromFileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadFromFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadFromFileBtn.ForeColor = System.Drawing.Color.White;
            this.loadFromFileBtn.Location = new System.Drawing.Point(146, 295);
            this.loadFromFileBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loadFromFileBtn.Name = "loadFromFileBtn";
            this.loadFromFileBtn.Size = new System.Drawing.Size(182, 54);
            this.loadFromFileBtn.TabIndex = 0;
            this.loadFromFileBtn.Text = "Load From File";
            this.loadFromFileBtn.UseVisualStyleBackColor = false;
            this.loadFromFileBtn.Click += new System.EventHandler(this.loadFromFileBtn_Click);
            // 
            // LoadFileWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.containerPanel);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoadFileWindow";
            this.Size = new System.Drawing.Size(500, 400);
            this.containerPanel.ResumeLayout(false);
            this.containerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Button loadFromFileBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
