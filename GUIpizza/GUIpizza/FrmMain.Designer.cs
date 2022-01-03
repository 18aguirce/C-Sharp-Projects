namespace GUIpizza
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.gbxCrust = new System.Windows.Forms.GroupBox();
            this.radTraditional = new System.Windows.Forms.RadioButton();
            this.radDeepDish = new System.Windows.Forms.RadioButton();
            this.radStuffed = new System.Windows.Forms.RadioButton();
            this.radThin = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxToppings = new System.Windows.Forms.GroupBox();
            this.chkBacon = new System.Windows.Forms.CheckBox();
            this.chkPineapple = new System.Windows.Forms.CheckBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkBlackOlives = new System.Windows.Forms.CheckBox();
            this.chkSausage = new System.Windows.Forms.CheckBox();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.gbxDining = new System.Windows.Forms.GroupBox();
            this.radDelivery = new System.Windows.Forms.RadioButton();
            this.radTakeOut = new System.Windows.Forms.RadioButton();
            this.radDineIn = new System.Windows.Forms.RadioButton();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.mtbPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCalculator = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.pbxOpenSign = new System.Windows.Forms.PictureBox();
            this.pizza = new System.Windows.Forms.PictureBox();
            this.tmrBlink = new System.Windows.Forms.Timer(this.components);
            this.gbxBeverages = new System.Windows.Forms.GroupBox();
            this.chkSmallDietCoke = new System.Windows.Forms.CheckBox();
            this.chkSmallFanta = new System.Windows.Forms.CheckBox();
            this.chkLargeFanta = new System.Windows.Forms.CheckBox();
            this.chkLargeDietCoke = new System.Windows.Forms.CheckBox();
            this.chkSmallCoke = new System.Windows.Forms.CheckBox();
            this.chkLargeCoke = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.mtbTips = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxCrust.SuspendLayout();
            this.gbxToppings.SuspendLayout();
            this.gbxDining.SuspendLayout();
            this.mnuMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOpenSign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizza)).BeginInit();
            this.gbxBeverages.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCrust
            // 
            this.gbxCrust.Controls.Add(this.radTraditional);
            this.gbxCrust.Controls.Add(this.radDeepDish);
            this.gbxCrust.Controls.Add(this.radStuffed);
            this.gbxCrust.Controls.Add(this.radThin);
            this.gbxCrust.Location = new System.Drawing.Point(31, 46);
            this.gbxCrust.Name = "gbxCrust";
            this.gbxCrust.Size = new System.Drawing.Size(195, 163);
            this.gbxCrust.TabIndex = 0;
            this.gbxCrust.TabStop = false;
            this.gbxCrust.Text = "Crust";
            // 
            // radTraditional
            // 
            this.radTraditional.AutoSize = true;
            this.radTraditional.Checked = true;
            this.radTraditional.Location = new System.Drawing.Point(6, 61);
            this.radTraditional.Name = "radTraditional";
            this.radTraditional.Size = new System.Drawing.Size(133, 21);
            this.radTraditional.TabIndex = 3;
            this.radTraditional.TabStop = true;
            this.radTraditional.Text = "Traditional Crust";
            this.radTraditional.UseVisualStyleBackColor = true;
            // 
            // radDeepDish
            // 
            this.radDeepDish.AutoSize = true;
            this.radDeepDish.Location = new System.Drawing.Point(6, 88);
            this.radDeepDish.Name = "radDeepDish";
            this.radDeepDish.Size = new System.Drawing.Size(91, 21);
            this.radDeepDish.TabIndex = 2;
            this.radDeepDish.Text = "DeepDish";
            this.radDeepDish.UseVisualStyleBackColor = true;
            // 
            // radStuffed
            // 
            this.radStuffed.AutoSize = true;
            this.radStuffed.Location = new System.Drawing.Point(6, 115);
            this.radStuffed.Name = "radStuffed";
            this.radStuffed.Size = new System.Drawing.Size(111, 21);
            this.radStuffed.TabIndex = 1;
            this.radStuffed.Text = "Stuffed Crust";
            this.radStuffed.UseVisualStyleBackColor = true;
            // 
            // radThin
            // 
            this.radThin.AutoSize = true;
            this.radThin.Location = new System.Drawing.Point(6, 34);
            this.radThin.Name = "radThin";
            this.radThin.Size = new System.Drawing.Size(94, 21);
            this.radThin.TabIndex = 0;
            this.radThin.Text = "Thin Crust\r\n";
            this.radThin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(40, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 47);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pizza crust .... $7.99\r\nToppings ...... $2.05 each\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbxToppings
            // 
            this.gbxToppings.Controls.Add(this.chkBacon);
            this.gbxToppings.Controls.Add(this.chkPineapple);
            this.gbxToppings.Controls.Add(this.chkGreenPeppers);
            this.gbxToppings.Controls.Add(this.chkMushrooms);
            this.gbxToppings.Controls.Add(this.chkBlackOlives);
            this.gbxToppings.Controls.Add(this.chkSausage);
            this.gbxToppings.Controls.Add(this.chkPepperoni);
            this.gbxToppings.Controls.Add(this.chkExtraCheese);
            this.gbxToppings.Location = new System.Drawing.Point(232, 46);
            this.gbxToppings.Name = "gbxToppings";
            this.gbxToppings.Size = new System.Drawing.Size(195, 264);
            this.gbxToppings.TabIndex = 1;
            this.gbxToppings.TabStop = false;
            this.gbxToppings.Text = "Toppings";
            // 
            // chkBacon
            // 
            this.chkBacon.AutoSize = true;
            this.chkBacon.Location = new System.Drawing.Point(6, 169);
            this.chkBacon.Name = "chkBacon";
            this.chkBacon.Size = new System.Drawing.Size(70, 21);
            this.chkBacon.TabIndex = 6;
            this.chkBacon.Text = "Bacon";
            this.chkBacon.UseVisualStyleBackColor = true;
            // 
            // chkPineapple
            // 
            this.chkPineapple.AutoSize = true;
            this.chkPineapple.Location = new System.Drawing.Point(6, 196);
            this.chkPineapple.Name = "chkPineapple";
            this.chkPineapple.Size = new System.Drawing.Size(93, 21);
            this.chkPineapple.TabIndex = 5;
            this.chkPineapple.Text = "Pineapple";
            this.chkPineapple.UseVisualStyleBackColor = true;
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Location = new System.Drawing.Point(6, 223);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(126, 21);
            this.chkGreenPeppers.TabIndex = 4;
            this.chkGreenPeppers.Text = "Green peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(6, 142);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(103, 21);
            this.chkMushrooms.TabIndex = 2;
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            // 
            // chkBlackOlives
            // 
            this.chkBlackOlives.AutoSize = true;
            this.chkBlackOlives.Location = new System.Drawing.Point(6, 115);
            this.chkBlackOlives.Name = "chkBlackOlives";
            this.chkBlackOlives.Size = new System.Drawing.Size(107, 21);
            this.chkBlackOlives.TabIndex = 3;
            this.chkBlackOlives.Text = "Black Olives";
            this.chkBlackOlives.UseVisualStyleBackColor = true;
            // 
            // chkSausage
            // 
            this.chkSausage.AutoSize = true;
            this.chkSausage.Location = new System.Drawing.Point(6, 88);
            this.chkSausage.Name = "chkSausage";
            this.chkSausage.Size = new System.Drawing.Size(86, 21);
            this.chkSausage.TabIndex = 2;
            this.chkSausage.Text = "Sausage";
            this.chkSausage.UseVisualStyleBackColor = true;
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Location = new System.Drawing.Point(6, 61);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(95, 21);
            this.chkPepperoni.TabIndex = 1;
            this.chkPepperoni.Text = "Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Location = new System.Drawing.Point(6, 34);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(114, 21);
            this.chkExtraCheese.TabIndex = 0;
            this.chkExtraCheese.Text = "Extra Cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            // 
            // gbxDining
            // 
            this.gbxDining.Controls.Add(this.radDelivery);
            this.gbxDining.Controls.Add(this.radTakeOut);
            this.gbxDining.Controls.Add(this.radDineIn);
            this.gbxDining.Location = new System.Drawing.Point(634, 46);
            this.gbxDining.Name = "gbxDining";
            this.gbxDining.Size = new System.Drawing.Size(188, 264);
            this.gbxDining.TabIndex = 2;
            this.gbxDining.TabStop = false;
            this.gbxDining.Text = "Dining";
            // 
            // radDelivery
            // 
            this.radDelivery.AutoSize = true;
            this.radDelivery.Location = new System.Drawing.Point(6, 88);
            this.radDelivery.Name = "radDelivery";
            this.radDelivery.Size = new System.Drawing.Size(132, 21);
            this.radDelivery.TabIndex = 2;
            this.radDelivery.TabStop = true;
            this.radDelivery.Text = "Delivery....$2.60";
            this.radDelivery.UseVisualStyleBackColor = true;
            this.radDelivery.CheckedChanged += new System.EventHandler(this.radDelivery_CheckedChanged);
            // 
            // radTakeOut
            // 
            this.radTakeOut.AutoSize = true;
            this.radTakeOut.Location = new System.Drawing.Point(7, 61);
            this.radTakeOut.Name = "radTakeOut";
            this.radTakeOut.Size = new System.Drawing.Size(88, 21);
            this.radTakeOut.TabIndex = 1;
            this.radTakeOut.TabStop = true;
            this.radTakeOut.Text = "Take Out";
            this.radTakeOut.UseVisualStyleBackColor = true;
            // 
            // radDineIn
            // 
            this.radDineIn.AutoSize = true;
            this.radDineIn.Location = new System.Drawing.Point(7, 34);
            this.radDineIn.Name = "radDineIn";
            this.radDineIn.Size = new System.Drawing.Size(73, 21);
            this.radDineIn.TabIndex = 0;
            this.radDineIn.TabStop = true;
            this.radDineIn.Text = "Dine In";
            this.radDineIn.UseVisualStyleBackColor = true;
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(31, 352);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.ReadOnly = true;
            this.txtOrder.Size = new System.Drawing.Size(791, 22);
            this.txtOrder.TabIndex = 3;
            // 
            // mtbPhoneNumber
            // 
            this.mtbPhoneNumber.Location = new System.Drawing.Point(32, 313);
            this.mtbPhoneNumber.Mask = "(999) 000-0000";
            this.mtbPhoneNumber.Name = "mtbPhoneNumber";
            this.mtbPhoneNumber.Size = new System.Drawing.Size(117, 22);
            this.mtbPhoneNumber.TabIndex = 4;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(302, 450);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(169, 72);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // mnuMenu
            // 
            this.mnuMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuCalculator,
            this.mnuHelp});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(855, 28);
            this.mnuMenu.TabIndex = 6;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(46, 24);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.X)));
            this.mnuFileExit.Size = new System.Drawing.Size(207, 26);
            this.mnuFileExit.Text = "E&xit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuCalculator
            // 
            this.mnuCalculator.Name = "mnuCalculator";
            this.mnuCalculator.Size = new System.Drawing.Size(90, 24);
            this.mnuCalculator.Text = "Calculator";
            this.mnuCalculator.Click += new System.EventHandler(this.mnuCalculator_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(55, 24);
            this.mnuHelp.Text = "&Help";
            this.mnuHelp.Click += new System.EventHandler(this.mnuHelp_Click);
            // 
            // pbxOpenSign
            // 
            this.pbxOpenSign.Image = global::GUIpizza.Properties.Resources.sign;
            this.pbxOpenSign.Location = new System.Drawing.Point(678, 425);
            this.pbxOpenSign.Name = "pbxOpenSign";
            this.pbxOpenSign.Size = new System.Drawing.Size(144, 131);
            this.pbxOpenSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxOpenSign.TabIndex = 8;
            this.pbxOpenSign.TabStop = false;
            // 
            // pizza
            // 
            this.pizza.Image = global::GUIpizza.Properties.Resources.Pizza;
            this.pizza.Location = new System.Drawing.Point(524, 425);
            this.pizza.Name = "pizza";
            this.pizza.Size = new System.Drawing.Size(148, 131);
            this.pizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pizza.TabIndex = 7;
            this.pizza.TabStop = false;
            // 
            // tmrBlink
            // 
            this.tmrBlink.Enabled = true;
            this.tmrBlink.Interval = 1000;
            this.tmrBlink.Tick += new System.EventHandler(this.tmrBlink_Tick);
            // 
            // gbxBeverages
            // 
            this.gbxBeverages.Controls.Add(this.chkSmallDietCoke);
            this.gbxBeverages.Controls.Add(this.chkSmallFanta);
            this.gbxBeverages.Controls.Add(this.chkLargeFanta);
            this.gbxBeverages.Controls.Add(this.chkLargeDietCoke);
            this.gbxBeverages.Controls.Add(this.chkSmallCoke);
            this.gbxBeverages.Controls.Add(this.chkLargeCoke);
            this.gbxBeverages.Location = new System.Drawing.Point(433, 46);
            this.gbxBeverages.Name = "gbxBeverages";
            this.gbxBeverages.Size = new System.Drawing.Size(195, 202);
            this.gbxBeverages.TabIndex = 9;
            this.gbxBeverages.TabStop = false;
            this.gbxBeverages.Text = "Beverages";
            // 
            // chkSmallDietCoke
            // 
            this.chkSmallDietCoke.AutoSize = true;
            this.chkSmallDietCoke.Location = new System.Drawing.Point(7, 116);
            this.chkSmallDietCoke.Name = "chkSmallDietCoke";
            this.chkSmallDietCoke.Size = new System.Drawing.Size(135, 21);
            this.chkSmallDietCoke.TabIndex = 17;
            this.chkSmallDietCoke.Text = "Diet Coke - 20oz";
            this.chkSmallDietCoke.UseVisualStyleBackColor = true;
            // 
            // chkSmallFanta
            // 
            this.chkSmallFanta.AutoSize = true;
            this.chkSmallFanta.Location = new System.Drawing.Point(7, 169);
            this.chkSmallFanta.Name = "chkSmallFanta";
            this.chkSmallFanta.Size = new System.Drawing.Size(110, 21);
            this.chkSmallFanta.TabIndex = 16;
            this.chkSmallFanta.Text = "Fanta - 20oz";
            this.chkSmallFanta.UseVisualStyleBackColor = true;
            // 
            // chkLargeFanta
            // 
            this.chkLargeFanta.AutoSize = true;
            this.chkLargeFanta.Location = new System.Drawing.Point(7, 142);
            this.chkLargeFanta.Name = "chkLargeFanta";
            this.chkLargeFanta.Size = new System.Drawing.Size(95, 21);
            this.chkLargeFanta.TabIndex = 15;
            this.chkLargeFanta.Text = "Fanta - 2L";
            this.chkLargeFanta.UseVisualStyleBackColor = true;
            // 
            // chkLargeDietCoke
            // 
            this.chkLargeDietCoke.AutoSize = true;
            this.chkLargeDietCoke.Location = new System.Drawing.Point(7, 88);
            this.chkLargeDietCoke.Name = "chkLargeDietCoke";
            this.chkLargeDietCoke.Size = new System.Drawing.Size(120, 21);
            this.chkLargeDietCoke.TabIndex = 14;
            this.chkLargeDietCoke.Text = "Diet Coke - 2L";
            this.chkLargeDietCoke.UseVisualStyleBackColor = true;
            // 
            // chkSmallCoke
            // 
            this.chkSmallCoke.AutoSize = true;
            this.chkSmallCoke.Location = new System.Drawing.Point(7, 61);
            this.chkSmallCoke.Name = "chkSmallCoke";
            this.chkSmallCoke.Size = new System.Drawing.Size(106, 21);
            this.chkSmallCoke.TabIndex = 13;
            this.chkSmallCoke.Text = "Coke - 20oz";
            this.chkSmallCoke.UseVisualStyleBackColor = true;
            // 
            // chkLargeCoke
            // 
            this.chkLargeCoke.AutoSize = true;
            this.chkLargeCoke.Location = new System.Drawing.Point(7, 34);
            this.chkLargeCoke.Name = "chkLargeCoke";
            this.chkLargeCoke.Size = new System.Drawing.Size(91, 21);
            this.chkLargeCoke.TabIndex = 0;
            this.chkLargeCoke.Text = "Coke - 2L";
            this.chkLargeCoke.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(437, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 52);
            this.label2.TabIndex = 18;
            this.label2.Text = "2L ........ $2.99\r\n20oz .... $1.79";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(31, 425);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(221, 128);
            this.txtTotal.TabIndex = 10;
            // 
            // mtbTips
            // 
            this.mtbTips.Location = new System.Drawing.Point(136, 386);
            this.mtbTips.Mask = "00.00";
            this.mtbTips.Name = "mtbTips";
            this.mtbTips.Size = new System.Drawing.Size(54, 22);
            this.mtbTips.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tips (optional)";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 568);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtbTips);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.gbxBeverages);
            this.Controls.Add(this.pbxOpenSign);
            this.Controls.Add(this.pizza);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.mtbPhoneNumber);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.gbxDining);
            this.Controls.Add(this.gbxToppings);
            this.Controls.Add(this.gbxCrust);
            this.Controls.Add(this.mnuMenu);
            this.MainMenuStrip = this.mnuMenu;
            this.Name = "FrmMain";
            this.Text = "Tony\'s Pizza";
            this.gbxCrust.ResumeLayout(false);
            this.gbxCrust.PerformLayout();
            this.gbxToppings.ResumeLayout(false);
            this.gbxToppings.PerformLayout();
            this.gbxDining.ResumeLayout(false);
            this.gbxDining.PerformLayout();
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOpenSign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizza)).EndInit();
            this.gbxBeverages.ResumeLayout(false);
            this.gbxBeverages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCrust;
        private System.Windows.Forms.RadioButton radTraditional;
        private System.Windows.Forms.RadioButton radDeepDish;
        private System.Windows.Forms.RadioButton radStuffed;
        private System.Windows.Forms.RadioButton radThin;
        private System.Windows.Forms.GroupBox gbxToppings;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkBlackOlives;
        private System.Windows.Forms.CheckBox chkSausage;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.GroupBox gbxDining;
        private System.Windows.Forms.RadioButton radDelivery;
        private System.Windows.Forms.RadioButton radTakeOut;
        private System.Windows.Forms.RadioButton radDineIn;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.MaskedTextBox mtbPhoneNumber;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuCalculator;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.PictureBox pizza;
        private System.Windows.Forms.PictureBox pbxOpenSign;
        private System.Windows.Forms.Timer tmrBlink;
        private System.Windows.Forms.GroupBox gbxBeverages;
        private System.Windows.Forms.CheckBox chkBacon;
        private System.Windows.Forms.CheckBox chkPineapple;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkSmallDietCoke;
        private System.Windows.Forms.CheckBox chkSmallFanta;
        private System.Windows.Forms.CheckBox chkLargeFanta;
        private System.Windows.Forms.CheckBox chkLargeDietCoke;
        private System.Windows.Forms.CheckBox chkSmallCoke;
        private System.Windows.Forms.CheckBox chkLargeCoke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.MaskedTextBox mtbTips;
        private System.Windows.Forms.Label label3;
    }
}

