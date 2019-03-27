namespace PizzaOrder
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
            this.sizeBox = new System.Windows.Forms.GroupBox();
            this.bigPizzaPrice = new System.Windows.Forms.TextBox();
            this.mediumPizzaPrice = new System.Windows.Forms.TextBox();
            this.smallPizzaPrice = new System.Windows.Forms.TextBox();
            this.BigPizzaRadioButton = new System.Windows.Forms.RadioButton();
            this.mediumPizzaRadioButton = new System.Windows.Forms.RadioButton();
            this.smallPizzaRadioButton = new System.Windows.Forms.RadioButton();
            this.extraBox = new System.Windows.Forms.GroupBox();
            this.ketchupCheck = new System.Windows.Forms.CheckBox();
            this.cheeseCheck = new System.Windows.Forms.CheckBox();
            this.feferoniCheck = new System.Windows.Forms.CheckBox();
            this.ketchupPrice = new System.Windows.Forms.TextBox();
            this.cheesePrice = new System.Windows.Forms.TextBox();
            this.feferoniPrice = new System.Windows.Forms.TextBox();
            this.drinkBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cc = new System.Windows.Forms.Label();
            this.beerTotal = new System.Windows.Forms.TextBox();
            this.appleTotal = new System.Windows.Forms.TextBox();
            this.ccTotal = new System.Windows.Forms.TextBox();
            this.beerPrice = new System.Windows.Forms.TextBox();
            this.applePrice = new System.Windows.Forms.TextBox();
            this.ccPrice = new System.Windows.Forms.TextBox();
            this.beerCount = new System.Windows.Forms.TextBox();
            this.appleCount = new System.Windows.Forms.TextBox();
            this.ccCount = new System.Windows.Forms.TextBox();
            this.desertBox = new System.Windows.Forms.GroupBox();
            this.cancelDesert = new System.Windows.Forms.Button();
            this.orderDesert = new System.Windows.Forms.Button();
            this.desertPriceLabel = new System.Windows.Forms.Label();
            this.desertPrice = new System.Windows.Forms.TextBox();
            this.paymentBox = new System.Windows.Forms.GroupBox();
            this.changeLabel = new System.Windows.Forms.Label();
            this.payedLabel = new System.Windows.Forms.Label();
            this.totalPaymentLabel = new System.Windows.Forms.Label();
            this.changeBox = new System.Windows.Forms.TextBox();
            this.payedBox = new System.Windows.Forms.TextBox();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.totalDrinkLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.desertNameBox = new System.Windows.Forms.TextBox();
            this.desertNameLabel = new System.Windows.Forms.Label();
            this.sizeBox.SuspendLayout();
            this.extraBox.SuspendLayout();
            this.drinkBox.SuspendLayout();
            this.desertBox.SuspendLayout();
            this.paymentBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sizeBox
            // 
            this.sizeBox.Controls.Add(this.bigPizzaPrice);
            this.sizeBox.Controls.Add(this.mediumPizzaPrice);
            this.sizeBox.Controls.Add(this.smallPizzaPrice);
            this.sizeBox.Controls.Add(this.BigPizzaRadioButton);
            this.sizeBox.Controls.Add(this.mediumPizzaRadioButton);
            this.sizeBox.Controls.Add(this.smallPizzaRadioButton);
            this.sizeBox.Location = new System.Drawing.Point(46, 29);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(285, 193);
            this.sizeBox.TabIndex = 0;
            this.sizeBox.TabStop = false;
            this.sizeBox.Text = "Големина";
            this.sizeBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bigPizzaPrice
            // 
            this.bigPizzaPrice.Location = new System.Drawing.Point(162, 135);
            this.bigPizzaPrice.Name = "bigPizzaPrice";
            this.bigPizzaPrice.Size = new System.Drawing.Size(100, 22);
            this.bigPizzaPrice.TabIndex = 5;
            this.bigPizzaPrice.Text = "500";
            // 
            // mediumPizzaPrice
            // 
            this.mediumPizzaPrice.Location = new System.Drawing.Point(162, 89);
            this.mediumPizzaPrice.Name = "mediumPizzaPrice";
            this.mediumPizzaPrice.Size = new System.Drawing.Size(100, 22);
            this.mediumPizzaPrice.TabIndex = 4;
            this.mediumPizzaPrice.Text = "300";
            // 
            // smallPizzaPrice
            // 
            this.smallPizzaPrice.Location = new System.Drawing.Point(162, 39);
            this.smallPizzaPrice.Name = "smallPizzaPrice";
            this.smallPizzaPrice.Size = new System.Drawing.Size(100, 22);
            this.smallPizzaPrice.TabIndex = 3;
            this.smallPizzaPrice.Text = "200";
            // 
            // BigPizzaRadioButton
            // 
            this.BigPizzaRadioButton.AutoSize = true;
            this.BigPizzaRadioButton.Location = new System.Drawing.Point(24, 136);
            this.BigPizzaRadioButton.Name = "BigPizzaRadioButton";
            this.BigPizzaRadioButton.Size = new System.Drawing.Size(78, 21);
            this.BigPizzaRadioButton.TabIndex = 2;
            this.BigPizzaRadioButton.TabStop = true;
            this.BigPizzaRadioButton.Text = "Голема";
            this.BigPizzaRadioButton.UseVisualStyleBackColor = true;
            this.BigPizzaRadioButton.CheckedChanged += new System.EventHandler(this.BigPizzaRadioButton_CheckedChanged);
            // 
            // mediumPizzaRadioButton
            // 
            this.mediumPizzaRadioButton.AutoSize = true;
            this.mediumPizzaRadioButton.Location = new System.Drawing.Point(24, 89);
            this.mediumPizzaRadioButton.Name = "mediumPizzaRadioButton";
            this.mediumPizzaRadioButton.Size = new System.Drawing.Size(78, 21);
            this.mediumPizzaRadioButton.TabIndex = 1;
            this.mediumPizzaRadioButton.TabStop = true;
            this.mediumPizzaRadioButton.Text = "Средна";
            this.mediumPizzaRadioButton.UseVisualStyleBackColor = true;
            this.mediumPizzaRadioButton.CheckedChanged += new System.EventHandler(this.mediumPizzaRadioButton_CheckedChanged);
            // 
            // smallPizzaRadioButton
            // 
            this.smallPizzaRadioButton.AutoSize = true;
            this.smallPizzaRadioButton.Location = new System.Drawing.Point(24, 39);
            this.smallPizzaRadioButton.Name = "smallPizzaRadioButton";
            this.smallPizzaRadioButton.Size = new System.Drawing.Size(64, 21);
            this.smallPizzaRadioButton.TabIndex = 0;
            this.smallPizzaRadioButton.TabStop = true;
            this.smallPizzaRadioButton.Text = "Мала";
            this.smallPizzaRadioButton.UseVisualStyleBackColor = true;
            this.smallPizzaRadioButton.CheckedChanged += new System.EventHandler(this.smallPizzaRadioButton_CheckedChanged);
            // 
            // extraBox
            // 
            this.extraBox.Controls.Add(this.ketchupCheck);
            this.extraBox.Controls.Add(this.cheeseCheck);
            this.extraBox.Controls.Add(this.feferoniCheck);
            this.extraBox.Controls.Add(this.ketchupPrice);
            this.extraBox.Controls.Add(this.cheesePrice);
            this.extraBox.Controls.Add(this.feferoniPrice);
            this.extraBox.Location = new System.Drawing.Point(337, 29);
            this.extraBox.Name = "extraBox";
            this.extraBox.Size = new System.Drawing.Size(306, 193);
            this.extraBox.TabIndex = 1;
            this.extraBox.TabStop = false;
            this.extraBox.Text = "Додатоци";
            // 
            // ketchupCheck
            // 
            this.ketchupCheck.AutoSize = true;
            this.ketchupCheck.Location = new System.Drawing.Point(11, 136);
            this.ketchupCheck.Name = "ketchupCheck";
            this.ketchupCheck.Size = new System.Drawing.Size(71, 21);
            this.ketchupCheck.TabIndex = 8;
            this.ketchupCheck.Text = "Кечап";
            this.ketchupCheck.UseVisualStyleBackColor = true;
            this.ketchupCheck.CheckedChanged += new System.EventHandler(this.ketchupCheck_CheckedChanged);
            // 
            // cheeseCheck
            // 
            this.cheeseCheck.AutoSize = true;
            this.cheeseCheck.Location = new System.Drawing.Point(11, 89);
            this.cheeseCheck.Name = "cheeseCheck";
            this.cheeseCheck.Size = new System.Drawing.Size(131, 21);
            this.cheeseCheck.TabIndex = 7;
            this.cheeseCheck.Text = "Екстра сирење";
            this.cheeseCheck.UseVisualStyleBackColor = true;
            this.cheeseCheck.CheckedChanged += new System.EventHandler(this.cheeseCheck_CheckedChanged);
            // 
            // feferoniCheck
            // 
            this.feferoniCheck.AutoSize = true;
            this.feferoniCheck.Location = new System.Drawing.Point(11, 41);
            this.feferoniCheck.Name = "feferoniCheck";
            this.feferoniCheck.Size = new System.Drawing.Size(102, 21);
            this.feferoniCheck.TabIndex = 6;
            this.feferoniCheck.Text = "Феферони";
            this.feferoniCheck.UseVisualStyleBackColor = true;
            this.feferoniCheck.CheckedChanged += new System.EventHandler(this.feferoniCheck_CheckedChanged);
            // 
            // ketchupPrice
            // 
            this.ketchupPrice.Location = new System.Drawing.Point(177, 136);
            this.ketchupPrice.Name = "ketchupPrice";
            this.ketchupPrice.Size = new System.Drawing.Size(100, 22);
            this.ketchupPrice.TabIndex = 5;
            this.ketchupPrice.Text = "20";
            // 
            // cheesePrice
            // 
            this.cheesePrice.Location = new System.Drawing.Point(177, 89);
            this.cheesePrice.Name = "cheesePrice";
            this.cheesePrice.Size = new System.Drawing.Size(100, 22);
            this.cheesePrice.TabIndex = 4;
            this.cheesePrice.Text = "30";
            // 
            // feferoniPrice
            // 
            this.feferoniPrice.Location = new System.Drawing.Point(177, 38);
            this.feferoniPrice.Name = "feferoniPrice";
            this.feferoniPrice.Size = new System.Drawing.Size(100, 22);
            this.feferoniPrice.TabIndex = 3;
            this.feferoniPrice.Text = "40";
            this.feferoniPrice.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // drinkBox
            // 
            this.drinkBox.Controls.Add(this.totalDrinkLabel);
            this.drinkBox.Controls.Add(this.amountLabel);
            this.drinkBox.Controls.Add(this.priceLabel);
            this.drinkBox.Controls.Add(this.label3);
            this.drinkBox.Controls.Add(this.label2);
            this.drinkBox.Controls.Add(this.cc);
            this.drinkBox.Controls.Add(this.beerTotal);
            this.drinkBox.Controls.Add(this.appleTotal);
            this.drinkBox.Controls.Add(this.ccTotal);
            this.drinkBox.Controls.Add(this.beerPrice);
            this.drinkBox.Controls.Add(this.applePrice);
            this.drinkBox.Controls.Add(this.ccPrice);
            this.drinkBox.Controls.Add(this.beerCount);
            this.drinkBox.Controls.Add(this.appleCount);
            this.drinkBox.Controls.Add(this.ccCount);
            this.drinkBox.Location = new System.Drawing.Point(46, 228);
            this.drinkBox.Name = "drinkBox";
            this.drinkBox.Size = new System.Drawing.Size(597, 193);
            this.drinkBox.TabIndex = 2;
            this.drinkBox.TabStop = false;
            this.drinkBox.Text = "Пијалок";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Пиво";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Сок од јаболко / портокал ";
            // 
            // cc
            // 
            this.cc.AutoSize = true;
            this.cc.Location = new System.Drawing.Point(21, 42);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(188, 17);
            this.cc.TabIndex = 12;
            this.cc.Text = "Кока Кола / Фанта / Спрајт";
            // 
            // beerTotal
            // 
            this.beerTotal.Location = new System.Drawing.Point(468, 135);
            this.beerTotal.Name = "beerTotal";
            this.beerTotal.ReadOnly = true;
            this.beerTotal.Size = new System.Drawing.Size(100, 22);
            this.beerTotal.TabIndex = 11;
            // 
            // appleTotal
            // 
            this.appleTotal.Location = new System.Drawing.Point(468, 89);
            this.appleTotal.Name = "appleTotal";
            this.appleTotal.ReadOnly = true;
            this.appleTotal.Size = new System.Drawing.Size(100, 22);
            this.appleTotal.TabIndex = 10;
            // 
            // ccTotal
            // 
            this.ccTotal.Location = new System.Drawing.Point(468, 39);
            this.ccTotal.Name = "ccTotal";
            this.ccTotal.ReadOnly = true;
            this.ccTotal.Size = new System.Drawing.Size(100, 22);
            this.ccTotal.TabIndex = 9;
            // 
            // beerPrice
            // 
            this.beerPrice.Location = new System.Drawing.Point(349, 135);
            this.beerPrice.Name = "beerPrice";
            this.beerPrice.Size = new System.Drawing.Size(100, 22);
            this.beerPrice.TabIndex = 8;
            this.beerPrice.Text = "80";
            // 
            // applePrice
            // 
            this.applePrice.Location = new System.Drawing.Point(349, 89);
            this.applePrice.Name = "applePrice";
            this.applePrice.Size = new System.Drawing.Size(100, 22);
            this.applePrice.TabIndex = 7;
            this.applePrice.Text = "70";
            // 
            // ccPrice
            // 
            this.ccPrice.Location = new System.Drawing.Point(349, 39);
            this.ccPrice.Name = "ccPrice";
            this.ccPrice.Size = new System.Drawing.Size(100, 22);
            this.ccPrice.TabIndex = 6;
            this.ccPrice.Text = "60";
            // 
            // beerCount
            // 
            this.beerCount.Location = new System.Drawing.Point(227, 135);
            this.beerCount.Name = "beerCount";
            this.beerCount.Size = new System.Drawing.Size(100, 22);
            this.beerCount.TabIndex = 5;
            this.beerCount.Text = "0";
            this.beerCount.TextChanged += new System.EventHandler(this.beerCount_TextChanged);
            // 
            // appleCount
            // 
            this.appleCount.Location = new System.Drawing.Point(227, 89);
            this.appleCount.Name = "appleCount";
            this.appleCount.Size = new System.Drawing.Size(100, 22);
            this.appleCount.TabIndex = 4;
            this.appleCount.Text = "0";
            this.appleCount.TextChanged += new System.EventHandler(this.appleCount_TextChanged);
            // 
            // ccCount
            // 
            this.ccCount.Location = new System.Drawing.Point(227, 39);
            this.ccCount.Name = "ccCount";
            this.ccCount.Size = new System.Drawing.Size(100, 22);
            this.ccCount.TabIndex = 3;
            this.ccCount.Text = "0";
            this.ccCount.TextChanged += new System.EventHandler(this.ccCount_TextChanged);
            // 
            // desertBox
            // 
            this.desertBox.Controls.Add(this.desertNameLabel);
            this.desertBox.Controls.Add(this.desertNameBox);
            this.desertBox.Controls.Add(this.cancelDesert);
            this.desertBox.Controls.Add(this.orderDesert);
            this.desertBox.Controls.Add(this.desertPriceLabel);
            this.desertBox.Controls.Add(this.desertPrice);
            this.desertBox.Location = new System.Drawing.Point(46, 437);
            this.desertBox.Name = "desertBox";
            this.desertBox.Size = new System.Drawing.Size(285, 193);
            this.desertBox.TabIndex = 3;
            this.desertBox.TabStop = false;
            this.desertBox.Text = "Десерт";
            // 
            // cancelDesert
            // 
            this.cancelDesert.Location = new System.Drawing.Point(38, 149);
            this.cancelDesert.Name = "cancelDesert";
            this.cancelDesert.Size = new System.Drawing.Size(75, 23);
            this.cancelDesert.TabIndex = 7;
            this.cancelDesert.Text = "Откажи";
            this.cancelDesert.UseVisualStyleBackColor = true;
            this.cancelDesert.Click += new System.EventHandler(this.cancelDesert_Click);
            // 
            // orderDesert
            // 
            this.orderDesert.Location = new System.Drawing.Point(162, 149);
            this.orderDesert.Name = "orderDesert";
            this.orderDesert.Size = new System.Drawing.Size(75, 23);
            this.orderDesert.TabIndex = 6;
            this.orderDesert.Text = "Нарачај";
            this.orderDesert.UseVisualStyleBackColor = true;
            this.orderDesert.Click += new System.EventHandler(this.orderDesert_Click);
            // 
            // desertPriceLabel
            // 
            this.desertPriceLabel.AutoSize = true;
            this.desertPriceLabel.Location = new System.Drawing.Point(21, 79);
            this.desertPriceLabel.Name = "desertPriceLabel";
            this.desertPriceLabel.Size = new System.Drawing.Size(113, 17);
            this.desertPriceLabel.TabIndex = 5;
            this.desertPriceLabel.Text = "Цена на десерт";
            // 
            // desertPrice
            // 
            this.desertPrice.Location = new System.Drawing.Point(24, 99);
            this.desertPrice.Name = "desertPrice";
            this.desertPrice.Size = new System.Drawing.Size(238, 22);
            this.desertPrice.TabIndex = 3;
            this.desertPrice.TextChanged += new System.EventHandler(this.desertPrice_TextChanged);
            // 
            // paymentBox
            // 
            this.paymentBox.Controls.Add(this.changeLabel);
            this.paymentBox.Controls.Add(this.payedLabel);
            this.paymentBox.Controls.Add(this.totalPaymentLabel);
            this.paymentBox.Controls.Add(this.changeBox);
            this.paymentBox.Controls.Add(this.payedBox);
            this.paymentBox.Controls.Add(this.totalBox);
            this.paymentBox.Location = new System.Drawing.Point(337, 437);
            this.paymentBox.Name = "paymentBox";
            this.paymentBox.Size = new System.Drawing.Size(306, 193);
            this.paymentBox.TabIndex = 4;
            this.paymentBox.TabStop = false;
            this.paymentBox.Text = "Наплата";
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Location = new System.Drawing.Point(22, 142);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(91, 17);
            this.changeLabel.TabIndex = 8;
            this.changeLabel.Text = "За враќање:";
            this.changeLabel.Click += new System.EventHandler(this.changeLabel_Click);
            // 
            // payedLabel
            // 
            this.payedLabel.AutoSize = true;
            this.payedLabel.Location = new System.Drawing.Point(19, 92);
            this.payedLabel.Name = "payedLabel";
            this.payedLabel.Size = new System.Drawing.Size(85, 17);
            this.payedLabel.TabIndex = 7;
            this.payedLabel.Text = "Наплатено:";
            // 
            // totalPaymentLabel
            // 
            this.totalPaymentLabel.AutoSize = true;
            this.totalPaymentLabel.Location = new System.Drawing.Point(19, 42);
            this.totalPaymentLabel.Name = "totalPaymentLabel";
            this.totalPaymentLabel.Size = new System.Drawing.Size(137, 17);
            this.totalPaymentLabel.TabIndex = 6;
            this.totalPaymentLabel.Text = "Вкупно за наплата:";
            // 
            // changeBox
            // 
            this.changeBox.Location = new System.Drawing.Point(162, 135);
            this.changeBox.Name = "changeBox";
            this.changeBox.Size = new System.Drawing.Size(115, 22);
            this.changeBox.TabIndex = 5;
            // 
            // payedBox
            // 
            this.payedBox.Location = new System.Drawing.Point(162, 89);
            this.payedBox.Name = "payedBox";
            this.payedBox.Size = new System.Drawing.Size(115, 22);
            this.payedBox.TabIndex = 4;
            this.payedBox.TextChanged += new System.EventHandler(this.payedBox_TextChanged);
            // 
            // totalBox
            // 
            this.totalBox.Location = new System.Drawing.Point(162, 39);
            this.totalBox.Name = "totalBox";
            this.totalBox.ReadOnly = true;
            this.totalBox.Size = new System.Drawing.Size(115, 22);
            this.totalBox.TabIndex = 3;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(381, 18);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(43, 17);
            this.priceLabel.TabIndex = 15;
            this.priceLabel.Text = "Цена";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(242, 19);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(73, 17);
            this.amountLabel.TabIndex = 16;
            this.amountLabel.Text = "Количина";
            this.amountLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // totalDrinkLabel
            // 
            this.totalDrinkLabel.AutoSize = true;
            this.totalDrinkLabel.Location = new System.Drawing.Point(487, 18);
            this.totalDrinkLabel.Name = "totalDrinkLabel";
            this.totalDrinkLabel.Size = new System.Drawing.Size(55, 17);
            this.totalDrinkLabel.TabIndex = 17;
            this.totalDrinkLabel.Text = "Вкупно";
            // 
            // desertNameBox
            // 
            this.desertNameBox.Location = new System.Drawing.Point(24, 49);
            this.desertNameBox.Name = "desertNameBox";
            this.desertNameBox.Size = new System.Drawing.Size(238, 22);
            this.desertNameBox.TabIndex = 8;
            // 
            // desertNameLabel
            // 
            this.desertNameLabel.AutoSize = true;
            this.desertNameLabel.Location = new System.Drawing.Point(24, 26);
            this.desertNameLabel.Name = "desertNameLabel";
            this.desertNameLabel.Size = new System.Drawing.Size(39, 17);
            this.desertNameLabel.TabIndex = 9;
            this.desertNameLabel.Text = "Име:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 649);
            this.Controls.Add(this.paymentBox);
            this.Controls.Add(this.desertBox);
            this.Controls.Add(this.drinkBox);
            this.Controls.Add(this.extraBox);
            this.Controls.Add(this.sizeBox);
            this.Name = "Form1";
            this.Text = "Нарачка на пица";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sizeBox.ResumeLayout(false);
            this.sizeBox.PerformLayout();
            this.extraBox.ResumeLayout(false);
            this.extraBox.PerformLayout();
            this.drinkBox.ResumeLayout(false);
            this.drinkBox.PerformLayout();
            this.desertBox.ResumeLayout(false);
            this.desertBox.PerformLayout();
            this.paymentBox.ResumeLayout(false);
            this.paymentBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox sizeBox;
        private System.Windows.Forms.RadioButton smallPizzaRadioButton;
        private System.Windows.Forms.RadioButton BigPizzaRadioButton;
        private System.Windows.Forms.RadioButton mediumPizzaRadioButton;
        private System.Windows.Forms.TextBox bigPizzaPrice;
        private System.Windows.Forms.TextBox mediumPizzaPrice;
        private System.Windows.Forms.TextBox smallPizzaPrice;
        private System.Windows.Forms.GroupBox extraBox;
        private System.Windows.Forms.CheckBox ketchupCheck;
        private System.Windows.Forms.CheckBox cheeseCheck;
        private System.Windows.Forms.CheckBox feferoniCheck;
        private System.Windows.Forms.TextBox ketchupPrice;
        private System.Windows.Forms.TextBox cheesePrice;
        private System.Windows.Forms.TextBox feferoniPrice;
        private System.Windows.Forms.GroupBox drinkBox;
        private System.Windows.Forms.TextBox beerCount;
        private System.Windows.Forms.TextBox appleCount;
        private System.Windows.Forms.TextBox ccCount;
        private System.Windows.Forms.TextBox beerTotal;
        private System.Windows.Forms.TextBox appleTotal;
        private System.Windows.Forms.TextBox ccTotal;
        private System.Windows.Forms.TextBox beerPrice;
        private System.Windows.Forms.TextBox applePrice;
        private System.Windows.Forms.TextBox ccPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cc;
        private System.Windows.Forms.GroupBox desertBox;
        private System.Windows.Forms.Label desertPriceLabel;
        private System.Windows.Forms.TextBox desertPrice;
        private System.Windows.Forms.Button cancelDesert;
        private System.Windows.Forms.Button orderDesert;
        private System.Windows.Forms.GroupBox paymentBox;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label payedLabel;
        private System.Windows.Forms.Label totalPaymentLabel;
        private System.Windows.Forms.TextBox changeBox;
        private System.Windows.Forms.TextBox payedBox;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label totalDrinkLabel;
        private System.Windows.Forms.Label desertNameLabel;
        private System.Windows.Forms.TextBox desertNameBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

