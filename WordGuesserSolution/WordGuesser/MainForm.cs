using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGuesser
{
    public partial class MainForm : Form
    {        
        private int LIFE = 5;
        private int LETTERS = 26;
        private string word;

        public MainForm()
        {
            InitializeComponent();
            
            Button[] letter = new Button[LETTERS];
            Button[] life = new Button[LIFE];

            WordPrompt wp = new WordPrompt();
            wp.returnWord += wordAction;
            wp.ShowDialog();

            // SET LETTERS
            for (int i = 0; i < LETTERS; ++i)
            {
                string name = ((char)(i + 65)).ToString();
                letter[i] = new Button();
                letter[i].Name = name;
                letter[i].Text = name;
                letter[i].Click += letterAction;
                setLetterButton(ref letter[i]);
                lettersPanel.Controls.Add(letter[i]);                                
            }            
            // SET LIFE
            for(int i = 0; i < LIFE; ++i)
            {
                life[i] = new Button();
                life[i].Name = i.ToString();
                setLifeButton(ref life[i]);
                lifePanel.Controls.Add(life[i]);
            }
        }
        private void wordAction(object sender, string e)
        {
            wordLbl.Text = e;
        }

        private void letterAction(object sender, EventArgs e)
        {
            
        }        

        private void setLetterButton(ref Button btn)
        {
            btn.Size = new Size(40, 40);
            btn.Margin = new Padding(5);
            btn.ForeColor = Color.FromArgb(64, 0, 0);
            btn.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = Color.Peru;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = Color.FromArgb(128, 64, 0);            
        }
        private void setLifeButton(ref Button btn)
        {
            btn.Size = new Size(40, 40);
            btn.Margin = new Padding(5);
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = Color.ForestGreen;
            btn.FlatAppearance.BorderSize = 0;            
        }

    }
}
