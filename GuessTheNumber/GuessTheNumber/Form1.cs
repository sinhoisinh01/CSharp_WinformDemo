using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            bool isSuccessFrom = Int32.TryParse(txtFrom.Text, out int fromNumber);
            bool isSuccessTo = Int32.TryParse(txtTo.Text, out int toNumber);

            if (!isSuccessFrom || !isSuccessTo)
            {
                MessageBox.Show("Invalid Number");
            }

            Random random = new Random();
            int randNumber = random.Next(fromNumber, toNumber);

            lblNumber.Text = randNumber.ToString();
        }
    }
}
