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
        private Button[] letter;
        private Button[] life;
        private int LETTERS = 26;

        private int LIFE;
        private int correctGuess;
        private int lifeIndex;
        private int letterToGuess;

        private string correctWord;
        private char[] wordArr;
        private char[] wordTempArr;                

        public MainForm()
        {
            InitializeComponent();
            start();
        }
        private void wordAction(object sender, string word)
        {
            correctWord = word;
            wordArr = word.ToArray();

            char[] temp = word.ToArray();
            string wordTemp = "";

            IList<int> list = new List<int>();
            int lettersToHide = (int) Math.Ceiling(word.Length * 0.5);

            Random ran = new Random();

            int counter = 0;
            int max = 100;
            while (list.Count() <= lettersToHide && counter <= max)
            {
                ++counter;
                int numTemp = ran.Next(0, word.Length);
                if (!list.Contains(numTemp) && !list.Contains(numTemp + 1) && !list.Contains(numTemp - 1))                
                    list.Add(numTemp);                
            }                 

            for(int i = 0; i < list.Count; ++i)
            {
               for(int j = 0; j < word.Length; ++j)
               {
                    if(list[i] == j)
                    {
                        temp[j] = '_';                        
                    }
               }                
            }
            for (int i = 0; i < word.Length; ++i)
                wordTemp += temp[i];
            
            wordLbl.Text = wordTemp;
            wordTempArr = temp;
            letterToGuess = list.Count;
        }
        private void letterAction(object sender, EventArgs e)
        {
            string name = ((Button)sender).Name;            

            if(LIFE <=  5 && LIFE > 0)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show($"Are you sure you want to choose {name}", "Warning", buttons, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    bool correct = false;
                    for(int i = 0; i < wordArr.Length; ++i)
                    {
                        
                        if (wordArr[i].Equals(name[0]) && wordTempArr[i] == '_')
                        {                            
                            wordTempArr[i] = wordArr[i];
                            wordLbl.Text = "";
                            
                            for (int j = 0; j < wordTempArr.Length; ++j)
                                wordLbl.Text += wordTempArr[j];

                            correct = true;
                            ++correctGuess;
                            //break;
                        }
                    }   
                    if(!correct)
                    {
                        life[lifeIndex--].BackColor = Color.Maroon;
                        --LIFE;
                        lifeLbl.Text = $"{LIFE}/5";
                    }
                }
            }
            if (correctGuess == letterToGuess)
            {
                MessageBox.Show("EZ BITCH", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();                
            }
            if(LIFE == 0)
            {               
                MessageBox.Show($"GAME OVER \nCorrect answer is:\n{correctWord}", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reset();
            }
        }        

        private void reset()
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show($"Restart Game ?", "Warning", buttons, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                start();
            }
            else            
                Close();            
        }
        private void start()
        {
            LIFE = 5;
            correctGuess = 0;
            lifeIndex = 4;
            letterToGuess = 0;            

            letter = new Button[LETTERS];
            life = new Button[LIFE];

            WordPrompt wp = new WordPrompt();
            wp.returnWord += wordAction;            
            wp.ShowDialog();

            lettersPanel.Controls.Clear();
            lifePanel.Controls.Clear();

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
            for (int i = 0; i < LIFE; ++i)
            {
                life[i] = new Button();
                life[i].Name = i.ToString();
                setLifeButton(ref life[i]);
                lifePanel.Controls.Add(life[i]);
            }
            lifeLbl.Text = "5/5";
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

