//https://bit.ly/2ybMsJD // Helped with getting a the labels in a form.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyTyper
{
    public partial class KeyTyperForm : Form
    {
        private Dictionary<Keys, LabelExt> keyAndLabel = new Dictionary<Keys, LabelExt>();

        string[] testString = { "The quick brown fox jumps over the lazy dog.",
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

        string selectedLevelString;

        int blue = 0;
        int red = 0;

        public KeyTyperForm()
        {
            InitializeComponent();
            AddLabelToDict(this);
            richTextBox1.Focus();
            richTextBox1.Enabled = false;
            pictureBox1.Visible = false;
            label1.Visible = false;
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength != 0 && textBox1.Text.Length != 0)
            {
                textBox1.Text = textBox1.Text.Substring(1);
                richTextBox1.Select(richTextBox1.TextLength - 1, 1);
                if (richTextBox1.Text[richTextBox1.TextLength - 1]
                    .Equals(selectedLevelString[richTextBox1.TextLength - 1]))
                {
                    richTextBox1.SelectionColor = Color.Blue;
                    blue++;
                }
                else
                {
                    richTextBox1.SelectionColor = Color.Red;
                    if (richTextBox1.SelectedText == " ")
                    {
                        richTextBox1.SelectionBackColor = Color.Red;
                    }
                    red++;
                }

                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                richTextBox1.ScrollToCaret();
                richTextBox1.SelectionBackColor = richTextBox1.BackColor;
            }

 
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
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
        }

        private void richTextBox1_KeyUp(object sender, KeyEventArgs e)
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
            if (richTextBox1.Text.Length >= selectedLevelString.Length)
            {
                Form2 form2 = new Form2();
                string space = "                          ";
                richTextBox1.Enabled = false;
                form2.SetLabels(selectedLevelString.Length, red, blue);
                form2.Show();
                richTextBox1.Text =  space + "Select a level to start again.";
                deselectLabels();
                pictureBox1.Visible = false;
                label1.Visible = false;
            }
        }

        private void levelOneBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = testString[0];
            selectedLevelString = testString[0];
            richTextBox1.Text = "";
            richTextBox1.Enabled = true;
            richTextBox1.Focus();
            red = 0;
            blue = 0;
            pictureBox1.Visible = true;
            label1.Visible = true;

        }

        private void LevelTwoBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = testString[1];
            selectedLevelString = testString[1];
            richTextBox1.Text = "";
            richTextBox1.Enabled = true;
            richTextBox1.Focus();
            red = 0;
            blue = 0;
            pictureBox1.Visible = true;
            label1.Visible = true;
        }

        private void levelThreeBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = testString[2];
            selectedLevelString = testString[2];
            richTextBox1.Text = "";
            richTextBox1.Enabled = true;
            richTextBox1.Focus();
            red = 0;
            blue = 0;
            pictureBox1.Visible = true;
            label1.Visible = true;

        }
        
        private void deselectLabels()
        {
            foreach (var label in keyAndLabel.Values){
                label.BackColor = Control.DefaultBackColor;
            }
        }
        
    }
}

