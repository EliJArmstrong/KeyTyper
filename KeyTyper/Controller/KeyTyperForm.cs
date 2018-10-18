// <author>Eli Armstrong</author>
// <remarks>I pledge my word of honor that I have abided
// by the CSN Academic Integrity Policy while completing
// this assignment.</remarks>
// <file>KeyTyperForm.cs</file>
// <date>2018-10-16</date>
// <summary>This class is to represents the abstract idea of a Two Dimensional 
// Shape.</summary> 
// <remarks>Time taken to develop, write, test and debug
// solution. About 4 hours. </remarks>
// <note>Gradient code from here: 
//https://bit.ly/2ybMsJD Helped with getting a the labels in a form. </note>


using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

// ----------------------------------------------------------------------------
// The Name Space for KeyTyper.
// ----------------------------------------------------------------------------
namespace KeyTyper
{
    /// -----------------------------------------------------------------------
    /// <summary>The KeyTyperForm partial class with base of Form.</summary>
    /// -----------------------------------------------------------------------
    public partial class KeyTyperForm : Form
    {

        // Holds a Dictionary with a Keys enum as the key and a LabelExt as 
        // a value.
        private Dictionary<Keys, LabelExt> keyAndLabel =
            new Dictionary<Keys, LabelExt>();

        // Stores the phrases for the user to type.
        private List<string> typePhrases = new List<string>();
        
        // Stores the the full string/text for the selected phrase to type. 
        private string selectedLevelString;
        
        // Stores the file path for the default phrases.
        private static string phraseTxtFile =
                                   "../../Resources/SetUpLevelsAndText.txt";
        
        // Stores the file path for the user phrases.
        private static string userPhraseTxtFile =
                                   "../../Resources/userPhrases.txt";

        // An instance of the pointTracker class that is used to track point
        // for games. But in this case it's used to track the number of 
        // right and wrong typed characters.
        private PointTracker pointTracker = new PointTracker();

        // The characters to trim when parsing the files.
        private static char[] removeChars = { '\n', '\r', '\t', ' ' };

        // The character(s) to split the files from the read in files.
        private static char[] separators = { '/' };


        /// -------------------------------------------------------------------
        /// <summary>Constructor</summary>
        ///
        /// <remarks>Calls the InitializeComponent method. Adds the labelExt to 
        /// the to the keys label dictionary. Adds the phrases from a file and 
        /// create the indexes for the combo box selected. Also, disables the 
        /// UI.</remarks>
        /// -------------------------------------------------------------------
        public KeyTyperForm()
        {
            InitializeComponent();
            AddLabelExtToDict(this);
            SetUpLevelsAndText();
            DisableUI();
        }

        /// -------------------------------------------------------------------
        /// <summary>This method get the controls from the form and adds
        /// controls that are labelExts to the keys/labelsExt dictionary
        /// </summary>
        /// <param name="control">The Control for the form.</param>
        /// -------------------------------------------------------------------
        private void AddLabelExtToDict(Control control)
        {

            if (control is LabelExt)
            {
                // label to be casted and added to keyAndLabel.
                LabelExt labelExt = control as LabelExt;
                keyAndLabel.Add(labelExt.Key, labelExt);
            }
            else
            {
                foreach (Control child in control.Controls)
                {
                    AddLabelExtToDict(child);
                }

            }
        }

        /// -------------------------------------------------------------------
        /// <summary>The method gets called every time the text changes in the
        /// richtextbox (userInputBox). This method takes one character from 
        /// the front of the text of the selectedTextBox and removes it.
        /// When the user input becomes the same length as the selected phrase
        /// the results form method is called.</summary>
        /// <param name="sender">The caller of the method.</param>
        /// <param name="e">The event choices that are offered.</param>
        /// -------------------------------------------------------------------
        private void UserInputBox_TextChanged(object sender, EventArgs e)
        {
            if (userInputBox.TextLength != 0 && selectedTextBox.Text.Length != 0)
            {
                // This subtracts one char from the beginning of the 
                // selectedBox text.
                selectedTextBox.Text = selectedTextBox.Text.Substring(1);
                CorrectOrError();
                ToTheEnd();
                if (userInputBox.TextLength == selectedLevelString.Length)
                {
                    ShowResultsForm();
                }
            }
        }

        /// -------------------------------------------------------------------
        /// <summary>The method gets called every time a key on the physical 
        /// keyboard is pressed down. When a key on the physical keyboard is 
        /// pressed down the associated key on the form's keyboard will light 
        /// up orange. If the back space key is hit the key is suppressed. If
        /// the user input text length is greater than the selected text length
        /// then the keys are suppressed.</summary>
        /// <param name="sender">The caller of the method.</param>
        /// <param name="e">The event choices that are offered.</param>
        /// -------------------------------------------------------------------
        private void UserInputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (keyAndLabel.ContainsKey(e.KeyCode))
            {
                keyAndLabel[e.KeyCode].BackColor = Color.Orange;
            }
            else
            {
                if (e.KeyCode == Keys.ShiftKey)
                {
                    lShiftKeyLbl.BackColor = Color.Orange;
                    rShiftKeyLbl.BackColor = Color.Orange;
                }
                else if (e.KeyCode == Keys.ControlKey)
                {
                    lControlKeyLbl.BackColor = Color.Orange;
                    rControlKeyLbl.BackColor = Color.Orange;
                }
                else if (e.KeyCode == Keys.Menu)
                {
                    lAltKeyLbl.BackColor = Color.Orange;
                    rAltKeyLbl.BackColor = Color.Orange;
                }
            }
            if (e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
            if (userInputBox.Text.Length >= selectedLevelString.Length)
            {
                e.SuppressKeyPress = true;
            }
        }


        /// -------------------------------------------------------------------
        /// <summary>The method gets called every time a key on the physical 
        /// keyboard is lifted up. When a key on the physical keyboard is 
        /// lifted up the associated key on the froms keyboard will go back to
        /// it's default back color. If the back space key is lifted up will a
        /// message shows stating that the back space key is disabled.
        /// </summary>
        /// <param name="sender">The caller of the method.</param>
        /// <param name="e">The event choices that are offered.</param>
        /// -------------------------------------------------------------------
        private void UserInputBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (keyAndLabel.ContainsKey(e.KeyCode))
            {
                keyAndLabel[e.KeyCode].BackColor = Control.DefaultBackColor;
            }
            else
            {
                if (e.KeyCode == Keys.ShiftKey)
                {
                    lShiftKeyLbl.BackColor = Control.DefaultBackColor;
                    rShiftKeyLbl.BackColor = Control.DefaultBackColor;
                }
                else if (e.KeyCode == Keys.ControlKey)
                {
                    lControlKeyLbl.BackColor = Control.DefaultBackColor;
                    rControlKeyLbl.BackColor = Control.DefaultBackColor;
                }
                else if (e.KeyCode == Keys.Menu)
                {
                    lAltKeyLbl.BackColor = Control.DefaultBackColor;
                    rAltKeyLbl.BackColor = Control.DefaultBackColor;
                }
            }
            if (e.KeyCode == Keys.Back)
            {
                MessageBox.Show("BackSpace has been disabled.");
            }
        }


        /// -------------------------------------------------------------------
        /// <summary>This method will cause all the labels in the form to go 
        /// to there default back color.</summary>
        /// -------------------------------------------------------------------
        private void DeselectLabels()
        {
            foreach (var label in keyAndLabel.Values)
            {
                label.BackColor = Control.DefaultBackColor;
            }
        }

        /// -------------------------------------------------------------------
        /// <summary>
        /// This method disables the UI so that the user can not 
        /// enter any text. Also, sets the arrow and info label to invisible.
        /// </summary>
        /// -------------------------------------------------------------------
        private void DisableUI()
        {
            userInputBox.Enabled = false;
            upArrowImg.Visible = false;
            infoLbl.Visible = false;
        }

        /// -------------------------------------------------------------------
        /// <summary>
        /// This method shows the results form. the result form is passed the
        /// user input data and displays the result from. This method will also
        /// disable the UI. decolor the labels and set the test for the 
        /// levelSelector combo box and user inout text box.
        /// </summary>
        /// -------------------------------------------------------------------
        private void ShowResultsForm()
        {
            // A result form to show the results of the users inputs.
            ResultsForm resultForm = 
                new ResultsForm(selectedLevelString.Length, pointTracker.Red,
                pointTracker.Blue);

            // Addes space to the front of the userInputBox text.
            string space = "                          ";

            DisableUI();
            resultForm.Show();
            userInputBox.Text = space + "Select a level to start again.";
            DeselectLabels();
            levelSelector.Text = "Select another level  ";
        }

        /// -------------------------------------------------------------------
        /// <summary>
        /// This method determines if the user input matches the current index
        /// of the selectedLevelstring. If the user input and the 
        /// selectedLevelstring at the current index match the the user text 
        /// will be blue else the user text will be red. this will also add a 
        /// point to blue if the input was correct and red if an error was 
        /// made. If a space was placed in the worong location the back color
        /// of that index will become red.
        /// </summary>
        /// -------------------------------------------------------------------
        private void CorrectOrError()
        {
            userInputBox.Select(userInputBox.TextLength - 1, 1);
            if (userInputBox.Text[userInputBox.TextLength - 1]
                .Equals(selectedLevelString[userInputBox.TextLength - 1]))
            {
                userInputBox.SelectionColor = Color.Blue;
                pointTracker.OnePointBlue();
            }
            else
            {
                userInputBox.SelectionColor = Color.Red;
                if (userInputBox.SelectedText == " ")
                {
                    userInputBox.SelectionBackColor = Color.Red;
                }
                pointTracker.OnePointRed();
            }
        }

        /// -------------------------------------------------------------------
        /// <summary>
        /// This method sends the caret to the end of the user input and sets
        /// the back color to the same color to the back color of the text box.
        /// </summary>
        /// -------------------------------------------------------------------
        private void ToTheEnd()
        {
            userInputBox.SelectionStart = userInputBox.Text.Length;
            userInputBox.ScrollToCaret();
            userInputBox.SelectionBackColor = userInputBox.BackColor;
        }

        /// -------------------------------------------------------------------
        /// <summary>
        /// This method resets the UI by setting the text back to blank, 
        /// enables the text box, gives the text box focus, and makes the arrow
        /// and info label to visible.
        /// </summary>
        /// -------------------------------------------------------------------
        private void ResetUI()
        {
            userInputBox.Text = "";
            userInputBox.Enabled = true;
            userInputBox.Focus();
            upArrowImg.Visible = true;
            infoLbl.Visible = true;
        }

        /// -------------------------------------------------------------------
        /// <summary>
        /// The method gets called every a seletion is made in the 
        /// level slector combo box. This uses the index of the combo box to 
        /// choose the phrase in the typePhrases array. This will set the 
        /// selectedTextBox text and selectedLevelString to the typePhrase 
        /// index. Resets the UI and resets the points in the pointTracker.
        /// </summary>
        /// <param name="sender">The caller of the method.</param>
        /// <param name="e">The event choices that are offered.</param>
        /// -------------------------------------------------------------------
        private void LevelSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            // The casted comboBox to be used by for its index numbers.
            ComboBox comboBox = sender as ComboBox;

            // A trimmed string removed of end lines, tabs, spaces, and /r 
            // from the front and end of the string.
            string trimmedString = typePhrases[comboBox.SelectedIndex].Trim(removeChars);

            selectedTextBox.Text = trimmedString;
            selectedLevelString = trimmedString;
            ResetUI();
            pointTracker.ResetPoints();
        }

        /// -------------------------------------------------------------------
        /// <summary>
        /// This method adds the phrases from a text file and addeds the
        /// phrases to the typePhrase list. This also adds the indexes to the 
        /// combo box.
        /// </summary>
        /// -------------------------------------------------------------------
        private void SetUpLevelsAndText()
        {
            typePhrases.AddRange(ParseTxtFile(phraseTxtFile));
            for (int i = 1; i <= typePhrases.Count; i++)
            {
                levelSelector.Items.Add($"             Level {i}");
            }
        }

        /// -------------------------------------------------------------------
        /// <summary>
        /// This method reads in a file and creates a string array to be
        /// returned.
        /// </summary>
        /// <param name="filePath">The path of the file to parse</param>
        /// <returns>A string array of the prases in the file.</returns>
        /// <remarks>The file being prased must be separated with a "/" between
        /// each phrase.</remarks>
        /// -------------------------------------------------------------------
        private string[] ParseTxtFile(string filePath)
        {
            // The read in file as a string
            string readin = File.ReadAllText(filePath);
            return readin.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        }

        /// -------------------------------------------------------------------
        /// <summary>
        /// The method gets when the add phrase button is clicked. This will 
        /// crate and show an add phrase form. </summary>
        /// <param name="sender">The caller of the method.</param>
        /// <param name="e">The event choices that are offered.</param>
        /// -------------------------------------------------------------------
        private void AddPhraseBtn_Click(object sender, EventArgs e)
        {
            // An AddPhraseForm to get user phrases.
            AddPhraseForm addPhraseForm = new AddPhraseForm();
            addPhraseForm.Show();
        }

        /// -------------------------------------------------------------------
        /// <summary>
        /// The method gets called when this form get activated. This will 
        /// check to see if there is user entered phrases file exists and if 
        /// it does it will add the phrases to the typePhrases list and add 
        /// a custom level index to the combo box. This will also trim the 
        /// front and end of the added string of end lines, tabs, /r, and  
        /// spaces.</summary>
        /// <param name="sender">The caller of the method.</param>
        /// <param name="e">The event choices that are offered.</param>
        /// -------------------------------------------------------------------
        private void KeyTyperForm_Activated(object sender, EventArgs e)
        {
            if (File.Exists(userPhraseTxtFile))
            {
                // An array of user phrases.
                string[] addedPhreases = ParseTxtFile(userPhraseTxtFile);

                for (int i = 0; i < addedPhreases.Length; i++)
                {
                    // A trimmed string removed of end lines, tabs, spaces, and /r 
                    // from the front and end of the string. 
                    string trimmedString = addedPhreases[i].Trim(removeChars);
                    if (!typePhrases.Contains(trimmedString))
                    {
                        if (!trimmedString.Equals(""))
                        {
                            typePhrases.Add(trimmedString);
                            levelSelector.Items.Add($"      Custom Level " +
                                $"{i+1}");
                        }
                    }
                }
            }
        }
    }
}

