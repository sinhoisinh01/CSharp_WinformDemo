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
        public MainForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //System.Threading.Thread.Sleep(1000);

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
    }
}
