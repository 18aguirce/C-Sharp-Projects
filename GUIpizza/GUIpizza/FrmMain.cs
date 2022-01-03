using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace GUIpizza
{
    public partial class FrmMain : Form
    {
        string order;
        double total, taxes,  Delivery, tips;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            order = "";
            total = 0;

            Crust();

            Toppings();

            Beverages();

            order += radDineIn.Checked ? " Dine In" : "";
            order += radTakeOut.Checked ? " Take Out" : "";
            order += radDelivery.Checked ? " Delivery" : "";
            Delivery = radDelivery.Checked ? 2.60 : 0; //excuding taxes

            order += " " + mtbPhoneNumber.Text;
            tips = double.TryParse(mtbTips.Text, out double i) ? i : 0;

            taxes = total * .06875;

            txtTotal.Text = "Subtotal: $" + total
                            + "\r\nTaxes: " + taxes.ToString("C2")
                            + "\r\nDelivery: " + Delivery.ToString("C2")
                            + "\r\nTips: " + tips.ToString("C2")
                            + "\r\nTotal: " + (total + taxes + Delivery + tips).ToString("C2");
        }

        private void radDelivery_CheckedChanged(object sender, EventArgs e)
        {
            if (radDelivery.Checked)
            {
                // result is just a name
                DialogResult result = MessageBox.Show(
                    "We deliver to addresses within city limits.\nDelivery fee is $2.60." +
                    "\nAre you in city limits?",
                    "Delivery Area",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );

                if (result == DialogResult.No)
                {
                    radTakeOut.Checked = true;
                }
            }
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuCalculator_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"calc.exe");

        }

        private void mnuHelp_Click(object sender, EventArgs e)
        {
            FormHelp frmHelp = new FormHelp();
            frmHelp.Show();
        }

        private void tmrBlink_Tick(object sender, EventArgs e)
        {
            if (pbxOpenSign.Visible)
            {
                pbxOpenSign.Visible = false;
            }
            else
            {
                pbxOpenSign.Visible = true;
            }
        }

        private void Crust()
        {
            // (Ternary operator ?:)Sames as if statement, can be nested.
            order += radThin.Checked ? "Thin Crust" : "";
            order += radTraditional.Checked ? "Traditional" : "";
            order += radDeepDish.Checked ? "Deep Dish" : "";
            order += radStuffed.Checked ? "Stuffed Crust" : "";

            foreach (RadioButton c in gbxCrust.Controls)
            {
                if (c.Checked)
                {
                    total += 7.99;
                }
            }
        }

        private void Toppings()
        {
            order += chkExtraCheese.Checked ? " Extra Cheese" : "";
            order += chkPepperoni.Checked ? " Pepperoni" : "";
            order += chkSausage.Checked ? " Sausage" : "";
            order += chkBlackOlives.Checked ? " Black Olives" : "";
            order += chkMushrooms.Checked ? " Mushrooms" : "";
            order += chkBacon.Checked ? " Bacon" : "";
            order += chkPineapple.Checked ? " Pineapple" : "";
            order += chkGreenPeppers.Checked ? " Green Peppers" : "";

            foreach (CheckBox c in gbxToppings.Controls)
            {
                if (c.Checked)
                {
                    total += 2.05;
                }
            }
        }

        private void Beverages()
        {
            order += chkSmallCoke.Checked ? " Coke 20oz" : "";
            total += chkSmallCoke.Checked ? 1.79 : 0;

            order += chkSmallFanta.Checked ? " Fanta 20oz" : "";
            total += chkSmallFanta.Checked ? 1.79 : 0;

            order += chkSmallDietCoke.Checked ? " Diet Coke 20oz" : "";
            total += chkSmallDietCoke.Checked ? 1.79 : 0;

            order += chkLargeCoke.Checked ? " Coke 2L" : "";
            total += chkLargeCoke.Checked ? 2.99 : 0;

            order += chkLargeDietCoke.Checked ? " Diet Coke 2L" : "";
            total += chkLargeDietCoke.Checked ? 2.99 : 0;

            order += chkLargeFanta.Checked ? " Fanta 2L" : "";
            total += chkLargeFanta.Checked ? 2.99 : 0;
        }
    }
}
