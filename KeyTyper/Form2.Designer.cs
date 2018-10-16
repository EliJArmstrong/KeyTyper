namespace KeyTyper
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
            this.gradientGroup1 = new KeyTyper.GradientGroup();
            this.goodJobLbl = new System.Windows.Forms.Label();
            this.totalNumLbl = new System.Windows.Forms.Label();
            this.numOfCharLbl = new System.Windows.Forms.Label();
            this.errorLbl = new System.Windows.Forms.Label();
            this.numOfErrorLbl = new System.Windows.Forms.Label();
            this.correctLbl = new System.Windows.Forms.Label();
            this.CorrectNumLbl = new System.Windows.Forms.Label();
            this.accuracyLbl = new System.Windows.Forms.Label();
            this.accuracyPercentLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gradientGroup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientGroup1
            // 
            this.gradientGroup1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gradientGroup1.ColorTop = System.Drawing.Color.Cyan;
            this.gradientGroup1.Controls.Add(this.button1);
            this.gradientGroup1.Controls.Add(this.accuracyPercentLbl);
            this.gradientGroup1.Controls.Add(this.accuracyLbl);
            this.gradientGroup1.Controls.Add(this.CorrectNumLbl);
            this.gradientGroup1.Controls.Add(this.correctLbl);
            this.gradientGroup1.Controls.Add(this.numOfErrorLbl);
            this.gradientGroup1.Controls.Add(this.errorLbl);
            this.gradientGroup1.Controls.Add(this.numOfCharLbl);
            this.gradientGroup1.Controls.Add(this.totalNumLbl);
            this.gradientGroup1.Controls.Add(this.goodJobLbl);
            this.gradientGroup1.Location = new System.Drawing.Point(0, -7);
            this.gradientGroup1.Name = "gradientGroup1";
            this.gradientGroup1.Size = new System.Drawing.Size(430, 244);
            this.gradientGroup1.TabIndex = 0;
            this.gradientGroup1.TabStop = false;
            // 
            // goodJobLbl
            // 
            this.goodJobLbl.AutoSize = true;
            this.goodJobLbl.BackColor = System.Drawing.Color.Transparent;
            this.goodJobLbl.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodJobLbl.Location = new System.Drawing.Point(146, 16);
            this.goodJobLbl.Name = "goodJobLbl";
            this.goodJobLbl.Size = new System.Drawing.Size(116, 38);
            this.goodJobLbl.TabIndex = 0;
            this.goodJobLbl.Text = "Good Job!";
            // 
            // totalNumLbl
            // 
            this.totalNumLbl.AutoSize = true;
            this.totalNumLbl.BackColor = System.Drawing.Color.Transparent;
            this.totalNumLbl.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalNumLbl.ForeColor = System.Drawing.Color.Black;
            this.totalNumLbl.Location = new System.Drawing.Point(11, 54);
            this.totalNumLbl.Name = "totalNumLbl";
            this.totalNumLbl.Size = new System.Drawing.Size(414, 30);
            this.totalNumLbl.TabIndex = 1;
            this.totalNumLbl.Text = "Total Number of Characters";
            // 
            // numOfCharLbl
            // 
            this.numOfCharLbl.AutoSize = true;
            this.numOfCharLbl.BackColor = System.Drawing.Color.Transparent;
            this.numOfCharLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfCharLbl.ForeColor = System.Drawing.Color.Black;
            this.numOfCharLbl.Location = new System.Drawing.Point(163, 84);
            this.numOfCharLbl.Name = "numOfCharLbl";
            this.numOfCharLbl.Size = new System.Drawing.Size(92, 31);
            this.numOfCharLbl.TabIndex = 2;
            this.numOfCharLbl.Text = "label3";
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.BackColor = System.Drawing.Color.Transparent;
            this.errorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLbl.ForeColor = System.Drawing.Color.Red;
            this.errorLbl.Location = new System.Drawing.Point(16, 122);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(101, 33);
            this.errorLbl.TabIndex = 3;
            this.errorLbl.Text = "Errors";
            // 
            // numOfErrorLbl
            // 
            this.numOfErrorLbl.AutoSize = true;
            this.numOfErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.numOfErrorLbl.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.numOfErrorLbl.Location = new System.Drawing.Point(23, 162);
            this.numOfErrorLbl.Name = "numOfErrorLbl";
            this.numOfErrorLbl.Size = new System.Drawing.Size(83, 22);
            this.numOfErrorLbl.TabIndex = 4;
            this.numOfErrorLbl.Text = "label5";
            this.numOfErrorLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // correctLbl
            // 
            this.correctLbl.AutoSize = true;
            this.correctLbl.BackColor = System.Drawing.Color.Transparent;
            this.correctLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctLbl.ForeColor = System.Drawing.Color.MediumBlue;
            this.correctLbl.Location = new System.Drawing.Point(157, 124);
            this.correctLbl.Name = "correctLbl";
            this.correctLbl.Size = new System.Drawing.Size(111, 31);
            this.correctLbl.TabIndex = 5;
            this.correctLbl.Text = "Correct";
            // 
            // CorrectNumLbl
            // 
            this.CorrectNumLbl.AutoSize = true;
            this.CorrectNumLbl.BackColor = System.Drawing.Color.Transparent;
            this.CorrectNumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectNumLbl.ForeColor = System.Drawing.Color.MediumBlue;
            this.CorrectNumLbl.Location = new System.Drawing.Point(176, 159);
            this.CorrectNumLbl.Name = "CorrectNumLbl";
            this.CorrectNumLbl.Size = new System.Drawing.Size(76, 25);
            this.CorrectNumLbl.TabIndex = 6;
            this.CorrectNumLbl.Text = "label7";
            this.CorrectNumLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accuracyLbl
            // 
            this.accuracyLbl.AutoSize = true;
            this.accuracyLbl.BackColor = System.Drawing.Color.Transparent;
            this.accuracyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accuracyLbl.ForeColor = System.Drawing.Color.DarkViolet;
            this.accuracyLbl.Location = new System.Drawing.Point(289, 122);
            this.accuracyLbl.Name = "accuracyLbl";
            this.accuracyLbl.Size = new System.Drawing.Size(136, 33);
            this.accuracyLbl.TabIndex = 7;
            this.accuracyLbl.Text = "Accuracy";
            // 
            // accuracyPercentLbl
            // 
            this.accuracyPercentLbl.AutoSize = true;
            this.accuracyPercentLbl.BackColor = System.Drawing.Color.Transparent;
            this.accuracyPercentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accuracyPercentLbl.ForeColor = System.Drawing.Color.DarkViolet;
            this.accuracyPercentLbl.Location = new System.Drawing.Point(325, 159);
            this.accuracyPercentLbl.Name = "accuracyPercentLbl";
            this.accuracyPercentLbl.Size = new System.Drawing.Size(60, 24);
            this.accuracyPercentLbl.TabIndex = 8;
            this.accuracyPercentLbl.Text = "label9";
            this.accuracyPercentLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(169, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 27);
            this.button1.TabIndex = 9;
            this.button1.Text = "Okay!!!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 235);
            this.Controls.Add(this.gradientGroup1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.gradientGroup1.ResumeLayout(false);
            this.gradientGroup1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientGroup gradientGroup1;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.Label numOfCharLbl;
        private System.Windows.Forms.Label totalNumLbl;
        private System.Windows.Forms.Label goodJobLbl;
        private System.Windows.Forms.Label accuracyPercentLbl;
        private System.Windows.Forms.Label accuracyLbl;
        private System.Windows.Forms.Label CorrectNumLbl;
        private System.Windows.Forms.Label correctLbl;
        private System.Windows.Forms.Label numOfErrorLbl;
        private System.Windows.Forms.Button button1;
    }
}