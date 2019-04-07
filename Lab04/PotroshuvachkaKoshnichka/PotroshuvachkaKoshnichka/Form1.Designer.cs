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
            this.productList = new System.Windows.Forms.ListBox();
            this.productListLabel = new System.Windows.Forms.Label();
            this.clearProductListButton = new System.Windows.Forms.Button();
            this.productDetails = new System.Windows.Forms.GroupBox();
            this.productPriceLabel = new System.Windows.Forms.Label();
            this.productPrice = new System.Windows.Forms.TextBox();
            this.productCategoryLabel = new System.Windows.Forms.Label();
            this.productCategory = new System.Windows.Forms.TextBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.TextBox();
            this.productBasket = new System.Windows.Forms.ListBox();
            this.productBasketLabel = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.TextBox();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.resetBasketButton = new System.Windows.Forms.Button();
            this.addToBasketButton = new System.Windows.Forms.Button();
            this.removeFromBasketButton = new System.Windows.Forms.Button();
            this.addNewProductButton = new System.Windows.Forms.Button();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.productDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // productList
            // 
            this.productList.FormattingEnabled = true;
            this.productList.ItemHeight = 16;
            this.productList.Location = new System.Drawing.Point(13, 45);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(286, 356);
            this.productList.TabIndex = 0;
            this.productList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // productListLabel
            // 
            this.productListLabel.AutoSize = true;
            this.productListLabel.Location = new System.Drawing.Point(13, 22);
            this.productListLabel.Name = "productListLabel";
            this.productListLabel.Size = new System.Drawing.Size(137, 17);
            this.productListLabel.TabIndex = 1;
            this.productListLabel.Text = "Листа на продукти:";
            this.productListLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // clearProductListButton
            // 
            this.clearProductListButton.Location = new System.Drawing.Point(12, 415);
            this.clearProductListButton.Name = "clearProductListButton";
            this.clearProductListButton.Size = new System.Drawing.Size(287, 23);
            this.clearProductListButton.TabIndex = 2;
            this.clearProductListButton.Text = "Испразни ја листата со продукти?";
            this.clearProductListButton.UseVisualStyleBackColor = true;
            // 
            // productDetails
            // 
            this.productDetails.Controls.Add(this.productPriceLabel);
            this.productDetails.Controls.Add(this.productPrice);
            this.productDetails.Controls.Add(this.productCategoryLabel);
            this.productDetails.Controls.Add(this.productCategory);
            this.productDetails.Controls.Add(this.productNameLabel);
            this.productDetails.Controls.Add(this.productName);
            this.productDetails.Location = new System.Drawing.Point(306, 45);
            this.productDetails.Name = "productDetails";
            this.productDetails.Size = new System.Drawing.Size(208, 204);
            this.productDetails.TabIndex = 3;
            this.productDetails.TabStop = false;
            this.productDetails.Text = "Детали за продуктот";
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.Location = new System.Drawing.Point(7, 121);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(47, 17);
            this.productPriceLabel.TabIndex = 5;
            this.productPriceLabel.Text = "Цена:";
            // 
            // productPrice
            // 
            this.productPrice.Location = new System.Drawing.Point(7, 147);
            this.productPrice.Name = "productPrice";
            this.productPrice.ReadOnly = true;
            this.productPrice.Size = new System.Drawing.Size(100, 22);
            this.productPrice.TabIndex = 4;
            this.productPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // productCategoryLabel
            // 
            this.productCategoryLabel.AutoSize = true;
            this.productCategoryLabel.Location = new System.Drawing.Point(7, 72);
            this.productCategoryLabel.Name = "productCategoryLabel";
            this.productCategoryLabel.Size = new System.Drawing.Size(84, 17);
            this.productCategoryLabel.TabIndex = 3;
            this.productCategoryLabel.Text = "Категорија:";
            // 
            // productCategory
            // 
            this.productCategory.Location = new System.Drawing.Point(7, 92);
            this.productCategory.Name = "productCategory";
            this.productCategory.ReadOnly = true;
            this.productCategory.Size = new System.Drawing.Size(195, 22);
            this.productCategory.TabIndex = 2;
            this.productCategory.TextChanged += new System.EventHandler(this.productCategory_TextChanged);
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(7, 22);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(131, 17);
            this.productNameLabel.TabIndex = 1;
            this.productNameLabel.Text = "Име на продуктот:";
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(7, 43);
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            this.productName.Size = new System.Drawing.Size(195, 22);
            this.productName.TabIndex = 0;
            // 
            // productBasket
            // 
            this.productBasket.FormattingEnabled = true;
            this.productBasket.ItemHeight = 16;
            this.productBasket.Location = new System.Drawing.Point(521, 45);
            this.productBasket.Name = "productBasket";
            this.productBasket.Size = new System.Drawing.Size(297, 308);
            this.productBasket.TabIndex = 4;
            // 
            // productBasketLabel
            // 
            this.productBasketLabel.AutoSize = true;
            this.productBasketLabel.Location = new System.Drawing.Point(521, 21);
            this.productBasketLabel.Name = "productBasketLabel";
            this.productBasketLabel.Size = new System.Drawing.Size(79, 17);
            this.productBasketLabel.TabIndex = 5;
            this.productBasketLabel.Text = "Кошничка:";
            // 
            // totalPrice
            // 
            this.totalPrice.Location = new System.Drawing.Point(586, 378);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            this.totalPrice.Size = new System.Drawing.Size(231, 22);
            this.totalPrice.TabIndex = 6;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(521, 381);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(59, 17);
            this.totalPriceLabel.TabIndex = 7;
            this.totalPriceLabel.Text = "Вкупно:";
            // 
            // resetBasketButton
            // 
            this.resetBasketButton.Location = new System.Drawing.Point(521, 415);
            this.resetBasketButton.Name = "resetBasketButton";
            this.resetBasketButton.Size = new System.Drawing.Size(297, 23);
            this.resetBasketButton.TabIndex = 8;
            this.resetBasketButton.Text = "Испразни ја кошничката?";
            this.resetBasketButton.UseVisualStyleBackColor = true;
            // 
            // addToBasketButton
            // 
            this.addToBasketButton.Location = new System.Drawing.Point(305, 255);
            this.addToBasketButton.Name = "addToBasketButton";
            this.addToBasketButton.Size = new System.Drawing.Size(208, 23);
            this.addToBasketButton.TabIndex = 9;
            this.addToBasketButton.Text = "Додади во кошничка >>";
            this.addToBasketButton.UseVisualStyleBackColor = true;
            this.addToBasketButton.Click += new System.EventHandler(this.addToBasketButton_Click);
            // 
            // removeFromBasketButton
            // 
            this.removeFromBasketButton.Location = new System.Drawing.Point(305, 295);
            this.removeFromBasketButton.Name = "removeFromBasketButton";
            this.removeFromBasketButton.Size = new System.Drawing.Size(208, 23);
            this.removeFromBasketButton.TabIndex = 10;
            this.removeFromBasketButton.Text = "Избриши од кошничка";
            this.removeFromBasketButton.UseVisualStyleBackColor = true;
            this.removeFromBasketButton.Click += new System.EventHandler(this.removeFromBasketButton_Click);
            // 
            // addNewProductButton
            // 
            this.addNewProductButton.Location = new System.Drawing.Point(305, 339);
            this.addNewProductButton.Name = "addNewProductButton";
            this.addNewProductButton.Size = new System.Drawing.Size(208, 23);
            this.addNewProductButton.TabIndex = 14;
            this.addNewProductButton.Text = "Додај нов продукт";
            this.addNewProductButton.UseVisualStyleBackColor = true;
            this.addNewProductButton.Click += new System.EventHandler(this.addNewProductButton_Click);
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Location = new System.Drawing.Point(305, 377);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(208, 23);
            this.deleteProductButton.TabIndex = 15;
            this.deleteProductButton.Text = "Избриши продукт";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.addNewProductButton);
            this.Controls.Add(this.removeFromBasketButton);
            this.Controls.Add(this.addToBasketButton);
            this.Controls.Add(this.resetBasketButton);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.productBasketLabel);
            this.Controls.Add(this.productBasket);
            this.Controls.Add(this.productDetails);
            this.Controls.Add(this.clearProductListButton);
            this.Controls.Add(this.productListLabel);
            this.Controls.Add(this.productList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.productDetails.ResumeLayout(false);
            this.productDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox productList;
        private System.Windows.Forms.Label productListLabel;
        private System.Windows.Forms.Button clearProductListButton;
        private System.Windows.Forms.GroupBox productDetails;
        private System.Windows.Forms.Label productCategoryLabel;
        private System.Windows.Forms.TextBox productCategory;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.Label productPriceLabel;
        private System.Windows.Forms.TextBox productPrice;
        private System.Windows.Forms.ListBox productBasket;
        private System.Windows.Forms.Label productBasketLabel;
        private System.Windows.Forms.TextBox totalPrice;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Button resetBasketButton;
        private System.Windows.Forms.Button addToBasketButton;
        private System.Windows.Forms.Button removeFromBasketButton;
        private System.Windows.Forms.Button addNewProductButton;
        private System.Windows.Forms.Button deleteProductButton;
    }
}

