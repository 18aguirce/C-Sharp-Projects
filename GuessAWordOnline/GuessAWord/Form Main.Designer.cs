namespace GuessAWord
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.lblHiddenWord = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLetterGuess = new System.Windows.Forms.TextBox();
            this.txtNumTries = new System.Windows.Forms.TextBox();
            this.lblUsedLetters = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.chkSound = new System.Windows.Forms.CheckBox();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblDefinition = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHiddenWord
            // 
            this.lblHiddenWord.AutoSize = true;
            this.lblHiddenWord.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHiddenWord.Location = new System.Drawing.Point(15, 60);
            this.lblHiddenWord.Name = "lblHiddenWord";
            this.lblHiddenWord.Size = new System.Drawing.Size(142, 23);
            this.lblHiddenWord.TabIndex = 0;
            this.lblHiddenWord.Text = "Hidden Word";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Guess a letter:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of tries:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Letters used:";
            // 
            // txtLetterGuess
            // 
            this.txtLetterGuess.Location = new System.Drawing.Point(131, 107);
            this.txtLetterGuess.Name = "txtLetterGuess";
            this.txtLetterGuess.Size = new System.Drawing.Size(63, 22);
            this.txtLetterGuess.TabIndex = 4;
            // 
            // txtNumTries
            // 
            this.txtNumTries.Location = new System.Drawing.Point(131, 151);
            this.txtNumTries.Name = "txtNumTries";
            this.txtNumTries.ReadOnly = true;
            this.txtNumTries.Size = new System.Drawing.Size(63, 22);
            this.txtNumTries.TabIndex = 5;
            this.txtNumTries.TabStop = false;
            // 
            // lblUsedLetters
            // 
            this.lblUsedLetters.AutoSize = true;
            this.lblUsedLetters.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsedLetters.Location = new System.Drawing.Point(127, 198);
            this.lblUsedLetters.Name = "lblUsedLetters";
            this.lblUsedLetters.Size = new System.Drawing.Size(106, 23);
            this.lblUsedLetters.TabIndex = 6;
            this.lblUsedLetters.Text = "abcdefgh";
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(230, 98);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(91, 35);
            this.btnGuess.TabIndex = 7;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.BtnGuess_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Location = new System.Drawing.Point(345, 98);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(91, 35);
            this.btnPlayAgain.TabIndex = 8;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.BtnPlayAgain_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(212, 154);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(115, 18);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Status message";
            // 
            // chkSound
            // 
            this.chkSound.AutoSize = true;
            this.chkSound.Location = new System.Drawing.Point(492, 106);
            this.chkSound.Name = "chkSound";
            this.chkSound.Size = new System.Drawing.Size(118, 21);
            this.chkSound.TabIndex = 10;
            this.chkSound.Text = "Sound Effects";
            this.chkSound.UseVisualStyleBackColor = true;
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(131, 17);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(146, 22);
            this.txtPlayerName.TabIndex = 12;
            this.txtPlayerName.TabStop = false;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(16, 20);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(93, 17);
            this.lblPlayerName.TabIndex = 11;
            this.lblPlayerName.Text = "Player Name:";
            // 
            // tmrTimer
            // 
            this.tmrTimer.Enabled = true;
            this.tmrTimer.Interval = 1000;
            this.tmrTimer.Tick += new System.EventHandler(this.tmrTimer_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(319, 20);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(52, 17);
            this.lblTimer.TabIndex = 13;
            this.lblTimer.Text = "Timer: ";
            // 
            // lblDefinition
            // 
            this.lblDefinition.AllowDrop = true;
            this.lblDefinition.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDefinition.Location = new System.Drawing.Point(16, 231);
            this.lblDefinition.Name = "lblDefinition";
            this.lblDefinition.Size = new System.Drawing.Size(594, 227);
            this.lblDefinition.TabIndex = 14;
            this.lblDefinition.Text = "Definition: ";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 467);
            this.Controls.Add(this.lblDefinition);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.chkSound);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.lblUsedLetters);
            this.Controls.Add(this.txtNumTries);
            this.Controls.Add(this.txtLetterGuess);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHiddenWord);
            this.Name = "FrmMain";
            this.Text = "Guess a Word";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHiddenWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLetterGuess;
        private System.Windows.Forms.TextBox txtNumTries;
        private System.Windows.Forms.Label lblUsedLetters;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox chkSound;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Timer tmrTimer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblDefinition;
    }
}

