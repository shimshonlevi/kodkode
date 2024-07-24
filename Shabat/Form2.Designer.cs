namespace host
{
    partial class Form2
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
            this.lblCatagory = new System.Windows.Forms.Label();
            this.dgvOrtherList = new System.Windows.Forms.DataGridView();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrtherList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCatagory
            // 
            this.lblCatagory.AutoSize = true;
            this.lblCatagory.Location = new System.Drawing.Point(341, 65);
            this.lblCatagory.Name = "lblCatagory";
            this.lblCatagory.Size = new System.Drawing.Size(63, 20);
            this.lblCatagory.TabIndex = 0;
            this.lblCatagory.Text = "קטגוריה";
            // 
            // dgvOrtherList
            // 
            this.dgvOrtherList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrtherList.Location = new System.Drawing.Point(73, 129);
            this.dgvOrtherList.Name = "dgvOrtherList";
            this.dgvOrtherList.RowHeadersWidth = 62;
            this.dgvOrtherList.RowTemplate.Height = 28;
            this.dgvOrtherList.Size = new System.Drawing.Size(654, 235);
            this.dgvOrtherList.TabIndex = 1;
            this.dgvOrtherList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrtherList_CellContentClick);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(85, 415);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 2;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(652, 415);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.dgvOrtherList);
            this.Controls.Add(this.lblCatagory);
            this.Name = "Form2";
            this.Text = "form2Host";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrtherList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCatagory;
        private System.Windows.Forms.DataGridView dgvOrtherList;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnNext;
    }
}