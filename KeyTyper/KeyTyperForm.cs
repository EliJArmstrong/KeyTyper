//https://bit.ly/2ybMsJD // Helped with getting a the labels in a form.

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
    public partial class KeyTyperForm : Form
    {
        private Dictionary<Keys, LabelExt> keyAndLabel = new Dictionary<Keys, LabelExt>();

        string testString = "The quick brown fox jumps over the lazy dog";

        public KeyTyperForm()
        {
            InitializeComponent();
            AddLabelToDict(this);
            richTextBox1.Focus();
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
            /*Console.WriteLine(richTextBox1.Text);
            if (richTextBox1.Text.Length == testString.Length)
            {
                foreach (var x in keyAndLabel)
                {
                    x.Value.BackColor = Control.DefaultBackColor;
                }
                for (var i = 0; i < richTextBox1.Text.Length; i++)
                {
                    if (richTextBox1.Text[i].Equals(testString[i]))
                    {
                        richTextBox1.SelectionStart = i;
                        richTextBox1.SelectionLength = 1;
                        richTextBox1.SelectionColor = Color.Blue;
                    }
                    else
                    {
                        richTextBox1.SelectionStart = i;
                        richTextBox1.SelectionLength = 1;
                        richTextBox1.ForeColor = Color.Red;
                    }
                }
                MessageBox.Show("Good Job");
            }*/
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine(e.KeyCode);

            if (keyAndLabel.ContainsKey(e.KeyCode))
            {
                keyAndLabel[e.KeyCode].BackColor = Color.Orange;
            }
            else
            {
                if(e.KeyCode == Keys.ShiftKey)
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
                } else if(e.KeyCode == Keys.ControlKey)
                {
                    lControlKeyLbl.BackColor = Control.DefaultBackColor;
                    rControlKeyLbl.BackColor = Control.DefaultBackColor;
                } else if (e.KeyCode == Keys.Menu)
                {
                    lAltKeyLbl.BackColor = Control.DefaultBackColor;
                    rAltKeyLbl.BackColor = Control.DefaultBackColor;
                }
            }
        }
    }
}

