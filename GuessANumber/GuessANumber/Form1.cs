using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuessANumber
{
    public partial class Form1 : Form
    {
        int Answer,
            one = 1,
            two = 2,
            three = 3,
            four = 4,
            five = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Restart();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private void lblHint_MouseHover(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int hint;

            do
            {
                hint = rnd.Next(1, 6);

            } while (hint == Answer);

            rbtnOne.Enabled = hint == one ? false : true;
            rbtnTwo.Enabled = hint == two ? false : true;
            rbtnThree.Enabled = hint == three ? false : true;
            rbtnFour.Enabled = hint == four ? false : true;
            rbtnFive.Enabled = hint == five ? false : true;

            lblHint.Enabled = false;
            lblHint.Text = "No more Hints.";
        }

        private void rbtnOne_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnOne.Checked)
            {
                answered(one);
            }
        }

        private void rbtnTwo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTwo.Checked)
            {
                answered(two);
            }
        }

        private void rbtnThree_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnThree.Checked)
            {
                answered(three);
            }
        }

        private void rbtnFour_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFour.Checked)
            {
                answered(four);
            }
        }

        private void rbtnFive_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFive.Checked)
            {
                answered(five);
            }
        }

        public void Restart()
        {
            Random rnd = new Random();
            Answer = rnd.Next(1, 6);
            // testin only // lblAnswer.Text = Answer + "";
            lblAnswer.Text = ""; // comment this out to use Testing 
            lblHint.Text = "Hover here for hint.";
            lblHint.Enabled = true;
            rbtnOne.Enabled = true;
            rbtnTwo.Enabled = true;
            rbtnThree.Enabled = true;
            rbtnFour.Enabled = true;
            rbtnFive.Enabled = true;
            rbtnOne.Checked = false;
            rbtnTwo.Checked = false;
            rbtnThree.Checked = false;
            rbtnFour.Checked = false;
            rbtnFive.Checked = false;
        }

        public void answered(int input)
        {
            rbtnOne.Enabled = false;
            rbtnTwo.Enabled = false;
            rbtnThree.Enabled = false;
            rbtnFour.Enabled = false;
            rbtnFive.Enabled = false;
            lblHint.Enabled = false;

            if (input == Answer)
            {
                lblAnswer.Text = "Correct";
                lblAnswer.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblAnswer.Text = "Incorrect";
                lblAnswer.ForeColor = System.Drawing.Color.Red;
            }

        }
    }
}
