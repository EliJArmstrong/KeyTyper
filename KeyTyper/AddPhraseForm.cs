// <author>Eli Armstrong</author>
// <remarks>I pledge my word of honor that I have abided
// by the CSN Academic Integrity Policy while completing
// this assignment.</remarks>
// <file>AddPhraseForm.cs</file>
// <date>2018-10-16</date>
// <summary>This is the code behind the AddPhrase form. This allows the user 
// to add their own phrase to test there touch type skills.</summary> 
// <remarks>Time taken to develop, write, test and debug
// solution. About 4 hours. </remarks>

using System;
using System.IO;
using System.Windows.Forms;

// ----------------------------------------------------------------------------
// The Name Space for KeyTyper.
// ----------------------------------------------------------------------------
namespace KeyTyper
{
    /// -----------------------------------------------------------------------
    /// <summary>The ResultsForm partial class with base of Form.</summary>
    /// -----------------------------------------------------------------------
    public partial class AddPhraseForm : Form
    {
        /// -------------------------------------------------------------------
        /// <summary>Constructor</summary>
        ///
        /// <remarks>Calls the InitializeComponent method and set the addPhrase
        /// button Enabled property to false.</remarks>
        /// -------------------------------------------------------------------
        public AddPhraseForm()
        {
            InitializeComponent();
            addPhraseBtn.Enabled = false;
        }

        /// -------------------------------------------------------------------
        /// <summary>
        /// This method's sender is a button that closes the form
        /// </summary>
        /// <param name="sender">The sender that called the method.</param>
        /// <param name="e">The event argument object</param>
        /// -------------------------------------------------------------------
        private void Done_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// -------------------------------------------------------------------
        /// <summary>
        /// This method's sender is a button that append the text in the 
        /// textbox to a file full of user entered phrases. If the file does 
        /// not exists this method will created it.
        /// </summary>
        /// <param name="sender">The sender that called the method.</param>
        /// <param name="e">The event argument object</param>
        /// -------------------------------------------------------------------
        private void AddPhrase_Click(object sender, EventArgs e)
        {
            if(phraseBox.TextLength > 0)
            {
                File.AppendAllText("../../Resources/userPhreases.txt",
                    phraseBox.Text + '/' + '\n');
                phraseBox.Text = "";
                MessageBox.Show("Phrase added.");
            }
            else
            {
                MessageBox.Show("You must add a phrase.");
            }
        }

        /// -------------------------------------------------------------------
        /// <summary>
        /// This method will clear the textbox if the user click in it 
        /// for the first time and will enable the addPhraseBtn.
        /// </summary>
        /// <param name="sender">The sender that called the method.</param>
        /// <param name="e">The event argument object</param>
        /// -------------------------------------------------------------------
        private void PhraseBox_Click(object sender, EventArgs e)
        {
            if (phraseBox.Text.Equals("Add your type phrase here.")){ 
                phraseBox.Text = "";
                addPhraseBtn.Enabled = true;
            }
        }

        /// -------------------------------------------------------------------
        /// <summary>
        /// This method will enable the addPhraseBtn just in case the user 
        /// highlights the text in the textbox and hit the backspace key.
        /// </summary>
        /// <param name="sender">The sender that called the method.</param>
        /// <param name="e">The event argument object</param>
        /// -------------------------------------------------------------------
        private void PhraseBox_TextChanged(object sender, EventArgs e)
        {
            if (phraseBox.Text.Equals("")){
                addPhraseBtn.Enabled = true;
            }
        }
    }
}
