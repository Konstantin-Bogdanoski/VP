using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PotroshuvachkaKoshnichka
{
    public partial class Form1 : Form
    {
        private List<Product> productList;
        private List<Product> basketList;
        public Form1()
        {
            InitializeComponent();
            productList = new List<Product>();
            basketList = new List<Product>();

            Product p1 = new Product("Месо","Храна",100);
            productList.Add(p1);
            Product p2 = new Product("Млеко", "Храна", 50);
            productList.Add(p2);
            Product p3 = new Product("Вино", "Алкохол", 300);
            productList.Add(p3);
            Product p4 = new Product("Пиво", "Алкохол", 100);
            productList.Add(p4);
            Product p5 = new Product("Шампон", "Хигиена", 150);
            productList.Add(p5);
            Product p6 = new Product("Паста за заби", "Хигиена", 80);
            productList.Add(p6);


            productListBox.DataSource = productList;
            basketListBox.DataSource = basketList;
        }

        public void updateProductDetailsAdd(object sender, EventArgs e)
        {
            Product selected = productListBox.SelectedItem as Product;
            if(!(selected is null))
            {
                productNameTextBox.Text = selected.productName;
                productCategoryTextBox.Text = selected.productCategory;
                productPriceTextBox.Text = String.Format("{0:0.00}", selected.productPrice);
            }
            updateTotalPrice(sender, e);
        }

        public void updateTotalPrice(object sender, EventArgs e)
        {
            double price = 0;
            if (!(basketList is null))
            {
                foreach (Product product in basketList)
                    price += product.productPrice;
            }
            totalPriceTextBox.Text = String.Format("{0:0.00}", price) + " ден.";
        }

        private void productListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateProductDetailsAdd(sender, e);
        }

        private void clearProductListBoxButton_Click(object sender, EventArgs e)
        {
            String message = "Дали сте сигурни дека сакате да ја избришете листата на продукти?";
            String caption = "ВНИМАНИЕ";
            var choice = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(choice == DialogResult.Yes)
            {
                productList = new List<Product>();
                productListBox.DataSource = null;
                productListBox.DataSource = productList;
            }
        }

        private void clearBasketListBoxButton_Click(object sender, EventArgs e)
        {
            String message = "Дали сте сигурни дека сакате да ја испразните кошничката?";
            String caption = "ВНИМАНИЕ";
            var choice = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (choice == DialogResult.Yes)
            {
                basketList = new List<Product>();
                basketListBox.DataSource = null;
                basketListBox.DataSource = basketList;
            }
            updateTotalPrice(sender, e);
        }

        private void addToBasketButton_Click(object sender, EventArgs e)
        {
            Product selected = productListBox.SelectedItem as Product;
            if(!(selected is null))
            {
                basketList.Add(selected);
                basketListBox.DataSource = null;
                basketListBox.DataSource = basketList;
            }
            updateTotalPrice(sender, e);
        }

        private void removeFromBasketButton_Click(object sender, EventArgs e)
        {
            Product selected = basketListBox.SelectedItem as Product;
            if (!(selected is null))
            {
                basketList.Remove(selected);
                basketListBox.DataSource = null;
                basketListBox.DataSource = basketList;
            }
            updateTotalPrice(sender, e);
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            Form2 newProd = new Form2();
            newProd.ShowDialog();
            Product product = newProd.NewProduct;
            if(!(product is null))
            {
                productList.Add(product);
                productListBox.DataSource = null;
                productListBox.DataSource = productList;
            }
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            Form3 rm = new Form3(productList);
            rm.ShowDialog();
            productList = rm.products;
            productListBox.DataSource = null;
            productListBox.DataSource = productList;
        }
    }
}
