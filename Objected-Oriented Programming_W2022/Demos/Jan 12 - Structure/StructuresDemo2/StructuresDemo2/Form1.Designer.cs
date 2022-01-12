
namespace StructuresDemo2
{
    partial class Form1
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
            this.btnGetByOrdinal = new System.Windows.Forms.Button();
            this.btnQueryLastName = new System.Windows.Forms.Button();
            this.numOrdinal = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLastNameQuery = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.numOrdinal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetByOrdinal
            // 
            this.btnGetByOrdinal.Location = new System.Drawing.Point(430, 82);
            this.btnGetByOrdinal.Name = "btnGetByOrdinal";
            this.btnGetByOrdinal.Size = new System.Drawing.Size(134, 36);
            this.btnGetByOrdinal.TabIndex = 48;
            this.btnGetByOrdinal.Text = "Get by Ordinal";
            this.btnGetByOrdinal.UseVisualStyleBackColor = true;
            // 
            // btnQueryLastName
            // 
            this.btnQueryLastName.Location = new System.Drawing.Point(297, 82);
            this.btnQueryLastName.Name = "btnQueryLastName";
            this.btnQueryLastName.Size = new System.Drawing.Size(115, 36);
            this.btnQueryLastName.TabIndex = 47;
            this.btnQueryLastName.Text = "Search Last Name";
            this.btnQueryLastName.UseVisualStyleBackColor = true;
            // 
            // numOrdinal
            // 
            this.numOrdinal.Location = new System.Drawing.Point(430, 51);
            this.numOrdinal.Name = "numOrdinal";
            this.numOrdinal.Size = new System.Drawing.Size(134, 20);
            this.numOrdinal.TabIndex = 46;
            this.numOrdinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Get Employee By Ordinal:";
            // 
            // txtLastNameQuery
            // 
            this.txtLastNameQuery.Location = new System.Drawing.Point(430, 22);
            this.txtLastNameQuery.Name = "txtLastNameQuery";
            this.txtLastNameQuery.Size = new System.Drawing.Size(134, 20);
            this.txtLastNameQuery.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Query by Last Name:";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(107, 136);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(134, 20);
            this.txtSalary.TabIndex = 42;
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(107, 98);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(134, 20);
            this.txtExtension.TabIndex = 41;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(107, 62);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(134, 20);
            this.txtLastName.TabIndex = 40;
            // 
            // txtGivenName
            // 
            this.txtGivenName.Location = new System.Drawing.Point(107, 26);
            this.txtGivenName.Name = "txtGivenName";
            this.txtGivenName.Size = new System.Drawing.Size(134, 20);
            this.txtGivenName.TabIndex = 39;
            // 
            // btnShowEmployees
            // 
            this.btnShowEmployees.Location = new System.Drawing.Point(137, 184);
            this.btnShowEmployees.Name = "btnShowEmployees";
            this.btnShowEmployees.Size = new System.Drawing.Size(123, 36);
            this.btnShowEmployees.TabIndex = 44;
            this.btnShowEmployees.Text = "Display Employees";
            this.btnShowEmployees.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 184);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 36);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Save Employee";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Salary:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Extension:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Given Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 243);
            this.Controls.Add(this.btnGetByOrdinal);
            this.Controls.Add(this.btnQueryLastName);
            this.Controls.Add(this.numOrdinal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLastNameQuery);
            this.Controls.Add(this.label5);
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
            this.Name = "Form1";
            this.Text = "Structures and Generic Lists Demo";
            ((System.ComponentModel.ISupportInitialize)(this.numOrdinal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetByOrdinal;
        private System.Windows.Forms.Button btnQueryLastName;
        private System.Windows.Forms.NumericUpDown numOrdinal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLastNameQuery;
        private System.Windows.Forms.Label label5;
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

