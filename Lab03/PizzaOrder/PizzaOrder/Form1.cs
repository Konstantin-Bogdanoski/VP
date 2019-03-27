using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static Double totalPrice;
        static List<String> items;

        private void Form1_Load(object sender, EventArgs e)
        {
            totalPrice = 0;
            items = new List<string>();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void cheeseCheck_CheckedChanged(object sender, EventArgs e)
        {
            getPrice(sender, e);
        }

        private void changeLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void smallPizzaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            getPrice(sender, e);
        }

        private void getReceipt(object sender, EventArgs e)
        {
            Form receipt = new Form();
            receipt.Show();
        }

        private void deleteReceipt(object sender, EventArgs e)
        {
            items = null;
            this.Close();
        }

        private void getPrice(object sender, EventArgs e)
        {
            totalPrice = 0;
            items = new List<string>();

            if (smallPizzaRadioButton.Checked)
            {
                totalPrice += Convert.ToDouble(smallPizzaPrice.Text);
                items.Add("Мала пица " + smallPizzaPrice.Text);
            }

            if (mediumPizzaRadioButton.Checked)
            {
                totalPrice += Convert.ToDouble(mediumPizzaPrice.Text);
                items.Add("Средна пица " + mediumPizzaPrice.Text);
            }

            if (BigPizzaRadioButton.Checked)
            {
                totalPrice += Convert.ToDouble(bigPizzaPrice.Text);
                items.Add("Голема пица " + bigPizzaPrice.Text);
            }

            if (feferoniCheck.Checked)
            {
                totalPrice += Convert.ToDouble(feferoniPrice.Text);
                items.Add("Феферони " + feferoniPrice.Text);
            }

            if (cheeseCheck.Checked)
            {
                totalPrice += Convert.ToDouble(cheesePrice.Text);
                items.Add("Екстра сирење " + cheesePrice.Text);
            }

            if (ketchupCheck.Checked)
            {
                totalPrice += Convert.ToDouble(ketchupPrice.Text);
                items.Add("Кечап " + ketchupPrice.Text);
            }

            //ADDING DRINK PRICES

            Double apPrice = 0, biarPrice = 0, cocaPrice = 0;

            if (!ccCount.Text.Equals(null) && !ccCount.Text.Equals(""))
            {
                cocaPrice = Convert.ToDouble(ccCount.Text) * Convert.ToDouble(ccPrice.Text);
                ccTotal.Text = cocaPrice.ToString();
            }
            //if(!Convert.ToDouble(ccCount.Text).Equals(0))

            if (!appleCount.Text.Equals(null) && !appleCount.Text.Equals(""))
            {
                apPrice = Convert.ToDouble(appleCount.Text) * Convert.ToDouble(applePrice.Text);
                appleTotal.Text = apPrice.ToString();
            }

            if (!beerCount.Text.Equals(null) && !beerCount.Text.Equals(""))
            {
                biarPrice = Convert.ToDouble(beerCount.Text) * Convert.ToDouble(beerPrice.Text);
                beerTotal.Text = biarPrice.ToString();
            }

            totalPrice += cocaPrice + apPrice + biarPrice;

            if (!desertPrice.Text.Equals("") && !(desertPrice.Text != null))
                totalPrice += Convert.ToDouble(desertPrice.Text);

            totalBox.Text = totalPrice.ToString();

            if(!(payedBox.Text.Equals("")) && !(payedBox.Text.Equals(null)))
            {
                double change = 0;
                change = Convert.ToDouble(payedBox.Text) - totalPrice;
                changeBox.Text = change.ToString();
            }
        }

        private void mediumPizzaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            getPrice(sender, e);
        }

        private void BigPizzaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            getPrice(sender, e);
        }

        private void feferoniCheck_CheckedChanged(object sender, EventArgs e)
        {
            getPrice(sender, e);
        }

        private void ketchupCheck_CheckedChanged(object sender, EventArgs e)
        {
            getPrice(sender, e);
        }

        private void ccCount_TextChanged(object sender, EventArgs e)
        {
            getPrice(sender, e);
        }

        private void appleCount_TextChanged(object sender, EventArgs e)
        {
            getPrice(sender, e);
        }

        private void beerCount_TextChanged(object sender, EventArgs e)
        {
            getPrice(sender, e);
        }

        private void desertPrice_TextChanged(object sender, EventArgs e)
        {
            getPrice(sender, e);
        }

        private void orderDesert_Click(object sender, EventArgs e)
        {
            getReceipt(sender, e);
        }

        private void payedBox_TextChanged(object sender, EventArgs e)
        {
            getPrice(sender, e);
        }

        private void cancelDesert_Click(object sender, EventArgs e)
        {
            deleteReceipt(sender, e);
        }
    }
}
