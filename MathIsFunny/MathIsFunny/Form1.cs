namespace MathIsFunny
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
    using Service;

    public partial class Form1 : Form
    {
        private FunnyMathService funnyMathService;

        public Form1()
        {
            InitializeComponent();
            InitCheckboxList();

            funnyMathService = new FunnyMathService();
        }

        private void InitCheckboxList()
        {
            string[] operators = { "Select All",
                FunnyMathService.GetOperatorName(FunnyMathService.Addition),
                FunnyMathService.GetOperatorName(FunnyMathService.Subtraction),
                FunnyMathService.GetOperatorName(FunnyMathService.Multiplication),
                FunnyMathService.GetOperatorName(FunnyMathService.Division)
            };
            chkListOperators.Items.AddRange(operators);
        }

        private void chkListOperators_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index == 0)
            {
                for (int i = 1; i < chkListOperators.Items.Count; i++)
                {
                    chkListOperators.SetItemChecked(i, value: e.NewValue == CheckState.Checked);
                }
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnPlay.Text = "Play Again";
            lblPoint.Text = "00/100";

            bool hasAddition = chkListOperators.GetItemChecked(FunnyMathService.Addition);
            bool hasSubtraction = chkListOperators.GetItemChecked(FunnyMathService.Subtraction);
            bool hasMultiplication = chkListOperators.GetItemChecked(FunnyMathService.Multiplication);
            bool hasDivision = chkListOperators.GetItemChecked(FunnyMathService.Division);

            lblQuestion.Text = funnyMathService.GenerateMathQuestion(hasAddition, hasSubtraction, hasMultiplication, hasDivision);
        }
    }
}
