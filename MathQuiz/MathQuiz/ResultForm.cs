namespace MathQuiz
{
    using System;
    using System.Windows.Forms;
    using Service;

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

            HighScoreFileService.GetHighScoreItemList();
            HighScoreFileService.AddHighScoreItemToFile(new Model.HighScoreItem() { PlayerName = "Sinh 1", PlayerScore = 500 });
        }
    }
}
