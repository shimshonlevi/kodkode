namespace Time_clok
{
    partial class Change_password
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.boxoldPassword = new System.Windows.Forms.TextBox();
            this.boxokPassword = new System.Windows.Forms.TextBox();
            this.boxnewPassword = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.boxId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(603, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "סיסמא ישנה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 290);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "אישור סיסמא חדשה";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(595, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "סיסמא חדשה";
            // 
            // boxoldPassword
            // 
            this.boxoldPassword.Location = new System.Drawing.Point(305, 151);
            this.boxoldPassword.Name = "boxoldPassword";
            this.boxoldPassword.Size = new System.Drawing.Size(199, 30);
            this.boxoldPassword.TabIndex = 1;
            this.boxoldPassword.TextChanged += new System.EventHandler(this.boxold_TextChanged);
            // 
            // boxokPassword
            // 
            this.boxokPassword.Location = new System.Drawing.Point(305, 290);
            this.boxokPassword.Name = "boxokPassword";
            this.boxokPassword.Size = new System.Drawing.Size(199, 30);
            this.boxokPassword.TabIndex = 3;
            // 
            // boxnewPassword
            // 
            this.boxnewPassword.Location = new System.Drawing.Point(305, 214);
            this.boxnewPassword.Name = "boxnewPassword";
            this.boxnewPassword.Size = new System.Drawing.Size(199, 30);
            this.boxnewPassword.TabIndex = 2;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(375, 393);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 51);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "אישור";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(603, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "תעודת זהות\r\n";
            // 
            // boxId
            // 
            this.boxId.Location = new System.Drawing.Point(305, 93);
            this.boxId.Name = "boxId";
            this.boxId.Size = new System.Drawing.Size(199, 30);
            this.boxId.TabIndex = 0;
            this.boxId.TextChanged += new System.EventHandler(this.boxId_TextChanged);
            // 
            // Change_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.boxId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.boxnewPassword);
            this.Controls.Add(this.boxokPassword);
            this.Controls.Add(this.boxoldPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Change_password";
            this.Text = "Change_password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boxoldPassword;
        private System.Windows.Forms.TextBox boxokPassword;
        private System.Windows.Forms.TextBox boxnewPassword;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxId;
    }
}