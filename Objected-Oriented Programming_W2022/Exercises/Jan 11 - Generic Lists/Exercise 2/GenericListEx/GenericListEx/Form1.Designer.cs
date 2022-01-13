
namespace GenericListEx
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSecondPos = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnShowMsg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(34, 196);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(193, 23);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "Remove Second Position";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(179, 136);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(193, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add to Second Position";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtSecondPos
            // 
            this.txtSecondPos.Location = new System.Drawing.Point(34, 138);
            this.txtSecondPos.Name = "txtSecondPos";
            this.txtSecondPos.Size = new System.Drawing.Size(139, 20);
            this.txtSecondPos.TabIndex = 15;
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Location = new System.Drawing.Point(31, 88);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(385, 23);
            this.lblMessage.TabIndex = 14;
            // 
            // btnReverse
            // 
            this.btnReverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReverse.Location = new System.Drawing.Point(228, 29);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(188, 30);
            this.btnReverse.TabIndex = 13;
            this.btnReverse.Text = "Display Message In Reverse";
            this.btnReverse.UseVisualStyleBackColor = true;
            // 
            // btnShowMsg
            // 
            this.btnShowMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowMsg.Location = new System.Drawing.Point(34, 29);
            this.btnShowMsg.Name = "btnShowMsg";
            this.btnShowMsg.Size = new System.Drawing.Size(188, 30);
            this.btnShowMsg.TabIndex = 12;
            this.btnShowMsg.Text = "Display Message Forward";
            this.btnShowMsg.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 249);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSecondPos);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnShowMsg);
            this.Name = "Form1";
            this.Text = "Generic List Exercise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSecondPos;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnShowMsg;
    }
}

