
namespace StructuresDemo
{
    partial class frmStructuresDemo
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
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtGivenName = new System.Windows.Forms.TextBox();
            this.btnShowEmployees = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(153, 171);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(177, 22);
            this.txtSalary.TabIndex = 19;
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(153, 124);
            this.txtExtension.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(177, 22);
            this.txtExtension.TabIndex = 18;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(153, 80);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(177, 22);
            this.txtLastName.TabIndex = 17;
            // 
            // txtGivenName
            // 
            this.txtGivenName.Location = new System.Drawing.Point(153, 36);
            this.txtGivenName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGivenName.Name = "txtGivenName";
            this.txtGivenName.Size = new System.Drawing.Size(177, 22);
            this.txtGivenName.TabIndex = 16;
            // 
            // btnShowEmployees
            // 
            this.btnShowEmployees.Location = new System.Drawing.Point(193, 230);
            this.btnShowEmployees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowEmployees.Name = "btnShowEmployees";
            this.btnShowEmployees.Size = new System.Drawing.Size(164, 44);
            this.btnShowEmployees.TabIndex = 15;
            this.btnShowEmployees.Text = "Display All Employees";
            this.btnShowEmployees.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(31, 230);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(155, 44);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Add Employee";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Salary:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Extension:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Given Name:";
            // 
            // frmStructuresDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 310);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtExtension);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtGivenName);
            this.Controls.Add(this.btnShowEmployees);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmStructuresDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Structures Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtGivenName;
        private System.Windows.Forms.Button btnShowEmployees;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

