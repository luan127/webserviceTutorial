namespace winform
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
            this.btnSum = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgvStudents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a:";
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(162, 245);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(81, 27);
            this.btnSum.TabIndex = 1;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Location = new System.Drawing.Point(777, 104);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(78, 31);
            this.btnStudent.TabIndex = 2;
            this.btnStudent.Text = "Students";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(121, 156);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(176, 22);
            this.tbA.TabIndex = 3;
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(121, 202);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(176, 22);
            this.tbB.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter b:";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(121, 290);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(176, 22);
            this.tbResult.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Result";
            // 
            // dtgvStudents
            // 
            this.dtgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvStudents.Location = new System.Drawing.Point(502, 214);
            this.dtgvStudents.Name = "dtgvStudents";
            this.dtgvStudents.RowTemplate.Height = 24;
            this.dtgvStudents.Size = new System.Drawing.Size(594, 319);
            this.dtgvStudents.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 592);
            this.Controls.Add(this.dtgvStudents);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgvStudents;
    }
}

