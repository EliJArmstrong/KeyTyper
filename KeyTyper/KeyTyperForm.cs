//https://bit.ly/2ybMsJD // Helped with getting a the labels in a form.

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KeyTyper
{
    public partial class KeyTyperForm : Form
    {
        private Dictionary<Keys, LabelExt> keyAndLabel = 
            new Dictionary<Keys, LabelExt>();

        string[] typePhrases = { "The quick brown fox jumps over the lazy dog.",
            "Roses are red, violets are blue, I'm a good typer and so are you."
            , "Everyday somewhere in the world another unsung hero is born. " +
                "Someone who is willing, to lay his life on the line to save" +
                " another living creature, on this wonderful planet of ours." +
                " To go out of their way, and risk life and limb to save" +
                " something, from danger and certain death. These unsung" +
                " heroes don’t want medals, glory or even fame. In fact," +
                " most would walk away afterwards, without anyone ever" +
                " knowing their name. It is not that they feel guilty. " +
                "They just feel that they haven’t done anything that is " +
                "special or something someone else wouldn’t have probably " +
                "done. Therefore, to all those unsung heroes this poem is " +
                "just for you. For all the lives that you save each and " +
                "every day. David Harris" };

        private string selectedLevelString;

        PointTracker pointTracker = new PointTracker();

        public KeyTyperForm()
        {
            InitializeComponent();
            AddLabelToDict(this);
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
                    showResultsForm();
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

        private void LevelBtn_Click(object sender, EventArgs e)
        {
            Button senderBtn = sender as Button;
            selectedTextBox.Text = typePhrases[senderBtn.TabIndex];
            selectedLevelString = typePhrases[senderBtn.TabIndex];
            ResetUI();
            pointTracker.ResetPoints();
        }

        
        private void DeselectLabels()
        {
            foreach (var label in keyAndLabel.Values){
                label.BackColor = Control.DefaultBackColor;
            }
        }

        private void DisableUI()
        {
            userInputBox.Enabled = false;
            upArrowImg.Visible = false;
            infoLbl.Visible = false;
        }

        private void showResultsForm()
        {
            ResultsForm resultForm = new ResultsForm();
            DisableUI();
            string space = "                          ";
            resultForm.SetLabels(selectedLevelString.Length, pointTracker.Red,
                pointTracker.Blue);
            resultForm.Show();
            userInputBox.Text = space + "Select a level to start again.";
            DeselectLabels();
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
        
    }
}

