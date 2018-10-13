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
        private Dictionary<Keys, Label> keyAndLabel = new Dictionary<Keys, Label>();

        string testString = "The quick brown fox jumps over the lazy dog";

        public KeyTyperForm()
        {
            InitializeComponent();
            AddLabelToDict(this);
        }

        public void AddLabelToDict(Control control)
        {
            if (control is Label)
            {
                keyAndLabel.Add((Keys)control.Text[0], control as Label);
                Console.WriteLine((Keys)control.Text[0]);
            }
            else
            {
                foreach (Control child in control.Controls)
                {
                    AddLabelToDict(child);
                }

            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            for(var i = 0; i < textBox.Text.Length; i++) {
                if (textBox.Text[i].Equals(testString[i]))
                {
                    textBox.ForeColor = Color.Blue;
                }
                else
                {
                    textBox.ForeColor = Color.Red;
                }
            }
            if(textBox.Text.Length == testString.Length)
            {
                foreach(var x in keyAndLabel)
                {
                    x.Value.BackColor = Control.DefaultBackColor;
                }
                MessageBox.Show("Good Job");
                textBox.Text = "";
            }
            //newTextBox.Text = newTextBox.Text + testString.Substring(newTextBox.Text.Length);


        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //Console.WriteLine(e.KeyCode);

            if (keyAndLabel.ContainsKey(e.KeyCode))
            {
                keyAndLabel[e.KeyCode].BackColor = Color.Orange;
            } else if (e.KeyCode.Equals(Keys.Back))
            {
                TextBox textBox = sender as TextBox;
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                MessageBox.Show("Nope, live with it and get better.");
                 
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (keyAndLabel.ContainsKey(e.KeyCode))
            {
                keyAndLabel[e.KeyCode].BackColor = Control.DefaultBackColor;
            }
        }
    }
}
