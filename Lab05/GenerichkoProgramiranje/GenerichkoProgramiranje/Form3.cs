using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerichkoProgramiranje
{
    public partial class Form3 : Form
    {
        public List<Details<int, string>> details;
        public Form3(List<Details<int, string>> details)
        {
            InitializeComponent();
            this.details = details;
        }

        private void addPlayerNOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addPlayerOK_Click(object sender, EventArgs e)
        {
            Details<int, String> newPlayer = new Details<int, string>();
            if (!(playerTextBox.Text is null) && int.TryParse(scoreTextBox.Text, out newPlayer.key))
            {
                newPlayer.value = playerTextBox.Text;
                details.Add(newPlayer);
                this.Close();
            }
            else
                MessageBox.Show("Погрешни информации!", "ГРЕШКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
