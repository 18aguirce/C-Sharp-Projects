using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FractionMath
{
    public partial class frmMain : Form
    {
        // Same as "FractionMath.MixedFraction f1, f2;"
        MixedFraction f1, f2;
        Fraction answer;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblResult.Text = "";
            lblFraction1.Text = "";
            lblFraction2.Text = "";
            lblWarning.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NumDom();

            try
            {
                answer = f1 + f2;
            }
            catch (NullReferenceException ex)
            {
            }

            results();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            NumDom();

            try
            {
                answer = f1 - f2; // made with 'Operator Overloading'
            }
            catch (NullReferenceException ex)
            {
            }

            results();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            NumDom();

            try
            {
                answer = f1 * f2;
            }
            catch (NullReferenceException ex)
            {
            }
            
            results();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            NumDom();

            try
            {
                answer = f1 / f2;
            }
            catch (NullReferenceException ex)
            {
            }

            results();
        }

        private void NumDom()
        {
            try
            {
                // Instantiation is happening with the 'new' keyword.
                f1 = new MixedFraction(GetNumber(txtWhole1.Text),
                                       GetNumber(txtNumerator1.Text),
                                       GetNumber(txtDenominator1.Text));
                lblFraction1.Text = txtWhole1.Text + " " +
                                    txtNumerator1.Text + "/" +
                                    txtDenominator1.Text;

                f2 = new MixedFraction(GetNumber(txtWhole2.Text),
                                       GetNumber(txtNumerator2.Text),
                                       GetNumber(txtDenominator2.Text));
                lblFraction2.Text = txtWhole2.Text + " " +
                                    txtNumerator2.Text + "/" +
                                    txtDenominator2.Text;
            }
            catch (FormatException ex)
            {
                lblWarning.Text = ex.Message;
            }
            
        }

        private void results()
        {
            try
            {
                MixedFraction manswer = new MixedFraction();
                manswer.ToMixedFraction(answer);

                txtWholeResult.Text = Convert.ToString(manswer.GetmWhole());
                txtNumeratorResult.Text = Convert.ToString(manswer.GetmNumerator());
                txtDenominatorResult.Text = Convert.ToString(manswer.GetmDenominator());
                lblResult.Text = manswer.GetmString();
            }
            catch (NullReferenceException ex)
            {
                lblWarning.Text = "Fill all the boxes.";
            }
            catch (DivideByZeroException ex)
            {
                lblWarning.Text = "Denominator or Second fraction cannot be zero.";
            }
        }

        public int GetNumber(string NumString)
        {
            if (NumString == "")
            {
                NumString = "Null or Invalid.";
            }
            if (int.TryParse(NumString, out int Number))
            {
                return Number;
            }
            else
            {
                throw (new FormatException("An invalid number was entered: " + NumString));
            }
        }

        public void ClearResult(object sender, EventArgs e)
        {
            txtWholeResult.Text = "";
            txtNumeratorResult.Text = "";
            txtDenominatorResult.Text = "";
            lblResult.Text = "";
            lblFraction1.Text = "";
            lblFraction2.Text = "";
            lblWarning.Text = "";
        }
    }
}
