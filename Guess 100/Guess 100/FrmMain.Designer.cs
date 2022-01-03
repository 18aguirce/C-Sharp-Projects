namespace Guess_100
{
    partial class frmMain
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
            this.lblDirections = new System.Windows.Forms.Label();
            this.lblHumanGuess = new System.Windows.Forms.Label();
            this.txtHumanGuess = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblCheck = new System.Windows.Forms.Label();
            this.txtTries = new System.Windows.Forms.TextBox();
            this.lblTries = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDirections
            // 
            this.lblDirections.Location = new System.Drawing.Point(12, 9);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(284, 61);
            this.lblDirections.TabIndex = 0;
            this.lblDirections.Text = "The computer has chosen a number between 1 - 100. Try guessing the number with as" +
    " less tries as possible.";
            // 
            // lblHumanGuess
            // 
            this.lblHumanGuess.AutoSize = true;
            this.lblHumanGuess.Location = new System.Drawing.Point(33, 76);
            this.lblHumanGuess.Name = "lblHumanGuess";
            this.lblHumanGuess.Size = new System.Drawing.Size(87, 17);
            this.lblHumanGuess.TabIndex = 1;
            this.lblHumanGuess.Text = "Your Guess:";
            // 
            // txtHumanGuess
            // 
            this.txtHumanGuess.Location = new System.Drawing.Point(126, 73);
            this.txtHumanGuess.Name = "txtHumanGuess";
            this.txtHumanGuess.Size = new System.Drawing.Size(49, 22);
            this.txtHumanGuess.TabIndex = 3;
            this.txtHumanGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(181, 69);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(94, 30);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.Location = new System.Drawing.Point(33, 115);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(46, 17);
            this.lblCheck.TabIndex = 4;
            this.lblCheck.Text = "label1";
            // 
            // txtTries
            // 
            this.txtTries.Enabled = false;
            this.txtTries.Location = new System.Drawing.Point(36, 135);
            this.txtTries.Name = "txtTries";
            this.txtTries.Size = new System.Drawing.Size(52, 22);
            this.txtTries.TabIndex = 5;
            this.txtTries.TabStop = false;
            this.txtTries.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTries
            // 
            this.lblTries.AutoSize = true;
            this.lblTries.Location = new System.Drawing.Point(94, 138);
            this.lblTries.Name = "lblTries";
            this.lblTries.Size = new System.Drawing.Size(40, 17);
            this.lblTries.TabIndex = 6;
            this.lblTries.Text = "Tries";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(36, 181);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(111, 30);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset Game";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnCheck;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 232);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblTries);
            this.Controls.Add(this.txtTries);
            this.Controls.Add(this.lblCheck);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtHumanGuess);
            this.Controls.Add(this.lblHumanGuess);
            this.Controls.Add(this.lblDirections);
            this.Name = "frmMain";
            this.Text = "Guess 100";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDirections;
        private System.Windows.Forms.Label lblHumanGuess;
        private System.Windows.Forms.TextBox txtHumanGuess;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.TextBox txtTries;
        private System.Windows.Forms.Label lblTries;
        private System.Windows.Forms.Button btnReset;
    }
}

