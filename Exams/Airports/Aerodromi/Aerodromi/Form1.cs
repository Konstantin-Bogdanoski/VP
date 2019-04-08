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
    public partial class Form1 : Form
    {
        List<Airport> airportList;
        public Form1()
        {
            InitializeComponent();
            airportList = new List<Airport>();
            //TEMP AIRPORT WITH DESTINATIONS
            List<Destination> a1List = new List<Destination>();

            Destination d1 = new Destination("Виена", 1240, 260);
            a1List.Add(d1);

            Destination d2 = new Destination("Франкфурт", 1550, 290);
            a1List.Add(d2);

            Destination d3 = new Destination("Лондон", 2150, 440);
            a1List.Add(d3);

            Airport a1 = new Airport("Скопје","Александар Велики","SKP", a1List);
            airportList.Add(a1);
            //
            airportListBox.DataSource = airportList;
            destinationListBox.DataSource = null;
        }

        private void addAirportButton_Click(object sender, EventArgs e)
        {
            Form2 addAirport = new Form2(airportList);
            addAirport.ShowDialog();

            airportList = addAirport.airports;
            airportListBox.DataSource = null;
            airportListBox.DataSource = airportList;

            updateDestinationInfo(sender, e, null);
        }

        private void airportListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Airport selected = airportListBox.SelectedItem as Airport;
            if(!(selected is null))
            {
                destinationListBox.DataSource = selected.airportDestinations;
                updateDestinationInfo(sender, e, selected);
            }
        }

        private void updateDestinationInfo(object sender, EventArgs e, Airport selected)
        {
            if (!(selected is null) && !(selected.airportDestinations is null))
            {
                double maxPrice = selected.airportDestinations.Max(air => air.destinationPrice);
                Destination destination = selected.airportDestinations.Find(air => air.destinationPrice.Equals(maxPrice));

                if (!(destination is null))
                {
                    mostExpensiveDestinationTextBox.Text = destination.ToString();
                }

                double avgLength = selected.airportDestinations.Average(air => air.destinationLength);
                avgDestinationLengthTextBox.Text = String.Format("{0:00.0}", avgLength);
            }
            else
            {
                mostExpensiveDestinationTextBox.Text = "";
                avgDestinationLengthTextBox.Text = "";
            }
        }

        private void deleteAirportButton_Click(object sender, EventArgs e)
        {
            Airport selected = airportListBox.SelectedItem as Airport;
            if (!(selected is null))
            {
                var choice = MessageBox.Show("Дали сигурно сакате да го избришете аеродромот \n" + selected + "\n ?", "ВНИМАНИЕ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(choice == DialogResult.Yes)
                {
                    airportList.Remove(selected);
                    airportListBox.DataSource = null;
                    airportListBox.DataSource = airportList;
                }
            }
            else
                updateDestinationInfo(sender, e, null);
        }

        private void addDestinationButton_Click(object sender, EventArgs e)
        {
            Airport selected = airportListBox.SelectedItem as Airport;
            if (!(selected is null))
            {
                Form3 addDest = new Form3(selected);
                addDest.ShowDialog();
                selected = addDest.airport;
            }
            else
                MessageBox.Show("Немате селектирано аеродром!", "ГРЕШКА", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            updateDestinationInfo(sender, e, null);
        }
    }
}
