using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PotroshuvachkaKoshnichka
{
    public partial class Form1 : Form
    {
        private List<Product> products;
        private List<Product> productsBasketList;
        public Form1()
        {
            InitializeComponent();
            products = new List<Product>();
            productsBasketList = new List<Product>();

            //tempProducts
            Product p1 = new Product("Месо", "Храна", 100.00);
            products.Add(p1);

            Product p2 = new Product("Млеко", "Храна", 50.00);
            products.Add(p2);

            Product p3 = new Product("Вино", "Алкохол", 300.00);
            products.Add(p3);

            Product p4 = new Product("Пиво", "Алкохол", 100.00);
            products.Add(p4);

            Product p5 = new Product("Шампон", "Хигиена", 150.00);
            products.Add(p5);

            Product p6 = new Product("Паста за заби", "Хигиена", 80.00);
            products.Add(p6);

            productList.DataSource = products;
            productBasket.DataSource = productsBasketList;
        }

        private void updateProductInfoAll(object sender, EventArgs e)
        {
           String selected = productList.GetItemText(productList.SelectedItem);

           if (!(selected.Equals(null) || selected.Equals("")))
            {
                Product selectedProduct = products.Find(prod => prod.productName.Equals(selected));
                productName.Text = selectedProduct.productName;
                productCategory.Text = selectedProduct.productCategory;
                productPrice.Text = String.Format("{0:0.00}",selectedProduct.productPrice);
            }
        }

        private void updateProductInfoBasket(object sender, EventArgs e)
        {
            String selected = productBasket.GetItemText(productBasket.SelectedItem);

            if (!(selected.Equals(null) || selected.Equals("")))
            {
                Product selectedProduct = products.Find(prod => prod.productName.Equals(selected));
                productName.Text = selectedProduct.productName;
                productCategory.Text = selectedProduct.productCategory;
                productPrice.Text = String.Format("{0:0.00}", selectedProduct.productPrice);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!(productList.SelectedItem == null))
                updateProductInfoAll(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void productCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void removeFromBasketButton_Click(object sender, EventArgs e)
        {

        }

        private void addNewProductButton_Click(object sender, EventArgs e)
        {

        }

        private void addToBasketButton_Click(object sender, EventArgs e)
        {

        }
    }
    public class Product
    {

        public Product(string productName, string productCategory, double productPrice)
        {
            this.productName = productName ?? throw new ArgumentNullException(nameof(productName));
            this.productCategory = productCategory ?? throw new ArgumentNullException(nameof(productCategory));
            this.productPrice = productPrice;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public String productName { get; set; }
        public String productCategory { get; set; }
        public double productPrice { get; set; }

        public override string ToString()
        {
            return this.productName;
        }

        public override int GetHashCode()
        {
            var hashCode = -1107612236;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(productName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(productCategory);
            hashCode = hashCode * -1521134295 + productPrice.GetHashCode();
            return hashCode;
        }
    }
}
