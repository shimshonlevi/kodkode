namespace lerning
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
            this.operators = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.lblfood = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblweight = new System.Windows.Forms.Label();
            this.boxrename = new System.Windows.Forms.TextBox();
            this.btnrun = new System.Windows.Forms.Button();
            this.btnage = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.boxage = new System.Windows.Forms.TextBox();
            this.btnname = new System.Windows.Forms.Button();
            this.boxarr = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // operators
            // 
            this.operators.Location = new System.Drawing.Point(159, 12);
            this.operators.Name = "operators";
            this.operators.Size = new System.Drawing.Size(185, 65);
            this.operators.TabIndex = 0;
            this.operators.Text = "אופרטורים";
            this.operators.UseVisualStyleBackColor = true;
            this.operators.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(-1, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 152);
            this.button1.TabIndex = 1;
            this.button1.Text = "cllas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(328, 84);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(49, 20);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "name";
            // 
            // lblfood
            // 
            this.lblfood.AutoSize = true;
            this.lblfood.Location = new System.Drawing.Point(274, 133);
            this.lblfood.Name = "lblfood";
            this.lblfood.Size = new System.Drawing.Size(41, 20);
            this.lblfood.TabIndex = 3;
            this.lblfood.Text = "food";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(230, 133);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(56, 20);
            this.lblHeight.TabIndex = 4;
            this.lblHeight.Text = "Height";
            // 
            // lblweight
            // 
            this.lblweight.AutoSize = true;
            this.lblweight.Location = new System.Drawing.Point(169, 133);
            this.lblweight.Name = "lblweight";
            this.lblweight.Size = new System.Drawing.Size(55, 20);
            this.lblweight.TabIndex = 5;
            this.lblweight.Text = "weight";
            // 
            // boxrename
            // 
            this.boxrename.Location = new System.Drawing.Point(40, 304);
            this.boxrename.Name = "boxrename";
            this.boxrename.Size = new System.Drawing.Size(275, 26);
            this.boxrename.TabIndex = 6;
            // 
            // btnrun
            // 
            this.btnrun.Location = new System.Drawing.Point(321, 130);
            this.btnrun.Name = "btnrun";
            this.btnrun.Size = new System.Drawing.Size(75, 23);
            this.btnrun.TabIndex = 7;
            this.btnrun.Text = "Run";
            this.btnrun.UseVisualStyleBackColor = true;
            this.btnrun.Click += new System.EventHandler(this.btnrun_Click);
            // 
            // btnage
            // 
            this.btnage.Location = new System.Drawing.Point(531, 336);
            this.btnage.Name = "btnage";
            this.btnage.Size = new System.Drawing.Size(121, 102);
            this.btnage.TabIndex = 8;
            this.btnage.Text = "age";
            this.btnage.UseVisualStyleBackColor = true;
            this.btnage.Click += new System.EventHandler(this.btnage_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(159, 71);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 59);
            this.button4.TabIndex = 9;
            this.button4.Text = "הוספת כלב";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(321, 107);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // boxage
            // 
            this.boxage.Location = new System.Drawing.Point(464, 304);
            this.boxage.Name = "boxage";
            this.boxage.Size = new System.Drawing.Size(257, 26);
            this.boxage.TabIndex = 11;
            // 
            // btnname
            // 
            this.btnname.Location = new System.Drawing.Point(99, 336);
            this.btnname.Name = "btnname";
            this.btnname.Size = new System.Drawing.Size(150, 102);
            this.btnname.TabIndex = 12;
            this.btnname.Text = "name";
            this.btnname.UseVisualStyleBackColor = true;
            this.btnname.Click += new System.EventHandler(this.btnname_Click);
            // 
            // boxarr
            // 
            this.boxarr.Location = new System.Drawing.Point(418, 241);
            this.boxarr.Name = "boxarr";
            this.boxarr.Size = new System.Drawing.Size(100, 26);
            this.boxarr.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(576, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.boxarr);
            this.Controls.Add(this.btnname);
            this.Controls.Add(this.boxage);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnage);
            this.Controls.Add(this.btnrun);
            this.Controls.Add(this.boxrename);
            this.Controls.Add(this.lblweight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblfood);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.operators);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button operators;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblfood;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblweight;
        private System.Windows.Forms.TextBox boxrename;
        private System.Windows.Forms.Button btnrun;
        private System.Windows.Forms.Button btnage;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox boxage;
        private System.Windows.Forms.Button btnname;
        private System.Windows.Forms.TextBox boxarr;
        private System.Windows.Forms.Button button2;
    }
}

