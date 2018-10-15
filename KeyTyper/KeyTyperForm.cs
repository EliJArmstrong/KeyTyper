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

        string testString = "The quick brown fox jumps over the lazy dog";

        public KeyTyperForm()
        {
            InitializeComponent();
            AddLabelToDict(this);
            richTextBox1.Focus();
            //richTextBox1.Enabled = false;
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
            Console.WriteLine(richTextBox1.Text);

            int blue = 0;
            int red = 0;

            richTextBox1.DeselectAll();

            Console.WriteLine(richTextBox1.TextLength);
            if(richTextBox1.TextLength != 0)
            {
                richTextBox1.Select(richTextBox1.TextLength - 1, 1);
                if (richTextBox1.TextLength <= testString.Length && richTextBox1.Text[richTextBox1.TextLength - 1].Equals(testString[richTextBox1.TextLength - 1]))
                {
                    richTextBox1.SelectionColor = Color.Blue;
                    blue++;
                    richTextBox1.DeselectAll();
                    SendKeys.Send("{RIGHT}");
                }
                else
                {
                    richTextBox1.SelectionColor = Color.Red;
                    red++;
                    richTextBox1.DeselectAll();
                    SendKeys.Send("{RIGHT}");
                }
            }

               

            /*if (richTextBox1.Text.Length == testString.Length)
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
                        blue++;
                    }
                    else
                    {
                        richTextBox1.SelectionStart = i;
                        richTextBox1.SelectionLength = 1;
                        richTextBox1.ForeColor = Color.Red;
                        red++;
                    }
                }*/
                Console.WriteLine($"Red: {red}");
                Console.WriteLine($"Blue: {blue}");
                //MessageBox.Show("Good Job");
            //}
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
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
                SendKeys.Send("{RIGHT}");
            }
        }
    }
}

