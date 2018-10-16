using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyTyper
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void SetLabels(int numOfChar, int numOfError, int numOfCorrect)
        {
            numOfCharLbl.Text = $"{numOfChar}";
            numOfErrorLbl.Text = $"{numOfError}";
            CorrectNumLbl.Text = $"{numOfCorrect}";
            accuracyPercentLbl.Text = $"{(int)Math.Ceiling((((double)numOfCorrect / (double)numOfChar) * 100))}%";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
