using System;
using System.IO;
using System.Windows.Forms;

namespace KeyTyper
{
    public partial class AddPhraseForm : Form
    {
        public AddPhraseForm()
        {
            InitializeComponent();
            addPhraseBtn.Enabled = false;
        }

        private void Done_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private void PhraseBox_Click(object sender, EventArgs e)
        {
            if (phraseBox.Text.Equals("Add your type phrase here.")){ 
                phraseBox.Text = "";
                addPhraseBtn.Enabled = true;
            }
        }

        private void PhraseBox_TextChanged(object sender, EventArgs e)
        {
            if (phraseBox.Text.Equals("")){
                addPhraseBtn.Enabled = true;
            }
        }
    }
}
