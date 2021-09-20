using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGuesser
{
    public partial class WordPrompt : Form
    {
        public WordPrompt()
        {
            InitializeComponent();
        }

        public event EventHandler<string> returnWord;

        protected virtual void OnreturnWord()
        {
            if (returnWord != null)
                returnWord(this, wordBox.Text.Trim().ToUpper());
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (!wordBox.Text.Trim().Contains(" ") && wordBox.Text.Trim().Length <= 20)
            {
                OnreturnWord();
                Dispose();
                Close();
            }
            else
                MessageBox.Show("must be 1 word and 20 or less Characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
