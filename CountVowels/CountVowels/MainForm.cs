// Author: Cesar Vicente
// Date  : Sep. 29 2019
// Chapter 5 Exercise 13 CountVowels

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CountVowels
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnCount_Click(object sender, EventArgs e)
        {
            int TotalVowels = 0,
                i;

            string input;

            input = txtParagraph.Text.ToLower();

            for (i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u') //use '' not ""
                {
                    TotalVowels++;
                }
            }

            txtCountedVowels.Text = TotalVowels.ToString();
        }

        private void TxtParagraph_TextChanged(object sender, EventArgs e)
        {
            txtCountedVowels.Text = "";
        }
    }
}
