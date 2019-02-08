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
    public partial class ResultForm : Form
    {
        public string PlayerName { get; set; }
        public int PlayerScore { get; set; }

        public ResultForm()
        {
            InitializeComponent();
        }

        private void btnTryAgain_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();

            mainForm.Show();
            mainForm.StartGame();
            this.Hide();
        }

        private void ResultForm_Activated(object sender, EventArgs e)
        {
            lblYourScore.Text = $"Your Score: {PlayerScore.ToString()}";
        }
    }
}
