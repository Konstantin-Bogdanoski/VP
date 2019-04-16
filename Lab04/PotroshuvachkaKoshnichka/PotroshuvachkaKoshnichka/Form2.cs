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
    public partial class Form2 : Form
    {
        public Product NewProduct { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void addNewProductButton_Click(object sender, EventArgs e)
        {
            String name = newProductNameTextBox.Text;
            String category = newProductCategoryTextBox.Text;
            String price = newProductPriceTextBox.Text;
            int quantity = (int)numericProductQuantity.Value;
            double newPrice = 0;
            if (!(name is null || name.Equals("")) &&
                !(category is null || category.Equals("")) &&
                !(price is null || price.Equals("") || !double.TryParse(price, out newPrice)) &&
                !(quantity <= 0))
            {
                NewProduct = new Product(name, category, newPrice, quantity);
                this.Close();
            }
            else
            {
                MessageBox.Show("Погрешно внесени информации", "ГРЕШКА", MessageBoxButtons.OK);
            }
        }

        private void cancelNewProductButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
