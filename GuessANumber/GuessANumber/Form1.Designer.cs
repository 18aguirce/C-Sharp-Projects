namespace GuessANumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rbtnOne = new System.Windows.Forms.RadioButton();
            this.rbtnTwo = new System.Windows.Forms.RadioButton();
            this.rbtnThree = new System.Windows.Forms.RadioButton();
            this.rbtnFour = new System.Windows.Forms.RadioButton();
            this.rbtnFive = new System.Windows.Forms.RadioButton();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.lblHint = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbtnOne
            // 
            resources.ApplyResources(this.rbtnOne, "rbtnOne");
            this.rbtnOne.Name = "rbtnOne";
            this.rbtnOne.UseVisualStyleBackColor = true;
            this.rbtnOne.CheckedChanged += new System.EventHandler(this.rbtnOne_CheckedChanged);
            // 
            // rbtnTwo
            // 
            resources.ApplyResources(this.rbtnTwo, "rbtnTwo");
            this.rbtnTwo.Name = "rbtnTwo";
            this.rbtnTwo.UseVisualStyleBackColor = true;
            this.rbtnTwo.CheckedChanged += new System.EventHandler(this.rbtnTwo_CheckedChanged);
            // 
            // rbtnThree
            // 
            resources.ApplyResources(this.rbtnThree, "rbtnThree");
            this.rbtnThree.Name = "rbtnThree";
            this.rbtnThree.UseVisualStyleBackColor = true;
            this.rbtnThree.CheckedChanged += new System.EventHandler(this.rbtnThree_CheckedChanged);
            // 
            // rbtnFour
            // 
            resources.ApplyResources(this.rbtnFour, "rbtnFour");
            this.rbtnFour.Name = "rbtnFour";
            this.rbtnFour.UseVisualStyleBackColor = true;
            this.rbtnFour.CheckedChanged += new System.EventHandler(this.rbtnFour_CheckedChanged);
            // 
            // rbtnFive
            // 
            resources.ApplyResources(this.rbtnFive, "rbtnFive");
            this.rbtnFive.Name = "rbtnFive";
            this.rbtnFive.UseVisualStyleBackColor = true;
            this.rbtnFive.CheckedChanged += new System.EventHandler(this.rbtnFive_CheckedChanged);
            // 
            // lblDesc
            // 
            resources.ApplyResources(this.lblDesc, "lblDesc");
            this.lblDesc.Name = "lblDesc";
            // 
            // btnPlayAgain
            // 
            resources.ApplyResources(this.btnPlayAgain, "btnPlayAgain");
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // lblHint
            // 
            resources.ApplyResources(this.lblHint, "lblHint");
            this.lblHint.Name = "lblHint";
            this.lblHint.MouseHover += new System.EventHandler(this.lblHint_MouseHover);
            // 
            // lblAnswer
            // 
            resources.ApplyResources(this.lblAnswer, "lblAnswer");
            this.lblAnswer.Name = "lblAnswer";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.rbtnOne);
            this.Controls.Add(this.rbtnTwo);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.rbtnThree);
            this.Controls.Add(this.rbtnFour);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.rbtnFive);
            this.Controls.Add(this.lblDesc);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnOne;
        private System.Windows.Forms.RadioButton rbtnTwo;
        private System.Windows.Forms.RadioButton rbtnThree;
        private System.Windows.Forms.RadioButton rbtnFour;
        private System.Windows.Forms.RadioButton rbtnFive;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Label lblAnswer;
    }
}

