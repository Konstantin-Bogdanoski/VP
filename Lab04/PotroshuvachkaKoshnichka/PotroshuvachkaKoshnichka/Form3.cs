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
    public partial class Form3 : Form
    {
        public List<Product> products { get; set; }
        public Form3(List<Product> products)
        {
            InitializeComponent();
            this.products = products;
            allProductsListBox.DataSource = this.products;
        }

        private void deleteProductOK_Click(object sender, EventArgs e)
        {
            Product selected = allProductsListBox.SelectedItem as Product;
            if(!(selected is null))
            {
                products.Remove(selected);
                MessageBox.Show("Продуктот: " + selected.productName + ", е успешно избришан","УСПЕШНО",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void deleteProductNOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Не направивте никаква промена!", "НЕМА ПРОМЕНА", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
