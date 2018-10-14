namespace MathProject
{
    partial class frmMathProject
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
            this.txtResponse1 = new System.Windows.Forms.TextBox();
            this.btnAlgorithm1 = new System.Windows.Forms.Button();
            this.lblAlgorithm1Result = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtA2Response2 = new System.Windows.Forms.TextBox();
            this.txtA2Response1 = new System.Windows.Forms.TextBox();
            this.btnAlgorithm2 = new System.Windows.Forms.Button();
            this.lblAlgorithm2Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number: ";
            // 
            // txtResponse1
            // 
            this.txtResponse1.Location = new System.Drawing.Point(68, 21);
            this.txtResponse1.Name = "txtResponse1";
            this.txtResponse1.Size = new System.Drawing.Size(100, 20);
            this.txtResponse1.TabIndex = 0;
            // 
            // btnAlgorithm1
            // 
            this.btnAlgorithm1.Location = new System.Drawing.Point(68, 68);
            this.btnAlgorithm1.Name = "btnAlgorithm1";
            this.btnAlgorithm1.Size = new System.Drawing.Size(75, 23);
            this.btnAlgorithm1.TabIndex = 1;
            this.btnAlgorithm1.Text = "Algorithm 1";
            this.btnAlgorithm1.UseVisualStyleBackColor = true;
            this.btnAlgorithm1.Click += new System.EventHandler(this.btnAlgorithm1_Click);
            // 
            // lblAlgorithm1Result
            // 
            this.lblAlgorithm1Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAlgorithm1Result.Location = new System.Drawing.Point(189, 21);
            this.lblAlgorithm1Result.Name = "lblAlgorithm1Result";
            this.lblAlgorithm1Result.Size = new System.Drawing.Size(209, 80);
            this.lblAlgorithm1Result.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Second Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "First Number:";
            // 
            // txtA2Response2
            // 
            this.txtA2Response2.Location = new System.Drawing.Point(298, 172);
            this.txtA2Response2.Name = "txtA2Response2";
            this.txtA2Response2.Size = new System.Drawing.Size(100, 20);
            this.txtA2Response2.TabIndex = 3;
            // 
            // txtA2Response1
            // 
            this.txtA2Response1.Location = new System.Drawing.Point(87, 172);
            this.txtA2Response1.Name = "txtA2Response1";
            this.txtA2Response1.Size = new System.Drawing.Size(100, 20);
            this.txtA2Response1.TabIndex = 2;
            // 
            // btnAlgorithm2
            // 
            this.btnAlgorithm2.Location = new System.Drawing.Point(87, 235);
            this.btnAlgorithm2.Name = "btnAlgorithm2";
            this.btnAlgorithm2.Size = new System.Drawing.Size(75, 23);
            this.btnAlgorithm2.TabIndex = 4;
            this.btnAlgorithm2.Text = "Algorithm 2";
            this.btnAlgorithm2.UseVisualStyleBackColor = true;
            this.btnAlgorithm2.Click += new System.EventHandler(this.btnAlgorithm2_Click);
            // 
            // lblAlgorithm2Result
            // 
            this.lblAlgorithm2Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAlgorithm2Result.Location = new System.Drawing.Point(189, 239);
            this.lblAlgorithm2Result.Name = "lblAlgorithm2Result";
            this.lblAlgorithm2Result.Size = new System.Drawing.Size(209, 90);
            this.lblAlgorithm2Result.TabIndex = 9;
            // 
            // frmMathProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 355);
            this.Controls.Add(this.lblAlgorithm2Result);
            this.Controls.Add(this.btnAlgorithm2);
            this.Controls.Add(this.txtA2Response1);
            this.Controls.Add(this.txtA2Response2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAlgorithm1Result);
            this.Controls.Add(this.btnAlgorithm1);
            this.Controls.Add(this.txtResponse1);
            this.Controls.Add(this.label1);
            this.Name = "frmMathProject";
            this.Text = "Family Feud";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResponse1;
        private System.Windows.Forms.Button btnAlgorithm1;
        private System.Windows.Forms.Label lblAlgorithm1Result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtA2Response2;
        private System.Windows.Forms.TextBox txtA2Response1;
        private System.Windows.Forms.Button btnAlgorithm2;
        private System.Windows.Forms.Label lblAlgorithm2Result;
    }
}

