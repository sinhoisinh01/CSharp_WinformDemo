namespace GuessNumber
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblYourGuess = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtUserGuess = new System.Windows.Forms.TextBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.lblMax = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblYourGuess);
            this.panel1.Controls.Add(this.btnCheck);
            this.panel1.Controls.Add(this.lblResult);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.txtUserGuess);
            this.panel1.Controls.Add(this.btnStartGame);
            this.panel1.Controls.Add(this.txtMax);
            this.panel1.Controls.Add(this.lblMax);
            this.panel1.Controls.Add(this.txtMin);
            this.panel1.Controls.Add(this.lblMin);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 384);
            this.panel1.TabIndex = 1;
            // 
            // lblYourGuess
            // 
            this.lblYourGuess.AutoSize = true;
            this.lblYourGuess.Location = new System.Drawing.Point(150, 191);
            this.lblYourGuess.Name = "lblYourGuess";
            this.lblYourGuess.Size = new System.Drawing.Size(179, 26);
            this.lblYourGuess.TabIndex = 7;
            this.lblYourGuess.Text = "Your guess (1/6):";
            // 
            // btnCheck
            // 
            this.btnCheck.Enabled = false;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCheck.Location = new System.Drawing.Point(233, 245);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(151, 37);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(31, 304);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(559, 35);
            this.lblResult.TabIndex = 5;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(31, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 35);
            this.label1.TabIndex = 5;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(31, 126);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(559, 35);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Press Start Button";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUserGuess
            // 
            this.txtUserGuess.Enabled = false;
            this.txtUserGuess.Location = new System.Drawing.Point(335, 188);
            this.txtUserGuess.Name = "txtUserGuess";
            this.txtUserGuess.Size = new System.Drawing.Size(100, 32);
            this.txtUserGuess.TabIndex = 0;
            this.txtUserGuess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserGuess_KeyPress);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(212, 64);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(195, 46);
            this.btnStartGame.TabIndex = 4;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(388, 15);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(100, 32);
            this.txtMax.TabIndex = 3;
            this.txtMax.Text = "10000";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(330, 15);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(65, 26);
            this.lblMax.TabIndex = 2;
            this.lblMax.Text = "Max: ";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(187, 12);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(100, 32);
            this.txtMin.TabIndex = 1;
            this.txtMin.Text = "1";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(120, 15);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(59, 26);
            this.lblMin.TabIndex = 0;
            this.lblMin.Text = "Min: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 414);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblYourGuess;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtUserGuess;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label1;
    }
}

