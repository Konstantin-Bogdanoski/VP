using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aerodromi
{
    public partial class Form2 : Form
    {
        public List<Airport> airports { get; set; }
        public Form2(List<Airport> airports)
        {
            InitializeComponent();
            this.airports = airports;
        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void addNewAirportNOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewAirportOK_Click(object sender, EventArgs e)
        {
            CancelEventArgs eventArgs = e as CancelEventArgs;
            addNewAirportOK_Validating(sender, eventArgs);
        }

        private void addNewAirportOK_Validating(object sender, CancelEventArgs e)
        {
            Airport newAirport = new Airport();
            if (!(newAirportCityTextBox.Text is null))
                newAirport.airportCity = newAirportCityTextBox.Text;
            else
            {
                String errorMsg = "Невалидно име на град";
                e.Cancel = true;
                newAirportCityTextBox.Select(0, newAirportCityTextBox.Text.Length);
                newAirportCityErrorProvider.SetError(newAirportCityTextBox, errorMsg);
            }

            if (!(newAirportNameTextBox.Text is null))
                newAirport.airportName = newAirportNameTextBox.Text;
            else
            {
                String errorMsg = "Невалидно име на аеродром";
                e.Cancel = true;
                newAirportNameTextBox.Select(0, newAirportNameTextBox.Text.Length);
                newAirportNameErrorProvider.SetError(newAirportNameTextBox, errorMsg);
            }

            if (!(newAirportSlangTextBox.Text is null) && (newAirportSlangTextBox.Text.All(c => char.IsUpper(c))))
                newAirport.airportSlang = newAirportSlangTextBox.Text;
            else
            {
                String errorMsg = "Невалидна кратенка на аеродром";
                e.Cancel = true;
                newAirportSlangTextBox.Select(0, newAirportSlangTextBox.Text.Length);
                newAirportSlangErrorProvider.SetError(newAirportSlangTextBox, errorMsg);
            }

            airports.Add(newAirport);
            this.Close();
        }
    }
}
