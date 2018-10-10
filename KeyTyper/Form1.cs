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
