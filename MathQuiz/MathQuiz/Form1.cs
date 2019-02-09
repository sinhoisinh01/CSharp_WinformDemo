namespace MathQuiz
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Model;
    using Service;

    public partial class Form1 : Form
    {
        private GameModeItem[] gameModes;

        public Form1()
        {
            InitializeComponent();
            InitComboboxGameMode();
        }

        private void InitComboboxGameMode()
        {
            gameModes = new GameModeItem[] {
                new GameModeItem() {
                   Text = "Easy (<30)",
                   Value = MathQuizService.Easy
                },
                new GameModeItem() {
                   Text = "Normal (<100)",
                   Value = MathQuizService.Normal
                },
                new GameModeItem() {
                   Text = "Hard (<1000)",
                   Value = MathQuizService.Hard
                },
                new GameModeItem() {
                   Text = "Alber Enstein (<10000)",
                   Value = MathQuizService.Expert
                }
            };

            cmbGameMode.Items.AddRange(gameModes);
            cmbGameMode.SelectedIndex = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //MainForm mainForm = new MainForm();
            //mainForm.PlayerName = txtPlayerName.Text;
            //mainForm.GameMode = gameModes[cmbGameMode.SelectedIndex].Value;
            //mainForm.Show();
            //mainForm.StartGame();
            //this.Hide();

            MainForm main = new MainForm();
            main.Show();
            main.PlayerName = txtPlayerName.Text;
            main.GameMode = gameModes[cmbGameMode.SelectedIndex].Value;
            this.Hide();
        }
    }
}
