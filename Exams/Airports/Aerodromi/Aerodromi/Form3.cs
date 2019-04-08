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
    public partial class Form3 : Form
    {
        public Airport airport { get; set; }
        public Form3(Airport airport)
        {
            InitializeComponent();
            this.airport = airport;
            destinationForAirportTextBox.Text = this.airport.ToString();
        }

        private void addNewDestinationOK_Click(object sender, EventArgs e)
        {
            if (airport.airportDestinations is null)
                airport.airportDestinations = new List<Destination>();

            String destinationName = newDestinationNameTextBox.Text;
            double destinationLength = (double) newDestinationLengthData.Value;
            double destinationPrice = (double)newDestinationPriceData.Value;
            if(!(destinationName is null) && destinationLength>0 && destinationPrice > 0)
            {
                Destination newDestination = new Destination(destinationName, destinationLength, destinationPrice);
                airport.airportDestinations.Add(newDestination);
                MessageBox.Show("Успешно додадена нова дестинација","Успешна акција",MessageBoxButtons.OK);
                this.Close();
            }
            else
                MessageBox.Show("Погрешни податоци", "Неуспешна акција", MessageBoxButtons.OK);
        }

        private void addNewDestinationNOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
