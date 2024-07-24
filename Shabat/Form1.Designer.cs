namespace host
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
            this.tbHost = new System.Windows.Forms.TextBox();
            this.btnDelitHost = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnVieuHost = new System.Windows.Forms.Button();
            this.btnAddHost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "מארח-הכנס קטגוריה";
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(260, 85);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(199, 26);
            this.tbHost.TabIndex = 1;
            this.tbHost.TextChanged += new System.EventHandler(this.tbHost_TextChanged);
            // 
            // btnDelitHost
            // 
            this.btnDelitHost.Location = new System.Drawing.Point(496, 170);
            this.btnDelitHost.Name = "btnDelitHost";
            this.btnDelitHost.Size = new System.Drawing.Size(136, 43);
            this.btnDelitHost.TabIndex = 2;
            this.btnDelitHost.Text = "מחיקה";
            this.btnDelitHost.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(260, 242);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(213, 164);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // btnVieuHost
            // 
            this.btnVieuHost.Location = new System.Drawing.Point(67, 325);
            this.btnVieuHost.Name = "btnVieuHost";
            this.btnVieuHost.Size = new System.Drawing.Size(131, 81);
            this.btnVieuHost.TabIndex = 4;
            this.btnVieuHost.Text = "צפה בהזמנתך";
            this.btnVieuHost.UseVisualStyleBackColor = true;
            this.btnVieuHost.Click += new System.EventHandler(this.btnVieuHost_Click);
            // 
            // btnAddHost
            // 
            this.btnAddHost.Location = new System.Drawing.Point(123, 170);
            this.btnAddHost.Name = "btnAddHost";
            this.btnAddHost.Size = new System.Drawing.Size(116, 33);
            this.btnAddHost.TabIndex = 5;
            this.btnAddHost.Text = "הוספה";
            this.btnAddHost.UseVisualStyleBackColor = true;
            this.btnAddHost.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddHost);
            this.Controls.Add(this.btnVieuHost);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnDelitHost);
            this.Controls.Add(this.tbHost);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "form1Host";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.Button btnDelitHost;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnVieuHost;
        private System.Windows.Forms.Button btnAddHost;
    }
}

