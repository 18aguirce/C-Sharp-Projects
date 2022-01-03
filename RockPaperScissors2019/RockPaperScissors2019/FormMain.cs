// Author: Cesar Vicente
// Date  : September 16, 2019
// Chapter 4 Exercise 8

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RockPaperScissors2019
{
    public partial class frmMain : Form
    {
        Random randomNumberGenerator = new Random();

        enum Selection { ROCK, PAPER, SCISSORS };

        Selection humanChoice, computerChoice;

        int humanScore, computerScore, tieScore;

        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnRock_Click(object sender, EventArgs e)
        {
            humanChoice = Selection.ROCK;
            picboxHumanChoice.Image = global::RockPaperScissors2019.Properties.Resources.rock;
            DoComparisons();
        }

        private void BtnPaper_Click(object sender, EventArgs e)
        {
            humanChoice = Selection.PAPER;
            picboxHumanChoice.Image = global::RockPaperScissors2019.Properties.Resources.paper;
            DoComparisons();
        }

        private void BtnScissors_Click(object sender, EventArgs e)
        {
            humanChoice = Selection.SCISSORS;
            picboxHumanChoice.Image = global::RockPaperScissors2019.Properties.Resources.scissors;
            DoComparisons();
        }

        private void RockPaperScissors_Load(object sender, EventArgs e)
        {
            humanScore = 0;
            computerScore = 0;
            tieScore = 0;

            lblHumanChose.Text = "";
            lblComputerChose.Text = "";
            lblResult.Text = "";

            picboxHumanChoice.BackgroundImage = null; //sets it to nothing
            picboxComputerChoice.BackgroundImage = null;

        }

        private void DoComparisons()
        {
            computerChoice = (Selection) randomNumberGenerator.Next(0, 3);

            lblHumanChose.Text = "You chose " + Convert.ToString((Selection)humanChoice);
            lblComputerChose.Text = "Computer chose " + Convert.ToString((Selection)computerChoice);

            switch(computerChoice)
            {
                case Selection.ROCK:
                    picboxComputerChoice.Image = global::RockPaperScissors2019.Properties.Resources.rock;
                    break;

                case Selection.PAPER:
                    picboxComputerChoice.Image = global::RockPaperScissors2019.Properties.Resources.paper;
                    break;

                case Selection.SCISSORS:
                    picboxComputerChoice.Image = global::RockPaperScissors2019.Properties.Resources.scissors;
                    break;

                default:
                    picboxComputerChoice.BackgroundImage = null;
                    break;

            }

            // selections that result in a tie.
            if (humanChoice == computerChoice)
            {
                lblResult.ForeColor = System.Drawing.Color.Black;
                lblResult.Text = "Tie";
                tieScore++;
            } 
            else
            {
                // Selections that result in human winning.
                if((humanChoice == Selection.ROCK && computerChoice == Selection.SCISSORS) ||
                        (humanChoice == Selection.PAPER && computerChoice == Selection.ROCK) ||
                        (humanChoice == Selection.SCISSORS && computerChoice == Selection.PAPER))
                {
                    lblResult.ForeColor = System.Drawing.Color.DarkGreen;
                    lblResult.Text = "You Win!!!";
                    humanScore++;
                }
                else // computer must have won if reach this point.
                {
                    lblResult.ForeColor = System.Drawing.Color.Maroon;
                    lblResult.Text = "Computer wins :-(";
                    computerScore++;
                }
            }

            txtHumanScore.Text = Convert.ToString(humanScore);
            txtComputerScore.Text = Convert.ToString(computerScore);
            txtTieScore.Text = Convert.ToString(tieScore);

        }// End of comparation
        
    }
}
