// <author>Eli Armstrong</author>
// <remarks>I pledge my word of honor that I have abided
// by the CSN Academic Integrity Policy while completing
// this assignment.</remarks>
// <file>ResultsForm.cs</file>
// <date>2018-10-16</date>
// <summary>This is the code behind the Results form. This shows the number of 
// char, errors, correct, and the percentage of correct</summary> 
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
    /// <summary>The ResultsForm partial class with base of Form.</summary>
    /// -----------------------------------------------------------------------
    public partial class ResultsForm : Form
    {
        /// -------------------------------------------------------------------
        /// <summary>Constructor</summary>
        ///
        /// <remarks>Calls the InitializeComponent method.</remarks>
        /// -------------------------------------------------------------------
        public ResultsForm()
        {
            InitializeComponent();
        }

        /// -------------------------------------------------------------------
        /// <summary>Overloaded Constructor</summary>
        ///
        /// <param name="numOfChar">The number of char that where typed</param>
        /// <param name="numOfError">The number of errors entered</param>
        /// <param name="numOfCorrect">The of correct char the user entered
        /// </param>
        /// 
        /// <remarks>Calls the InitializeComponent method.
        /// and set the label of the form.</remarks>
        /// -------------------------------------------------------------------
        public ResultsForm(int numOfChar, int numOfError, int numOfCorrect)
        {
            InitializeComponent();
            SetLabels(numOfChar, numOfError, numOfCorrect);
        }


        /// -------------------------------------------------------------------
        /// <summary>This method sets the labels in the form</summary>
        ///
        /// <param name="numOfChar">The number of char that where typed</param>
        /// <param name="numOfError">The number of errors entered</param>
        /// <param name="numOfCorrect">The of correct char the user entered
        /// </param>
        /// -------------------------------------------------------------------
        public void SetLabels(int numOfChar, int numOfError, int numOfCorrect)
        {
            numOfCharLbl.Text = $"{numOfChar}";
            numOfErrorLbl.Text = $"{numOfError}";
            CorrectNumLbl.Text = $"{numOfCorrect}";
            accuracyPercentLbl.Text =
            $"{(int)Math.Ceiling((((double)numOfCorrect /(double)numOfChar) * 100))}%";
        }

        /// -------------------------------------------------------------------
        /// <summary>
        /// This method's sender is a button that closes the form
        /// </summary>
        /// <param name="sender">The sender that called the method.</param>
        /// <param name="e">The event argument object</param>
        /// -------------------------------------------------------------------
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
