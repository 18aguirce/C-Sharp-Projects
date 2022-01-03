namespace FractionMath
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
            this.txtNumerator1 = new System.Windows.Forms.TextBox();
            this.txtDenominator1 = new System.Windows.Forms.TextBox();
            this.lblDash1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.lblDash2 = new System.Windows.Forms.Label();
            this.txtDenominator2 = new System.Windows.Forms.TextBox();
            this.txtNumerator2 = new System.Windows.Forms.TextBox();
            this.lblEquals = new System.Windows.Forms.Label();
            this.lblDashResult = new System.Windows.Forms.Label();
            this.txtDenominatorResult = new System.Windows.Forms.TextBox();
            this.txtNumeratorResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtWhole1 = new System.Windows.Forms.TextBox();
            this.txtWhole2 = new System.Windows.Forms.TextBox();
            this.txtWholeResult = new System.Windows.Forms.TextBox();
            this.lblFraction1 = new System.Windows.Forms.Label();
            this.lblFraction2 = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumerator1
            // 
            this.txtNumerator1.Location = new System.Drawing.Point(80, 60);
            this.txtNumerator1.Name = "txtNumerator1";
            this.txtNumerator1.Size = new System.Drawing.Size(56, 22);
            this.txtNumerator1.TabIndex = 2;
            this.txtNumerator1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumerator1.TextChanged += new System.EventHandler(this.ClearResult);
            // 
            // txtDenominator1
            // 
            this.txtDenominator1.Location = new System.Drawing.Point(80, 122);
            this.txtDenominator1.Name = "txtDenominator1";
            this.txtDenominator1.Size = new System.Drawing.Size(56, 22);
            this.txtDenominator1.TabIndex = 3;
            this.txtDenominator1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDenominator1.TextChanged += new System.EventHandler(this.ClearResult);
            // 
            // lblDash1
            // 
            this.lblDash1.AutoSize = true;
            this.lblDash1.Location = new System.Drawing.Point(77, 85);
            this.lblDash1.Name = "lblDash1";
            this.lblDash1.Size = new System.Drawing.Size(64, 17);
            this.lblDash1.TabIndex = 2;
            this.lblDash1.Text = "_______";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(163, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(43, 39);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(163, 150);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(43, 39);
            this.btnDivide.TabIndex = 10;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(163, 105);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(43, 39);
            this.btnMultiply.TabIndex = 9;
            this.btnMultiply.Text = "x";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(163, 60);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(43, 39);
            this.btnSubtract.TabIndex = 8;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // lblDash2
            // 
            this.lblDash2.AutoSize = true;
            this.lblDash2.Location = new System.Drawing.Point(294, 85);
            this.lblDash2.Name = "lblDash2";
            this.lblDash2.Size = new System.Drawing.Size(64, 17);
            this.lblDash2.TabIndex = 9;
            this.lblDash2.Text = "_______";
            // 
            // txtDenominator2
            // 
            this.txtDenominator2.Location = new System.Drawing.Point(297, 122);
            this.txtDenominator2.Name = "txtDenominator2";
            this.txtDenominator2.Size = new System.Drawing.Size(56, 22);
            this.txtDenominator2.TabIndex = 6;
            this.txtDenominator2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDenominator2.TextChanged += new System.EventHandler(this.ClearResult);
            // 
            // txtNumerator2
            // 
            this.txtNumerator2.Location = new System.Drawing.Point(297, 60);
            this.txtNumerator2.Name = "txtNumerator2";
            this.txtNumerator2.Size = new System.Drawing.Size(56, 22);
            this.txtNumerator2.TabIndex = 5;
            this.txtNumerator2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumerator2.TextChanged += new System.EventHandler(this.ClearResult);
            // 
            // lblEquals
            // 
            this.lblEquals.AutoSize = true;
            this.lblEquals.Location = new System.Drawing.Point(376, 85);
            this.lblEquals.Name = "lblEquals";
            this.lblEquals.Size = new System.Drawing.Size(16, 17);
            this.lblEquals.TabIndex = 10;
            this.lblEquals.Text = "=";
            // 
            // lblDashResult
            // 
            this.lblDashResult.AutoSize = true;
            this.lblDashResult.Location = new System.Drawing.Point(473, 85);
            this.lblDashResult.Name = "lblDashResult";
            this.lblDashResult.Size = new System.Drawing.Size(64, 17);
            this.lblDashResult.TabIndex = 13;
            this.lblDashResult.Text = "_______";
            // 
            // txtDenominatorResult
            // 
            this.txtDenominatorResult.Location = new System.Drawing.Point(476, 122);
            this.txtDenominatorResult.Name = "txtDenominatorResult";
            this.txtDenominatorResult.ReadOnly = true;
            this.txtDenominatorResult.Size = new System.Drawing.Size(56, 22);
            this.txtDenominatorResult.TabIndex = 12;
            this.txtDenominatorResult.TabStop = false;
            this.txtDenominatorResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumeratorResult
            // 
            this.txtNumeratorResult.Location = new System.Drawing.Point(476, 60);
            this.txtNumeratorResult.Name = "txtNumeratorResult";
            this.txtNumeratorResult.ReadOnly = true;
            this.txtNumeratorResult.Size = new System.Drawing.Size(56, 22);
            this.txtNumeratorResult.TabIndex = 11;
            this.txtNumeratorResult.TabStop = false;
            this.txtNumeratorResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(432, 166);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(100, 23);
            this.lblResult.TabIndex = 14;
            this.lblResult.Text = "empty / empty";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtWhole1
            // 
            this.txtWhole1.Location = new System.Drawing.Point(15, 85);
            this.txtWhole1.Name = "txtWhole1";
            this.txtWhole1.Size = new System.Drawing.Size(56, 22);
            this.txtWhole1.TabIndex = 1;
            this.txtWhole1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWhole1.TextChanged += new System.EventHandler(this.ClearResult);
            // 
            // txtWhole2
            // 
            this.txtWhole2.Location = new System.Drawing.Point(232, 85);
            this.txtWhole2.Name = "txtWhole2";
            this.txtWhole2.Size = new System.Drawing.Size(56, 22);
            this.txtWhole2.TabIndex = 4;
            this.txtWhole2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWhole2.TextChanged += new System.EventHandler(this.ClearResult);
            // 
            // txtWholeResult
            // 
            this.txtWholeResult.Location = new System.Drawing.Point(411, 85);
            this.txtWholeResult.Name = "txtWholeResult";
            this.txtWholeResult.ReadOnly = true;
            this.txtWholeResult.Size = new System.Drawing.Size(56, 22);
            this.txtWholeResult.TabIndex = 17;
            this.txtWholeResult.TabStop = false;
            this.txtWholeResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFraction1
            // 
            this.lblFraction1.Location = new System.Drawing.Point(41, 161);
            this.lblFraction1.Name = "lblFraction1";
            this.lblFraction1.Size = new System.Drawing.Size(100, 23);
            this.lblFraction1.TabIndex = 18;
            this.lblFraction1.Text = "empty / empty";
            this.lblFraction1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFraction2
            // 
            this.lblFraction2.Location = new System.Drawing.Point(258, 166);
            this.lblFraction2.Name = "lblFraction2";
            this.lblFraction2.Size = new System.Drawing.Size(100, 23);
            this.lblFraction2.TabIndex = 19;
            this.lblFraction2.Text = "empty / empty";
            this.lblFraction2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Location = new System.Drawing.Point(12, 222);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(61, 17);
            this.lblWarning.TabIndex = 20;
            this.lblWarning.Text = "Warning";
            this.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 261);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblFraction2);
            this.Controls.Add(this.lblFraction1);
            this.Controls.Add(this.txtWholeResult);
            this.Controls.Add(this.txtWhole2);
            this.Controls.Add(this.txtWhole1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblDashResult);
            this.Controls.Add(this.txtDenominatorResult);
            this.Controls.Add(this.txtNumeratorResult);
            this.Controls.Add(this.lblEquals);
            this.Controls.Add(this.lblDash2);
            this.Controls.Add(this.txtDenominator2);
            this.Controls.Add(this.txtNumerator2);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDash1);
            this.Controls.Add(this.txtDenominator1);
            this.Controls.Add(this.txtNumerator1);
            this.Name = "frmMain";
            this.Text = "Fraction Math";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumerator1;
        private System.Windows.Forms.TextBox txtDenominator1;
        private System.Windows.Forms.Label lblDash1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Label lblDash2;
        private System.Windows.Forms.TextBox txtDenominator2;
        private System.Windows.Forms.TextBox txtNumerator2;
        private System.Windows.Forms.Label lblEquals;
        private System.Windows.Forms.Label lblDashResult;
        private System.Windows.Forms.TextBox txtDenominatorResult;
        private System.Windows.Forms.TextBox txtNumeratorResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtWhole1;
        private System.Windows.Forms.TextBox txtWhole2;
        private System.Windows.Forms.TextBox txtWholeResult;
        private System.Windows.Forms.Label lblFraction1;
        private System.Windows.Forms.Label lblFraction2;
        private System.Windows.Forms.Label lblWarning;
    }
}

