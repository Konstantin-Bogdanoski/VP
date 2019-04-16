namespace PotroshuvachkaKoshnichka
{
    partial class Form2
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
            this.addNewProductButton = new System.Windows.Forms.Button();
            this.cancelNewProductButton = new System.Windows.Forms.Button();
            this.newProductLabel = new System.Windows.Forms.Label();
            this.newProductNameTextBox = new System.Windows.Forms.TextBox();
            this.newProductCategoryTextBox = new System.Windows.Forms.TextBox();
            this.newProductCategoryLabel = new System.Windows.Forms.Label();
            this.newProductPriceTextBox = new System.Windows.Forms.TextBox();
            this.newProductPriceLabel = new System.Windows.Forms.Label();
            this.productQuantityLabel = new System.Windows.Forms.Label();
            this.numericProductQuantity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericProductQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewProductButton
            // 
            this.addNewProductButton.Location = new System.Drawing.Point(11, 245);
            this.addNewProductButton.Name = "addNewProductButton";
            this.addNewProductButton.Size = new System.Drawing.Size(113, 49);
            this.addNewProductButton.TabIndex = 0;
            this.addNewProductButton.Text = "Додај продукт";
            this.addNewProductButton.UseVisualStyleBackColor = true;
            this.addNewProductButton.Click += new System.EventHandler(this.addNewProductButton_Click);
            // 
            // cancelNewProductButton
            // 
            this.cancelNewProductButton.Location = new System.Drawing.Point(214, 245);
            this.cancelNewProductButton.Name = "cancelNewProductButton";
            this.cancelNewProductButton.Size = new System.Drawing.Size(113, 49);
            this.cancelNewProductButton.TabIndex = 1;
            this.cancelNewProductButton.Text = "Откажи";
            this.cancelNewProductButton.UseVisualStyleBackColor = true;
            this.cancelNewProductButton.Click += new System.EventHandler(this.cancelNewProductButton_Click);
            // 
            // newProductLabel
            // 
            this.newProductLabel.AutoSize = true;
            this.newProductLabel.Location = new System.Drawing.Point(12, 13);
            this.newProductLabel.Name = "newProductLabel";
            this.newProductLabel.Size = new System.Drawing.Size(112, 17);
            this.newProductLabel.TabIndex = 2;
            this.newProductLabel.Text = "Име на продукт";
            // 
            // newProductNameTextBox
            // 
            this.newProductNameTextBox.Location = new System.Drawing.Point(15, 34);
            this.newProductNameTextBox.Name = "newProductNameTextBox";
            this.newProductNameTextBox.Size = new System.Drawing.Size(312, 22);
            this.newProductNameTextBox.TabIndex = 3;
            // 
            // newProductCategoryTextBox
            // 
            this.newProductCategoryTextBox.Location = new System.Drawing.Point(15, 86);
            this.newProductCategoryTextBox.Name = "newProductCategoryTextBox";
            this.newProductCategoryTextBox.Size = new System.Drawing.Size(312, 22);
            this.newProductCategoryTextBox.TabIndex = 5;
            // 
            // newProductCategoryLabel
            // 
            this.newProductCategoryLabel.AutoSize = true;
            this.newProductCategoryLabel.Location = new System.Drawing.Point(12, 65);
            this.newProductCategoryLabel.Name = "newProductCategoryLabel";
            this.newProductCategoryLabel.Size = new System.Drawing.Size(157, 17);
            this.newProductCategoryLabel.TabIndex = 4;
            this.newProductCategoryLabel.Text = "Категорија на продукт";
            // 
            // newProductPriceTextBox
            // 
            this.newProductPriceTextBox.Location = new System.Drawing.Point(15, 135);
            this.newProductPriceTextBox.Name = "newProductPriceTextBox";
            this.newProductPriceTextBox.Size = new System.Drawing.Size(312, 22);
            this.newProductPriceTextBox.TabIndex = 7;
            this.newProductPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // newProductPriceLabel
            // 
            this.newProductPriceLabel.AutoSize = true;
            this.newProductPriceLabel.Location = new System.Drawing.Point(12, 115);
            this.newProductPriceLabel.Name = "newProductPriceLabel";
            this.newProductPriceLabel.Size = new System.Drawing.Size(120, 17);
            this.newProductPriceLabel.TabIndex = 6;
            this.newProductPriceLabel.Text = "Цена на продукт";
            // 
            // productQuantityLabel
            // 
            this.productQuantityLabel.AutoSize = true;
            this.productQuantityLabel.Location = new System.Drawing.Point(12, 166);
            this.productQuantityLabel.Name = "productQuantityLabel";
            this.productQuantityLabel.Size = new System.Drawing.Size(55, 17);
            this.productQuantityLabel.TabIndex = 8;
            this.productQuantityLabel.Text = "Залиха";
            // 
            // numericProductQuantity
            // 
            this.numericProductQuantity.Location = new System.Drawing.Point(15, 187);
            this.numericProductQuantity.Name = "numericProductQuantity";
            this.numericProductQuantity.Size = new System.Drawing.Size(312, 22);
            this.numericProductQuantity.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 306);
            this.Controls.Add(this.numericProductQuantity);
            this.Controls.Add(this.productQuantityLabel);
            this.Controls.Add(this.newProductPriceTextBox);
            this.Controls.Add(this.newProductPriceLabel);
            this.Controls.Add(this.newProductCategoryTextBox);
            this.Controls.Add(this.newProductCategoryLabel);
            this.Controls.Add(this.newProductNameTextBox);
            this.Controls.Add(this.newProductLabel);
            this.Controls.Add(this.cancelNewProductButton);
            this.Controls.Add(this.addNewProductButton);
            this.Name = "Form2";
            this.Text = "НОВ ПРОДУКТ";
            ((System.ComponentModel.ISupportInitialize)(this.numericProductQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNewProductButton;
        private System.Windows.Forms.Button cancelNewProductButton;
        private System.Windows.Forms.Label newProductLabel;
        private System.Windows.Forms.TextBox newProductNameTextBox;
        private System.Windows.Forms.TextBox newProductCategoryTextBox;
        private System.Windows.Forms.Label newProductCategoryLabel;
        private System.Windows.Forms.TextBox newProductPriceTextBox;
        private System.Windows.Forms.Label newProductPriceLabel;
        private System.Windows.Forms.Label productQuantityLabel;
        private System.Windows.Forms.NumericUpDown numericProductQuantity;
    }
}