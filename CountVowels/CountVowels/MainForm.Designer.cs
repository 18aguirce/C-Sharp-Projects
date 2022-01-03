namespace CountVowels
{
    partial class MainForm
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
            this.btnCount = new System.Windows.Forms.Button();
            this.txtParagraph = new System.Windows.Forms.TextBox();
            this.txtCountedVowels = new System.Windows.Forms.TextBox();
            this.lblVowels = new System.Windows.Forms.Label();
            this.txtDirections = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(12, 190);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(131, 53);
            this.btnCount.TabIndex = 1;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.BtnCount_Click);
            // 
            // txtParagraph
            // 
            this.txtParagraph.Location = new System.Drawing.Point(13, 60);
            this.txtParagraph.Multiline = true;
            this.txtParagraph.Name = "txtParagraph";
            this.txtParagraph.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtParagraph.Size = new System.Drawing.Size(354, 124);
            this.txtParagraph.TabIndex = 0;
            this.txtParagraph.TextChanged += new System.EventHandler(this.TxtParagraph_TextChanged);
            // 
            // txtCountedVowels
            // 
            this.txtCountedVowels.Enabled = false;
            this.txtCountedVowels.Location = new System.Drawing.Point(149, 205);
            this.txtCountedVowels.Name = "txtCountedVowels";
            this.txtCountedVowels.Size = new System.Drawing.Size(75, 22);
            this.txtCountedVowels.TabIndex = 2;
            // 
            // lblVowels
            // 
            this.lblVowels.AutoSize = true;
            this.lblVowels.Location = new System.Drawing.Point(230, 206);
            this.lblVowels.Name = "lblVowels";
            this.lblVowels.Size = new System.Drawing.Size(50, 17);
            this.lblVowels.TabIndex = 3;
            this.lblVowels.Text = "vowels";
            // 
            // txtDirections
            // 
            this.txtDirections.Location = new System.Drawing.Point(13, 9);
            this.txtDirections.Name = "txtDirections";
            this.txtDirections.Size = new System.Drawing.Size(354, 48);
            this.txtDirections.TabIndex = 4;
            this.txtDirections.Text = "Enter a paragraph of text. All vowels, upper and lowercase will be counted. Y is " +
    "not considered a vowel.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 255);
            this.Controls.Add(this.txtDirections);
            this.Controls.Add(this.lblVowels);
            this.Controls.Add(this.txtCountedVowels);
            this.Controls.Add(this.txtParagraph);
            this.Controls.Add(this.btnCount);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "CountVowels";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.TextBox txtParagraph;
        private System.Windows.Forms.TextBox txtCountedVowels;
        private System.Windows.Forms.Label lblVowels;
        private System.Windows.Forms.Label txtDirections;
    }
}

