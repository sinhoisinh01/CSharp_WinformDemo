namespace BmiApp
{
    partial class BmiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblHeightUnit = new System.Windows.Forms.Label();
            this.lblWeightUnit = new System.Windows.Forms.Label();
            this.cmbUnitSystem = new System.Windows.Forms.ComboBox();
            this.lblUnitSystem = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblBmi = new System.Windows.Forms.Label();
            this.lblBmiResult = new System.Windows.Forms.Label();
            this.lblBmiStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(44, 29);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(80, 25);
            this.lblHeight.TabIndex = 0;
            this.lblHeight.Text = "Height:";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(44, 92);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(85, 25);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "Weight:";
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(140, 26);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(118, 31);
            this.txtHeight.TabIndex = 2;
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(140, 89);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(118, 31);
            this.txtWeight.TabIndex = 2;
            // 
            // lblHeightUnit
            // 
            this.lblHeightUnit.AutoSize = true;
            this.lblHeightUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeightUnit.Location = new System.Drawing.Point(264, 29);
            this.lblHeightUnit.Name = "lblHeightUnit";
            this.lblHeightUnit.Size = new System.Drawing.Size(40, 25);
            this.lblHeightUnit.TabIndex = 0;
            this.lblHeightUnit.Text = "cm";
            // 
            // lblWeightUnit
            // 
            this.lblWeightUnit.AutoSize = true;
            this.lblWeightUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeightUnit.Location = new System.Drawing.Point(264, 92);
            this.lblWeightUnit.Name = "lblWeightUnit";
            this.lblWeightUnit.Size = new System.Drawing.Size(35, 25);
            this.lblWeightUnit.TabIndex = 0;
            this.lblWeightUnit.Text = "kg";
            // 
            // cmbUnitSystem
            // 
            this.cmbUnitSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnitSystem.FormattingEnabled = true;
            this.cmbUnitSystem.Location = new System.Drawing.Point(140, 143);
            this.cmbUnitSystem.Name = "cmbUnitSystem";
            this.cmbUnitSystem.Size = new System.Drawing.Size(159, 33);
            this.cmbUnitSystem.TabIndex = 3;
            this.cmbUnitSystem.SelectedIndexChanged += new System.EventHandler(this.cmbUnitSystem_SelectedIndexChanged);
            // 
            // lblUnitSystem
            // 
            this.lblUnitSystem.AutoSize = true;
            this.lblUnitSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitSystem.Location = new System.Drawing.Point(44, 146);
            this.lblUnitSystem.Name = "lblUnitSystem";
            this.lblUnitSystem.Size = new System.Drawing.Size(56, 25);
            this.lblUnitSystem.TabIndex = 1;
            this.lblUnitSystem.Text = "Unit:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Azure;
            this.btnCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.Black;
            this.btnCalculate.Location = new System.Drawing.Point(49, 205);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(250, 36);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblBmi
            // 
            this.lblBmi.AutoSize = true;
            this.lblBmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBmi.Location = new System.Drawing.Point(117, 271);
            this.lblBmi.Name = "lblBmi";
            this.lblBmi.Size = new System.Drawing.Size(55, 25);
            this.lblBmi.TabIndex = 1;
            this.lblBmi.Text = "BMI:";
            // 
            // lblBmiResult
            // 
            this.lblBmiResult.AutoSize = true;
            this.lblBmiResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBmiResult.Location = new System.Drawing.Point(178, 271);
            this.lblBmiResult.Name = "lblBmiResult";
            this.lblBmiResult.Size = new System.Drawing.Size(48, 25);
            this.lblBmiResult.TabIndex = 1;
            this.lblBmiResult.Text = "100";
            // 
            // lblBmiStatus
            // 
            this.lblBmiStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBmiStatus.Location = new System.Drawing.Point(49, 305);
            this.lblBmiStatus.Name = "lblBmiStatus";
            this.lblBmiStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBmiStatus.Size = new System.Drawing.Size(250, 38);
            this.lblBmiStatus.TabIndex = 1;
            this.lblBmiStatus.Text = "Obesity (Class 3)";
            this.lblBmiStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BmiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 382);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cmbUnitSystem);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblBmiStatus);
            this.Controls.Add(this.lblBmiResult);
            this.Controls.Add(this.lblBmi);
            this.Controls.Add(this.lblUnitSystem);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblWeightUnit);
            this.Controls.Add(this.lblHeightUnit);
            this.Controls.Add(this.lblHeight);
            this.Name = "BmiForm";
            this.Text = "BMI Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblHeightUnit;
        private System.Windows.Forms.Label lblWeightUnit;
        private System.Windows.Forms.ComboBox cmbUnitSystem;
        private System.Windows.Forms.Label lblUnitSystem;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblBmi;
        private System.Windows.Forms.Label lblBmiResult;
        private System.Windows.Forms.Label lblBmiStatus;
    }
}

