using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1Trki
{
    public partial class Form2 : Form
    {
        public Racer Racer { get; set; }
        public Form2(Racer racer)
        {
            InitializeComponent();
            this.Racer = racer;
        }

        private void addDriverNOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addDriverOK_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                this.Racer.Name = driverNameTextBox.Text;
                this.Racer.Age = (int)racerNumericAge.Value;
                this.Racer.First = racerFirstBool.Checked;
                this.Close();
            }
        }

        private void driverNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if(driverNameTextBox.Text is null || driverNameTextBox.Text.Equals(""))
            {
                e.Cancel = true;
                driverNameTextBox.Focus();
                racerNameError.SetError(driverNameTextBox, "Името неможе да биде празно!");
            }
            else
            {
                e.Cancel = false;
                racerNameError.SetError(driverNameTextBox,null);
            }
        }
    }
}
