using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class MainForm : Form
    {
        public string PlayerName { get; set; }
        public int PlayerScore { get; set; }
        public int GameMode { get; set; }

        private MathQuizService mathQuizService;

        public MainForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1000);

            int time = Int32.Parse(lblTimer.Text);
            time--;
            lblTimer.Text = time.ToString();
            if (time == 0)
            {
                timer1.Stop();
                ResultForm resultForm = new ResultForm();
                this.Hide();
                resultForm.Show();
            }
        }

        public void StartGame()
        {
            mathQuizService = new MathQuizService(GameMode, PlayerName);
            PlayerScore = 0;
            lblScore.Text = $"Score: {PlayerScore.ToString()}";
            newQuiz();
            timer1.Start();
        }

        private void newQuiz()
        {
            mathQuizService.GenerateQuiz();
            lblQuiz.Text = $"{mathQuizService.FirstNumber} {mathQuizService.GetOperatorSymbol()} {mathQuizService.SecondNumber} =";
            txtResult.Text = string.Empty;
        }

        private void checkScore()
        {
            Int32.TryParse(txtResult.Text, out int userResult);
            if (mathQuizService.CheckUserResult(userResult))
            {
                PlayerScore += 10;
                lblScore.Text = $"Score: {PlayerScore.ToString()}";
            }
        }

        private void txtResult_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            if (char.IsControl(e.KeyChar) && (e.KeyChar == (char)13 || e.KeyChar == (char)17 || e.KeyChar == (char)8))
            {
                e.Handled = false;

                bool parseSuccess = Int32.TryParse(txtResult.Text, out int result);
                if (parseSuccess && e.KeyChar == (char)13)
                {
                    checkScore();
                    newQuiz();
                }
            }
        }
    }
}
