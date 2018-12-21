namespace BmiApp
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

    public partial class BmiForm : Form
    {
        public BmiForm()
        {
            InitializeComponent();

            // Init form
            InitComboboxUnitSystem();
        }

        private void InitComboboxUnitSystem()
        {
            string[] unitSystems = new string[] { "Metric", "U.S" };

            cmbUnitSystem.Items.AddRange(unitSystems);
            cmbUnitSystem.SelectedIndex = 0;
        }

        private void cmbUnitSystem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string unitSystem = cmbUnitSystem.SelectedItem.ToString();
            switch (unitSystem)
            {
                case "Metric":
                    lblHeightUnit.Text = "cm";
                    lblWeightUnit.Text = "kg";
                    break;
                case "U.S":
                    lblHeightUnit.Text = "inches";
                    lblWeightUnit.Text = "pounds";
                    break;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            float.TryParse(txtHeight.Text, out float height);
            float.TryParse(txtWeight.Text, out float weight);
            string unitSystem = cmbUnitSystem.SelectedItem.ToString();
            float bmiResult = 0;

            switch (unitSystem)
            {
                case "Metric":
                    bmiResult = BmiService.CalculateBmiMetric(weight, height);
                    break;
                case "U.S":
                    bmiResult = BmiService.CalculateBmiUs(weight, height);
                    break;
            }

            lblBmiResult.Text = bmiResult.ToString("0.#");
            lblBmiStatus.Text = BmiService.BmiStatus(bmiResult);
        }
    }
}
