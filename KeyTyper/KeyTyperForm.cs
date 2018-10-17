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

        List<string> typePhrases = new List<string>();

        private string selectedLevelString;
        private string phraseTxtFile = "../../Resources/SetUpLevelsAndText.txt";
        private string userPhraseTxtFile = "../../Resources/userPhreases.txt";

        PointTracker pointTracker = new PointTracker();

        char[] removeChar = { '\n', '\r', '\t' };

        public KeyTyperForm()
        {
            InitializeComponent();
            AddLabelToDict(this);
            SetUpLevelsAndText();
            DisableUI();
        }

        public void AddLabelToDict(Control control)
        {

            if (control is LabelExt)
            {
                LabelExt labelExt = control as LabelExt;
                keyAndLabel.Add(labelExt.Key, labelExt);
            }
            else
            {
                foreach (Control child in control.Controls)
                {
                    AddLabelToDict(child);
                }

            }
        }

        private void UserInputBox_TextChanged(object sender, EventArgs e)
        {
            if (userInputBox.TextLength != 0 && selectedTextBox.Text.Length != 0)
            {
                // This subtracts one char from the beginning of the 
                // selectedBox text.
                selectedTextBox.Text = selectedTextBox.Text.Substring(1);
                CorrectOrError();
                ToTheEnd();
                if (userInputBox.Text.Length == selectedLevelString.Length)
                {
                    ShowResultsForm();
                }
            }
        }

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


        private void DeselectLabels()
        {
            foreach (var label in keyAndLabel.Values)
            {
                label.BackColor = Control.DefaultBackColor;
            }
        }

        private void DisableUI()
        {
            userInputBox.Enabled = false;
            upArrowImg.Visible = false;
            infoLbl.Visible = false;
        }

        private void ShowResultsForm()
        {
            ResultsForm resultForm = 
                new ResultsForm(selectedLevelString.Length, pointTracker.Red,
                pointTracker.Blue);
            string space = "                          ";

            DisableUI();
            resultForm.Show();
            userInputBox.Text = space + "Select a level to start again.";
            DeselectLabels();
            levelSelector.Text = "Select another level  ";
        }

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

        private void ToTheEnd()
        {
            userInputBox.SelectionStart = userInputBox.Text.Length;
            userInputBox.ScrollToCaret();
            userInputBox.SelectionBackColor = userInputBox.BackColor;
        }

        private void ResetUI()
        {
            userInputBox.Text = "";
            userInputBox.Enabled = true;
            userInputBox.Focus();
            upArrowImg.Visible = true;
            infoLbl.Visible = true;
        }

        private void LevelSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            string pasedString = typePhrases[comboBox.SelectedIndex].Trim(removeChar);
            selectedTextBox.Text = pasedString;
            selectedLevelString = pasedString;
            ResetUI();
            pointTracker.ResetPoints();
        }

        private void SetUpLevelsAndText()
        {
            typePhrases.AddRange(ParseTxtFile(phraseTxtFile));
            for (int i = 1; i <= typePhrases.Count; i++)
            {
                levelSelector.Items.Add($"             Level {i}");
            }
        }

        private string[] ParseTxtFile(string filePath)
        {
            char[] cool = { '/' };
            string readin = File.ReadAllText(filePath);
            return readin.Split(cool, StringSplitOptions.RemoveEmptyEntries);
        }

        private void AddPhraseBtn_Click(object sender, EventArgs e)
        {
            AddPhraseForm addPhraseForm = new AddPhraseForm();
            addPhraseForm.Show();
        }

        private void KeyTyperForm_Activated(object sender, EventArgs e)
        {
            if (File.Exists(userPhraseTxtFile))
            {
                string[] addedPhreases = ParseTxtFile(userPhraseTxtFile);

                for (int i = 0; i < addedPhreases.Length; i++)
                {
                    string trimmedString = addedPhreases[i].Trim(removeChar);
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

