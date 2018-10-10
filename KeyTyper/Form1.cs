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

namespace KeyTypper
{
    public partial class Form1 : Form
    {
        private Dictionary<Keys, Label> keyAndLabel = new Dictionary<Keys, Label>();

        string testString = "The quick brown fox jumps over the lazy dog";

        public Form1()
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
            TextBox newTextBox = sender as TextBox;

            for(var i = 0; i < newTextBox.Text.Length; i++) {
                if (newTextBox.Text[i].Equals(testString[i]))
                {
                    newTextBox.ForeColor = Color.Blue;
                }
                else
                {
                    newTextBox.ForeColor = Color.Red;
                }
            }
            if(newTextBox.Text.Length == testString.Length)
            {
                foreach(var x in keyAndLabel)
                {
                    x.Value.BackColor = Control.DefaultBackColor;
                }
                MessageBox.Show("Good Job");
                newTextBox.Text = "";
            }
            //newTextBox.Text = newTextBox.Text + testString.Substring(newTextBox.Text.Length);


        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (keyAndLabel.ContainsKey(e.KeyCode))
            {
                keyAndLabel[e.KeyCode].BackColor = Color.Orange;
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
