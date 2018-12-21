namespace MathIsFunny
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblPoint = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.lblOperators = new System.Windows.Forms.Label();
            this.checkedListBoxOperators = new System.Windows.Forms.CheckedListBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelSideBar.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.btnPlay);
            this.panelHeader.Controls.Add(this.lblPoint);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(472, 92);
            this.panelHeader.TabIndex = 0;
            // 
            // lblPoint
            // 
            this.lblPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint.Location = new System.Drawing.Point(207, 9);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPoint.Size = new System.Drawing.Size(81, 30);
            this.lblPoint.TabIndex = 0;
            this.lblPoint.Text = "00/100";
            this.lblPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnPlay.BackColor = System.Drawing.Color.Yellow;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.Black;
            this.btnPlay.Location = new System.Drawing.Point(197, 42);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(104, 37);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Start";
            this.btnPlay.UseVisualStyleBackColor = false;
            // 
            // panelSideBar
            // 
            this.panelSideBar.Controls.Add(this.checkedListBoxOperators);
            this.panelSideBar.Controls.Add(this.lblOperators);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 92);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(162, 215);
            this.panelSideBar.TabIndex = 1;
            // 
            // lblOperators
            // 
            this.lblOperators.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOperators.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperators.Location = new System.Drawing.Point(0, 0);
            this.lblOperators.Name = "lblOperators";
            this.lblOperators.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblOperators.Size = new System.Drawing.Size(162, 31);
            this.lblOperators.TabIndex = 0;
            this.lblOperators.Text = "Operators";
            this.lblOperators.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkedListBoxOperators
            // 
            this.checkedListBoxOperators.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxOperators.FormattingEnabled = true;
            this.checkedListBoxOperators.Location = new System.Drawing.Point(0, 31);
            this.checkedListBoxOperators.Name = "checkedListBoxOperators";
            this.checkedListBoxOperators.Size = new System.Drawing.Size(162, 184);
            this.checkedListBoxOperators.TabIndex = 1;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.btnCheck);
            this.panelContent.Controls.Add(this.txtAnswer);
            this.panelContent.Controls.Add(this.lblQuestion);
            this.panelContent.Controls.Add(this.lblAnswer);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(162, 92);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(310, 215);
            this.panelContent.TabIndex = 2;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(0, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(310, 49);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "1 + 1 = ?";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnswer
            // 
            this.lblAnswer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(28, 62);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAnswer.Size = new System.Drawing.Size(111, 30);
            this.lblAnswer.TabIndex = 0;
            this.lblAnswer.Text = "Your Answer:";
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(145, 64);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(120, 26);
            this.txtAnswer.TabIndex = 1;
            // 
            // btnCheck
            // 
            this.btnCheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCheck.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.Black;
            this.btnCheck.Location = new System.Drawing.Point(72, 119);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(167, 37);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check Result";
            this.btnCheck.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 307);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSideBar);
            this.Controls.Add(this.panelHeader);
            this.Name = "Form1";
            this.Text = "Funny Math";
            this.panelHeader.ResumeLayout(false);
            this.panelSideBar.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.CheckedListBox checkedListBoxOperators;
        private System.Windows.Forms.Label lblOperators;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblAnswer;
    }
}

