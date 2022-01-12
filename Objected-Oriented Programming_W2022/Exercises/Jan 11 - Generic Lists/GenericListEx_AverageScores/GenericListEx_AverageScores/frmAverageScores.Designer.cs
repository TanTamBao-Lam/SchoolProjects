
namespace GenericListEx_AverageScores
{
    partial class frmAverageScores
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblNumBelow = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNumAbove = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(43, 165);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(335, 48);
            this.btnCalculate.TabIndex = 13;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblNumBelow
            // 
            this.lblNumBelow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumBelow.Location = new System.Drawing.Point(244, 124);
            this.lblNumBelow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumBelow.Name = "lblNumBelow";
            this.lblNumBelow.Size = new System.Drawing.Size(133, 28);
            this.lblNumBelow.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "# scores below average:";
            // 
            // lblNumAbove
            // 
            this.lblNumAbove.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumAbove.Location = new System.Drawing.Point(244, 84);
            this.lblNumAbove.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumAbove.Name = "lblNumAbove";
            this.lblNumAbove.Size = new System.Drawing.Size(133, 28);
            this.lblNumAbove.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "# of scores above average:";
            // 
            // lblAvg
            // 
            this.lblAvg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAvg.Location = new System.Drawing.Point(244, 39);
            this.lblAvg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(133, 28);
            this.lblAvg.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Average Score:";
            // 
            // frmAverageScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 251);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblNumBelow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNumAbove);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAverageScores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generic List Demo - Average Scores";
            this.Load += new System.EventHandler(this.frmAverageScores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblNumBelow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNumAbove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.Label label1;
    }
}

