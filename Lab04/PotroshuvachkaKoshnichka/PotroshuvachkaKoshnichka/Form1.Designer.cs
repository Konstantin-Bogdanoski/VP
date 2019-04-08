namespace PotroshuvachkaKoshnichka
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
            this.productListBox = new System.Windows.Forms.ListBox();
            this.basketListBox = new System.Windows.Forms.ListBox();
            this.productListBoxLabel = new System.Windows.Forms.Label();
            this.basketListBoxLabel = new System.Windows.Forms.Label();
            this.clearProductListBoxButton = new System.Windows.Forms.Button();
            this.clearBasketListBoxButton = new System.Windows.Forms.Button();
            this.productDetailsBox = new System.Windows.Forms.GroupBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productCategoryTextBox = new System.Windows.Forms.TextBox();
            this.productCategoryLabel = new System.Windows.Forms.Label();
            this.productPriceTextBox = new System.Windows.Forms.TextBox();
            this.productPriceLabel = new System.Windows.Forms.Label();
            this.addToBasketButton = new System.Windows.Forms.Button();
            this.removeFromBasketButton = new System.Windows.Forms.Button();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.productDetailsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // productListBox
            // 
            this.productListBox.FormattingEnabled = true;
            this.productListBox.ItemHeight = 16;
            this.productListBox.Location = new System.Drawing.Point(13, 31);
            this.productListBox.Name = "productListBox";
            this.productListBox.Size = new System.Drawing.Size(253, 356);
            this.productListBox.TabIndex = 0;
            this.productListBox.SelectedIndexChanged += new System.EventHandler(this.productListBox_SelectedIndexChanged);
            // 
            // basketListBox
            // 
            this.basketListBox.FormattingEnabled = true;
            this.basketListBox.ItemHeight = 16;
            this.basketListBox.Location = new System.Drawing.Point(535, 31);
            this.basketListBox.Name = "basketListBox";
            this.basketListBox.Size = new System.Drawing.Size(253, 308);
            this.basketListBox.TabIndex = 1;
            // 
            // productListBoxLabel
            // 
            this.productListBoxLabel.AutoSize = true;
            this.productListBoxLabel.Location = new System.Drawing.Point(13, 8);
            this.productListBoxLabel.Name = "productListBoxLabel";
            this.productListBoxLabel.Size = new System.Drawing.Size(133, 17);
            this.productListBoxLabel.TabIndex = 2;
            this.productListBoxLabel.Text = "Листа на продукти";
            // 
            // basketListBoxLabel
            // 
            this.basketListBoxLabel.AutoSize = true;
            this.basketListBoxLabel.Location = new System.Drawing.Point(535, 8);
            this.basketListBoxLabel.Name = "basketListBoxLabel";
            this.basketListBoxLabel.Size = new System.Drawing.Size(75, 17);
            this.basketListBoxLabel.TabIndex = 3;
            this.basketListBoxLabel.Text = "Кошничка";
            // 
            // clearProductListBoxButton
            // 
            this.clearProductListBoxButton.Location = new System.Drawing.Point(12, 398);
            this.clearProductListBoxButton.Name = "clearProductListBoxButton";
            this.clearProductListBoxButton.Size = new System.Drawing.Size(253, 42);
            this.clearProductListBoxButton.TabIndex = 4;
            this.clearProductListBoxButton.Text = "Испразни ја листата на продукти?";
            this.clearProductListBoxButton.UseVisualStyleBackColor = true;
            this.clearProductListBoxButton.Click += new System.EventHandler(this.clearProductListBoxButton_Click);
            // 
            // clearBasketListBoxButton
            // 
            this.clearBasketListBoxButton.Location = new System.Drawing.Point(535, 398);
            this.clearBasketListBoxButton.Name = "clearBasketListBoxButton";
            this.clearBasketListBoxButton.Size = new System.Drawing.Size(253, 42);
            this.clearBasketListBoxButton.TabIndex = 5;
            this.clearBasketListBoxButton.Text = "Испразни ја кошничката?";
            this.clearBasketListBoxButton.UseVisualStyleBackColor = true;
            this.clearBasketListBoxButton.Click += new System.EventHandler(this.clearBasketListBoxButton_Click);
            // 
            // productDetailsBox
            // 
            this.productDetailsBox.Controls.Add(this.productPriceTextBox);
            this.productDetailsBox.Controls.Add(this.productPriceLabel);
            this.productDetailsBox.Controls.Add(this.productCategoryTextBox);
            this.productDetailsBox.Controls.Add(this.productCategoryLabel);
            this.productDetailsBox.Controls.Add(this.productNameTextBox);
            this.productDetailsBox.Controls.Add(this.productNameLabel);
            this.productDetailsBox.Location = new System.Drawing.Point(273, 31);
            this.productDetailsBox.Name = "productDetailsBox";
            this.productDetailsBox.Size = new System.Drawing.Size(256, 216);
            this.productDetailsBox.TabIndex = 6;
            this.productDetailsBox.TabStop = false;
            this.productDetailsBox.Text = "Детали за продуктот";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(7, 22);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(112, 17);
            this.productNameLabel.TabIndex = 0;
            this.productNameLabel.Text = "Име на продукт";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(10, 43);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.ReadOnly = true;
            this.productNameTextBox.Size = new System.Drawing.Size(240, 22);
            this.productNameTextBox.TabIndex = 1;
            // 
            // productCategoryTextBox
            // 
            this.productCategoryTextBox.Location = new System.Drawing.Point(10, 108);
            this.productCategoryTextBox.Name = "productCategoryTextBox";
            this.productCategoryTextBox.ReadOnly = true;
            this.productCategoryTextBox.Size = new System.Drawing.Size(240, 22);
            this.productCategoryTextBox.TabIndex = 3;
            // 
            // productCategoryLabel
            // 
            this.productCategoryLabel.AutoSize = true;
            this.productCategoryLabel.Location = new System.Drawing.Point(7, 87);
            this.productCategoryLabel.Name = "productCategoryLabel";
            this.productCategoryLabel.Size = new System.Drawing.Size(157, 17);
            this.productCategoryLabel.TabIndex = 2;
            this.productCategoryLabel.Text = "Категорија на продукт";
            // 
            // productPriceTextBox
            // 
            this.productPriceTextBox.Location = new System.Drawing.Point(10, 177);
            this.productPriceTextBox.Name = "productPriceTextBox";
            this.productPriceTextBox.ReadOnly = true;
            this.productPriceTextBox.Size = new System.Drawing.Size(240, 22);
            this.productPriceTextBox.TabIndex = 5;
            this.productPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.Location = new System.Drawing.Point(7, 157);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(120, 17);
            this.productPriceLabel.TabIndex = 4;
            this.productPriceLabel.Text = "Цена на продукт";
            // 
            // addToBasketButton
            // 
            this.addToBasketButton.Location = new System.Drawing.Point(273, 254);
            this.addToBasketButton.Name = "addToBasketButton";
            this.addToBasketButton.Size = new System.Drawing.Size(256, 42);
            this.addToBasketButton.TabIndex = 7;
            this.addToBasketButton.Text = "Додади во кошничка >>";
            this.addToBasketButton.UseVisualStyleBackColor = true;
            this.addToBasketButton.Click += new System.EventHandler(this.addToBasketButton_Click);
            // 
            // removeFromBasketButton
            // 
            this.removeFromBasketButton.Location = new System.Drawing.Point(273, 302);
            this.removeFromBasketButton.Name = "removeFromBasketButton";
            this.removeFromBasketButton.Size = new System.Drawing.Size(256, 42);
            this.removeFromBasketButton.TabIndex = 8;
            this.removeFromBasketButton.Text = "Избриши од кошничка";
            this.removeFromBasketButton.UseVisualStyleBackColor = true;
            this.removeFromBasketButton.Click += new System.EventHandler(this.removeFromBasketButton_Click);
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Location = new System.Drawing.Point(273, 350);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(256, 42);
            this.deleteProductButton.TabIndex = 9;
            this.deleteProductButton.Text = "Избриши продукт";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(271, 398);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(256, 42);
            this.addProductButton.TabIndex = 10;
            this.addProductButton.Text = "Додај нов продукт";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.Location = new System.Drawing.Point(624, 360);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.ReadOnly = true;
            this.totalPriceTextBox.Size = new System.Drawing.Size(164, 22);
            this.totalPriceTextBox.TabIndex = 6;
            this.totalPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(555, 363);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(55, 17);
            this.totalPriceLabel.TabIndex = 6;
            this.totalPriceLabel.Text = "Вкупно";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.totalPriceTextBox);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.removeFromBasketButton);
            this.Controls.Add(this.addToBasketButton);
            this.Controls.Add(this.productDetailsBox);
            this.Controls.Add(this.clearBasketListBoxButton);
            this.Controls.Add(this.clearProductListBoxButton);
            this.Controls.Add(this.basketListBoxLabel);
            this.Controls.Add(this.productListBoxLabel);
            this.Controls.Add(this.basketListBox);
            this.Controls.Add(this.productListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.productDetailsBox.ResumeLayout(false);
            this.productDetailsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox productListBox;
        private System.Windows.Forms.ListBox basketListBox;
        private System.Windows.Forms.Label productListBoxLabel;
        private System.Windows.Forms.Label basketListBoxLabel;
        private System.Windows.Forms.Button clearProductListBoxButton;
        private System.Windows.Forms.Button clearBasketListBoxButton;
        private System.Windows.Forms.GroupBox productDetailsBox;
        private System.Windows.Forms.TextBox productPriceTextBox;
        private System.Windows.Forms.Label productPriceLabel;
        private System.Windows.Forms.TextBox productCategoryTextBox;
        private System.Windows.Forms.Label productCategoryLabel;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Button addToBasketButton;
        private System.Windows.Forms.Button removeFromBasketButton;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.TextBox totalPriceTextBox;
        private System.Windows.Forms.Label totalPriceLabel;
    }
}

