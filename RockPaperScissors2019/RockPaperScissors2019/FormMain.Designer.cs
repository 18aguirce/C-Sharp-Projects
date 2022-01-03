namespace RockPaperScissors2019
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
            this.btnRock = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.lblHumanChose = new System.Windows.Forms.Label();
            this.lblComputerChose = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblHumanScore = new System.Windows.Forms.Label();
            this.txtHumanScore = new System.Windows.Forms.TextBox();
            this.lblComputerScore = new System.Windows.Forms.Label();
            this.lblTieScore = new System.Windows.Forms.Label();
            this.txtComputerScore = new System.Windows.Forms.TextBox();
            this.txtTieScore = new System.Windows.Forms.TextBox();
            this.picboxHumanChoice = new System.Windows.Forms.PictureBox();
            this.picboxComputerChoice = new System.Windows.Forms.PictureBox();
            this.lblHumanPic = new System.Windows.Forms.Label();
            this.lblComputerPic = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxHumanChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxComputerChoice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.Location = new System.Drawing.Point(12, 12);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(120, 52);
            this.btnRock.TabIndex = 0;
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.BtnRock_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.Location = new System.Drawing.Point(264, 12);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(120, 52);
            this.btnScissors.TabIndex = 2;
            this.btnScissors.Text = "Scissors";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.BtnScissors_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Location = new System.Drawing.Point(138, 12);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(120, 52);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.BtnPaper_Click);
            // 
            // lblHumanChose
            // 
            this.lblHumanChose.AutoSize = true;
            this.lblHumanChose.Location = new System.Drawing.Point(202, 75);
            this.lblHumanChose.Name = "lblHumanChose";
            this.lblHumanChose.Size = new System.Drawing.Size(71, 16);
            this.lblHumanChose.TabIndex = 5;
            this.lblHumanChose.Text = "You chose";
            // 
            // lblComputerChose
            // 
            this.lblComputerChose.AutoSize = true;
            this.lblComputerChose.Location = new System.Drawing.Point(202, 102);
            this.lblComputerChose.Name = "lblComputerChose";
            this.lblComputerChose.Size = new System.Drawing.Size(105, 16);
            this.lblComputerChose.TabIndex = 6;
            this.lblComputerChose.Text = "Computer chose";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(202, 128);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(45, 16);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Result";
            // 
            // lblHumanScore
            // 
            this.lblHumanScore.AutoSize = true;
            this.lblHumanScore.Location = new System.Drawing.Point(8, 74);
            this.lblHumanScore.Name = "lblHumanScore";
            this.lblHumanScore.Size = new System.Drawing.Size(74, 16);
            this.lblHumanScore.TabIndex = 8;
            this.lblHumanScore.Text = "Your Score";
            // 
            // txtHumanScore
            // 
            this.txtHumanScore.Location = new System.Drawing.Point(120, 74);
            this.txtHumanScore.Name = "txtHumanScore";
            this.txtHumanScore.ReadOnly = true;
            this.txtHumanScore.Size = new System.Drawing.Size(76, 22);
            this.txtHumanScore.TabIndex = 9;
            this.txtHumanScore.TabStop = false;
            // 
            // lblComputerScore
            // 
            this.lblComputerScore.AutoSize = true;
            this.lblComputerScore.Location = new System.Drawing.Point(8, 102);
            this.lblComputerScore.Name = "lblComputerScore";
            this.lblComputerScore.Size = new System.Drawing.Size(104, 16);
            this.lblComputerScore.TabIndex = 10;
            this.lblComputerScore.Text = "Computer Score";
            // 
            // lblTieScore
            // 
            this.lblTieScore.AutoSize = true;
            this.lblTieScore.Location = new System.Drawing.Point(8, 130);
            this.lblTieScore.Name = "lblTieScore";
            this.lblTieScore.Size = new System.Drawing.Size(66, 16);
            this.lblTieScore.TabIndex = 11;
            this.lblTieScore.Text = "Tie Score";
            // 
            // txtComputerScore
            // 
            this.txtComputerScore.Location = new System.Drawing.Point(120, 102);
            this.txtComputerScore.Name = "txtComputerScore";
            this.txtComputerScore.ReadOnly = true;
            this.txtComputerScore.Size = new System.Drawing.Size(76, 22);
            this.txtComputerScore.TabIndex = 12;
            this.txtComputerScore.TabStop = false;
            // 
            // txtTieScore
            // 
            this.txtTieScore.Location = new System.Drawing.Point(120, 130);
            this.txtTieScore.Name = "txtTieScore";
            this.txtTieScore.ReadOnly = true;
            this.txtTieScore.Size = new System.Drawing.Size(76, 22);
            this.txtTieScore.TabIndex = 13;
            this.txtTieScore.TabStop = false;
            // 
            // picboxHumanChoice
            // 
            this.picboxHumanChoice.InitialImage = null;
            this.picboxHumanChoice.Location = new System.Drawing.Point(84, 187);
            this.picboxHumanChoice.Name = "picboxHumanChoice";
            this.picboxHumanChoice.Size = new System.Drawing.Size(100, 100);
            this.picboxHumanChoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxHumanChoice.TabIndex = 14;
            this.picboxHumanChoice.TabStop = false;
            // 
            // picboxComputerChoice
            // 
            this.picboxComputerChoice.InitialImage = null;
            this.picboxComputerChoice.Location = new System.Drawing.Point(199, 187);
            this.picboxComputerChoice.Name = "picboxComputerChoice";
            this.picboxComputerChoice.Size = new System.Drawing.Size(100, 100);
            this.picboxComputerChoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxComputerChoice.TabIndex = 15;
            this.picboxComputerChoice.TabStop = false;
            // 
            // lblHumanPic
            // 
            this.lblHumanPic.AutoSize = true;
            this.lblHumanPic.Location = new System.Drawing.Point(117, 167);
            this.lblHumanPic.Name = "lblHumanPic";
            this.lblHumanPic.Size = new System.Drawing.Size(31, 16);
            this.lblHumanPic.TabIndex = 16;
            this.lblHumanPic.Text = "You";
            // 
            // lblComputerPic
            // 
            this.lblComputerPic.AutoSize = true;
            this.lblComputerPic.Location = new System.Drawing.Point(215, 167);
            this.lblComputerPic.Name = "lblComputerPic";
            this.lblComputerPic.Size = new System.Drawing.Size(65, 16);
            this.lblComputerPic.TabIndex = 17;
            this.lblComputerPic.Text = "Computer";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 299);
            this.Controls.Add(this.lblComputerPic);
            this.Controls.Add(this.lblHumanPic);
            this.Controls.Add(this.picboxComputerChoice);
            this.Controls.Add(this.picboxHumanChoice);
            this.Controls.Add(this.txtTieScore);
            this.Controls.Add(this.txtComputerScore);
            this.Controls.Add(this.lblTieScore);
            this.Controls.Add(this.lblComputerScore);
            this.Controls.Add(this.txtHumanScore);
            this.Controls.Add(this.lblHumanScore);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblComputerChose);
            this.Controls.Add(this.lblHumanChose);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnRock);
            this.Name = "frmMain";
            this.Text = "Rock Paper Scissors";
            this.Load += new System.EventHandler(this.RockPaperScissors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxHumanChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxComputerChoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Label lblHumanChose;
        private System.Windows.Forms.Label lblComputerChose;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblHumanScore;
        private System.Windows.Forms.TextBox txtHumanScore;
        private System.Windows.Forms.Label lblComputerScore;
        private System.Windows.Forms.Label lblTieScore;
        private System.Windows.Forms.TextBox txtComputerScore;
        private System.Windows.Forms.TextBox txtTieScore;
        private System.Windows.Forms.PictureBox picboxHumanChoice;
        private System.Windows.Forms.PictureBox picboxComputerChoice;
        private System.Windows.Forms.Label lblHumanPic;
        private System.Windows.Forms.Label lblComputerPic;
    }
}

