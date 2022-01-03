// Author: Cesar Vicente
// Date  : Sep 19, 2019
// Chapter 4 Exercise 7

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Guess_100
{
    public partial class frmMain : Form
    {
        Random RandomNumberGenerator = new Random();

        int TargetNum, GuessNum, TotalTries;

        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            GuessNum = Convert.ToInt32(txtHumanGuess.Text);
            DoChecking();
            txtTries.Text = TotalTries.ToString();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            DoReset();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            DoReset();
        }

        private void DoChecking()
        {

            if (GuessNum > TargetNum)
            {
                lblCheck.Text = "Too high";
                TotalTries++;
            }

            else
            {
                if (GuessNum < TargetNum)
                {
                    lblCheck.Text = "Too low";
                    TotalTries++;
                }

                else
                {
                    lblCheck.Text = "You guess the number!!";
                    txtHumanGuess.Enabled = false;
                    btnCheck.Enabled = false;
                    btnReset.Visible = true;
                }
            }
        }

        private void DoReset()
        {
            TargetNum = RandomNumberGenerator.Next(0, 101);
            txtTries.Text = "";
            txtHumanGuess.Text = "";
            lblCheck.Text = "";
            btnReset.Visible = false;
            txtHumanGuess.Enabled = true;
            btnCheck.Enabled = true; //forgot this
        }
    }
}
