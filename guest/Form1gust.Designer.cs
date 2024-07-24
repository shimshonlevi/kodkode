namespace guest
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGuestDelite = new System.Windows.Forms.Button();
            this.btnGuestAdd = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "הכנס שם או בחר מהרשימה";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(274, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnGuestDelite
            // 
            this.btnGuestDelite.Location = new System.Drawing.Point(510, 182);
            this.btnGuestDelite.Name = "btnGuestDelite";
            this.btnGuestDelite.Size = new System.Drawing.Size(159, 86);
            this.btnGuestDelite.TabIndex = 2;
            this.btnGuestDelite.Text = "מחיקה";
            this.btnGuestDelite.UseVisualStyleBackColor = true;
            // 
            // btnGuestAdd
            // 
            this.btnGuestAdd.Location = new System.Drawing.Point(89, 182);
            this.btnGuestAdd.Name = "btnGuestAdd";
            this.btnGuestAdd.Size = new System.Drawing.Size(156, 86);
            this.btnGuestAdd.TabIndex = 3;
            this.btnGuestAdd.Text = "הוספה";
            this.btnGuestAdd.UseVisualStyleBackColor = true;
            this.btnGuestAdd.Click += new System.EventHandler(this.btnGuestAdd_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(230, 280);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(285, 124);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnGuestAdd);
            this.Controls.Add(this.btnGuestDelite);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "form1guest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGuestDelite;
        private System.Windows.Forms.Button btnGuestAdd;
        private System.Windows.Forms.ListBox listBox1;
    }
}

