namespace KeyTyper
{
    partial class AddPhraseForm
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
            this.doneBtn = new System.Windows.Forms.Button();
            this.addPhraseBtn = new System.Windows.Forms.Button();
            this.phraseBox = new System.Windows.Forms.TextBox();
            this.gradientGroup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientGroup1
            // 
            this.gradientGroup1.ColorBottom = System.Drawing.Color.Fuchsia;
            this.gradientGroup1.ColorTop = System.Drawing.Color.Yellow;
            this.gradientGroup1.Controls.Add(this.doneBtn);
            this.gradientGroup1.Controls.Add(this.addPhraseBtn);
            this.gradientGroup1.Controls.Add(this.phraseBox);
            this.gradientGroup1.Location = new System.Drawing.Point(1, -5);
            this.gradientGroup1.Name = "gradientGroup1";
            this.gradientGroup1.Size = new System.Drawing.Size(800, 291);
            this.gradientGroup1.TabIndex = 0;
            this.gradientGroup1.TabStop = false;
            // 
            // doneBtn
            // 
            this.doneBtn.Location = new System.Drawing.Point(355, 245);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(104, 28);
            this.doneBtn.TabIndex = 0;
            this.doneBtn.Text = "Done";
            this.doneBtn.UseVisualStyleBackColor = true;
            this.doneBtn.Click += new System.EventHandler(this.Done_Click);
            // 
            // addPhraseBtn
            // 
            this.addPhraseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPhraseBtn.Location = new System.Drawing.Point(355, 181);
            this.addPhraseBtn.Name = "addPhraseBtn";
            this.addPhraseBtn.Size = new System.Drawing.Size(104, 49);
            this.addPhraseBtn.TabIndex = 1;
            this.addPhraseBtn.Text = "Add Phrase";
            this.addPhraseBtn.UseVisualStyleBackColor = true;
            this.addPhraseBtn.Click += new System.EventHandler(this.AddPhrase_Click);
            // 
            // phraseBox
            // 
            this.phraseBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phraseBox.Location = new System.Drawing.Point(11, 19);
            this.phraseBox.Multiline = true;
            this.phraseBox.Name = "phraseBox";
            this.phraseBox.Size = new System.Drawing.Size(776, 156);
            this.phraseBox.TabIndex = 0;
            this.phraseBox.Text = "Add your type phrase here.";
            this.phraseBox.Click += new System.EventHandler(this.PhraseBox_Click);
            this.phraseBox.TextChanged += new System.EventHandler(this.PhraseBox_TextChanged);
            // 
            // AddPhraseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 280);
            this.Controls.Add(this.gradientGroup1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AddPhraseForm";
            this.ShowIcon = false;
            this.Text = "AddPhrase";
            this.gradientGroup1.ResumeLayout(false);
            this.gradientGroup1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientGroup gradientGroup1;
        private System.Windows.Forms.Button addPhraseBtn;
        private System.Windows.Forms.TextBox phraseBox;
        private System.Windows.Forms.Button doneBtn;
    }
}