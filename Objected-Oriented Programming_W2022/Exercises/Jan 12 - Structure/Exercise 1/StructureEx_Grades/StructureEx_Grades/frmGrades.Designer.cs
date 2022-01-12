
namespace StructureEx_Grades
{
    partial class frmGrades
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
            this.btnFindGrade = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFindGrade
            // 
            this.btnFindGrade.Location = new System.Drawing.Point(58, 70);
            this.btnFindGrade.Name = "btnFindGrade";
            this.btnFindGrade.Size = new System.Drawing.Size(75, 23);
            this.btnFindGrade.TabIndex = 10;
            this.btnFindGrade.Text = "&Find Grade";
            this.btnFindGrade.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(23, 40);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(39, 13);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "Grade:";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(90, 37);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(82, 20);
            this.txtGrade.TabIndex = 8;
            // 
            // frmGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 130);
            this.Controls.Add(this.btnFindGrade);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtGrade);
            this.Name = "frmGrades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnFindGrade;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtGrade;
    }
}

