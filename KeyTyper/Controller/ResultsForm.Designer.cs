﻿namespace KeyTyper
{
    partial class ResultsForm
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
            this.resultsGroup = new KeyTyper.GradientGroup();
            this.closeBtn = new System.Windows.Forms.Button();
            this.accuracyPercentLbl = new System.Windows.Forms.Label();
            this.accuracyLbl = new System.Windows.Forms.Label();
            this.CorrectNumLbl = new System.Windows.Forms.Label();
            this.correctLbl = new System.Windows.Forms.Label();
            this.numOfErrorLbl = new System.Windows.Forms.Label();
            this.errorLbl = new System.Windows.Forms.Label();
            this.numOfCharLbl = new System.Windows.Forms.Label();
            this.totalNumLbl = new System.Windows.Forms.Label();
            this.goodJobLbl = new System.Windows.Forms.Label();
            this.resultsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultsGroup
            // 
            this.resultsGroup.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.resultsGroup.ColorTop = System.Drawing.Color.Cyan;
            this.resultsGroup.Controls.Add(this.closeBtn);
            this.resultsGroup.Controls.Add(this.accuracyPercentLbl);
            this.resultsGroup.Controls.Add(this.accuracyLbl);
            this.resultsGroup.Controls.Add(this.CorrectNumLbl);
            this.resultsGroup.Controls.Add(this.correctLbl);
            this.resultsGroup.Controls.Add(this.numOfErrorLbl);
            this.resultsGroup.Controls.Add(this.errorLbl);
            this.resultsGroup.Controls.Add(this.numOfCharLbl);
            this.resultsGroup.Controls.Add(this.totalNumLbl);
            this.resultsGroup.Controls.Add(this.goodJobLbl);
            this.resultsGroup.Location = new System.Drawing.Point(0, -13);
            this.resultsGroup.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.resultsGroup.Name = "resultsGroup";
            this.resultsGroup.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.resultsGroup.Size = new System.Drawing.Size(870, 469);
            this.resultsGroup.TabIndex = 0;
            this.resultsGroup.TabStop = false;
            // 
            // closeBtn
            // 
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.closeBtn.Location = new System.Drawing.Point(338, 390);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(166, 52);
            this.closeBtn.TabIndex = 9;
            this.closeBtn.Text = "Okay!!!";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // accuracyPercentLbl
            // 
            this.accuracyPercentLbl.AutoSize = true;
            this.accuracyPercentLbl.BackColor = System.Drawing.Color.Transparent;
            this.accuracyPercentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accuracyPercentLbl.ForeColor = System.Drawing.Color.DarkViolet;
            this.accuracyPercentLbl.Location = new System.Drawing.Point(670, 306);
            this.accuracyPercentLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.accuracyPercentLbl.Name = "accuracyPercentLbl";
            this.accuracyPercentLbl.Size = new System.Drawing.Size(117, 44);
            this.accuracyPercentLbl.TabIndex = 8;
            this.accuracyPercentLbl.Text = "100%";
            this.accuracyPercentLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accuracyLbl
            // 
            this.accuracyLbl.AutoSize = true;
            this.accuracyLbl.BackColor = System.Drawing.Color.Transparent;
            this.accuracyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accuracyLbl.ForeColor = System.Drawing.Color.DarkViolet;
            this.accuracyLbl.Location = new System.Drawing.Point(578, 238);
            this.accuracyLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.accuracyLbl.Name = "accuracyLbl";
            this.accuracyLbl.Size = new System.Drawing.Size(267, 67);
            this.accuracyLbl.TabIndex = 7;
            this.accuracyLbl.Text = "Accuracy";
            // 
            // CorrectNumLbl
            // 
            this.CorrectNumLbl.AutoSize = true;
            this.CorrectNumLbl.BackColor = System.Drawing.Color.Transparent;
            this.CorrectNumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectNumLbl.ForeColor = System.Drawing.Color.MediumBlue;
            this.CorrectNumLbl.Location = new System.Drawing.Point(370, 310);
            this.CorrectNumLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CorrectNumLbl.Name = "CorrectNumLbl";
            this.CorrectNumLbl.Size = new System.Drawing.Size(68, 48);
            this.CorrectNumLbl.TabIndex = 6;
            this.CorrectNumLbl.Text = "42";
            this.CorrectNumLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // correctLbl
            // 
            this.correctLbl.AutoSize = true;
            this.correctLbl.BackColor = System.Drawing.Color.Transparent;
            this.correctLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctLbl.ForeColor = System.Drawing.Color.MediumBlue;
            this.correctLbl.Location = new System.Drawing.Point(304, 242);
            this.correctLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.correctLbl.Name = "correctLbl";
            this.correctLbl.Size = new System.Drawing.Size(211, 63);
            this.correctLbl.TabIndex = 5;
            this.correctLbl.Text = "Correct";
            // 
            // numOfErrorLbl
            // 
            this.numOfErrorLbl.AutoSize = true;
            this.numOfErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.numOfErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.numOfErrorLbl.Location = new System.Drawing.Point(90, 310);
            this.numOfErrorLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.numOfErrorLbl.Name = "numOfErrorLbl";
            this.numOfErrorLbl.Size = new System.Drawing.Size(64, 44);
            this.numOfErrorLbl.TabIndex = 4;
            this.numOfErrorLbl.Text = "25";
            this.numOfErrorLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.BackColor = System.Drawing.Color.Transparent;
            this.errorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLbl.ForeColor = System.Drawing.Color.Red;
            this.errorLbl.Location = new System.Drawing.Point(32, 235);
            this.errorLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(192, 67);
            this.errorLbl.TabIndex = 3;
            this.errorLbl.Text = "Errors";
            // 
            // numOfCharLbl
            // 
            this.numOfCharLbl.AutoSize = true;
            this.numOfCharLbl.BackColor = System.Drawing.Color.Transparent;
            this.numOfCharLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfCharLbl.ForeColor = System.Drawing.Color.Black;
            this.numOfCharLbl.Location = new System.Drawing.Point(368, 162);
            this.numOfCharLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.numOfCharLbl.Name = "numOfCharLbl";
            this.numOfCharLbl.Size = new System.Drawing.Size(89, 63);
            this.numOfCharLbl.TabIndex = 2;
            this.numOfCharLbl.Text = "62";
            // 
            // totalNumLbl
            // 
            this.totalNumLbl.AutoSize = true;
            this.totalNumLbl.BackColor = System.Drawing.Color.Transparent;
            this.totalNumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalNumLbl.ForeColor = System.Drawing.Color.Black;
            this.totalNumLbl.Location = new System.Drawing.Point(22, 104);
            this.totalNumLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.totalNumLbl.Name = "totalNumLbl";
            this.totalNumLbl.Size = new System.Drawing.Size(534, 48);
            this.totalNumLbl.TabIndex = 1;
            this.totalNumLbl.Text = "Total Number of Characters";
            // 
            // goodJobLbl
            // 
            this.goodJobLbl.AutoSize = true;
            this.goodJobLbl.BackColor = System.Drawing.Color.Transparent;
            this.goodJobLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodJobLbl.Location = new System.Drawing.Point(292, 31);
            this.goodJobLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.goodJobLbl.Name = "goodJobLbl";
            this.goodJobLbl.Size = new System.Drawing.Size(329, 73);
            this.goodJobLbl.TabIndex = 0;
            this.goodJobLbl.Text = "Good Job!";
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 452);
            this.Controls.Add(this.resultsGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ResultsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Results";
            this.resultsGroup.ResumeLayout(false);
            this.resultsGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientGroup resultsGroup;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.Label numOfCharLbl;
        private System.Windows.Forms.Label totalNumLbl;
        private System.Windows.Forms.Label goodJobLbl;
        private System.Windows.Forms.Label accuracyPercentLbl;
        private System.Windows.Forms.Label accuracyLbl;
        private System.Windows.Forms.Label CorrectNumLbl;
        private System.Windows.Forms.Label correctLbl;
        private System.Windows.Forms.Label numOfErrorLbl;
        private System.Windows.Forms.Button closeBtn;
    }
}