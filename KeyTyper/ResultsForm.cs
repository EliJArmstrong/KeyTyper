// <author>Eli Armstrong</author>
// <remarks>I pledge my word of honor that I have abided
// by the CSN Academic Integrity Policy while completing
// this assignment.</remarks>
// <file>ResultsForm.cs</file>
// <date>2018-10-16</date>
// <summary>This is the code behind the Results form.</summary> 
// <remarks>Time taken to develop, write, test and debug
// solution. About 4 hours. </remarks>

using System;
using System.Windows.Forms;

// ----------------------------------------------------------------------------
// The Name Space for KeyTyper.
// ----------------------------------------------------------------------------
namespace KeyTyper
{
    /// -----------------------------------------------------------------------
    /// <summary>The ResultsFormclass with base of Form.</summary>
    /// -----------------------------------------------------------------------
    public partial class ResultsForm : Form
    {
        public ResultsForm()
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
