using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumber
{
    public partial class Form1 : Form
    {
        private const int MAX_GUESS = 8;

        private int numberToGuess;
        private Random random;
        private int guessNo;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            lblDescription.Text = $"We have a number from {txtMin.Text} to {txtMax.Text}. Guess it !!!";

            int min = Int32.Parse(txtMin.Text);
            int max = Int32.Parse(txtMax.Text);

            numberToGuess = random.Next(min, max);

            btnStartGame.Text = "Restart";

            guessNo = 1;

            lblYourGuess.Text = $"Your guess ({guessNo}/{MAX_GUESS}):";

            lblResult.Text = String.Empty;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            guessNo++;
            if (guessNo <= MAX_GUESS)
            {
                lblYourGuess.Text = $"Your guess ({guessNo}/{MAX_GUESS}):";

                int userGuess = Int32.Parse(txtUserGuess.Text);

                if (userGuess < numberToGuess)
                {
                    lblResult.Text = "Your number is less than my number";
                }
                else if (userGuess > numberToGuess)
                {
                    lblResult.Text = "Your number is greater than my number";
                }
                else
                {
                    lblResult.Text = "Congratulation !!!";
                }
            }
            else
            {
                lblResult.Text = "Game Over !!!";
            }
        }
    }
}
