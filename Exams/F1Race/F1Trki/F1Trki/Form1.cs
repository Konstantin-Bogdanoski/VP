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
    public partial class Form1 : Form
    {
        List<Racer> racerList;
        public Form1()
        {
            InitializeComponent();
            this.racerList = new List<Racer>();

            Racer r1 = new Racer();
            r1.Name = "Vetel";
            r1.Age = 32;
            r1.First = true;
            r1.Laps.Add("01:17");
            r1.Laps.Add("01:22");

            racerList.Add(r1);

            Racer r2 = new Racer();
            r2.Name = "Raikonen";
            r2.Age = 29;
            r2.First = false;
            r2.Laps.Add("01:12");
            r2.Laps.Add("01:34");

            racerList.Add(r2);

            driversListBox.DataSource = racerList;
        }

        private void addDriverButton_Click(object sender, EventArgs e)
        {
            Racer newRacer = new Racer();
            Form2 frm2 = new Form2(newRacer);
            frm2.ShowDialog();
            newRacer = frm2.Racer;
            if(!(newRacer is null))
                racerList.Add(newRacer);

            driversListBox.DataSource = null;
            driversListBox.DataSource = racerList;
        }

        private void driversListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Racer selectedRacer = driversListBox.SelectedItem as Racer;
            if(!(selectedRacer is null))
            {
                lapsListBox.DataSource = null;
                lapsListBox.DataSource = selectedRacer.Laps;

                String bestLap = selectedRacer.getBestLap((int)numericFilter.Value);

                if(bestLap is null)
                    bestLapTextBox.Text = "NO LAP EXISTS";

                else
                    bestLapTextBox.Text = bestLap;
            }
        }

        private void deleteDriverButton_Click(object sender, EventArgs e)
        {
            Racer selectedRacer = driversListBox.SelectedItem as Racer;
            if(!(selectedRacer is null))
            {
                var result = MessageBox.Show("Дали сигурно сакате да го избришете " + selectedRacer.Name + " ?", "ВНИМАНИЕ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    racerList.Remove(selectedRacer);
                    driversListBox.DataSource = null;
                    driversListBox.DataSource = racerList;
                    lapsListBox.DataSource = null;
                }
            }
        }

        private void numericFilter_ValueChanged(object sender, EventArgs e)
        {
            driversListBox_SelectedIndexChanged(sender, e);
        }

        private void addLapButton_Click(object sender, EventArgs e)
        {
            Racer selectedRacer = driversListBox.SelectedItem as Racer;
            if(!(selectedRacer is null))
            {
                int min = (int)numericMinutes.Value;
                int sec = (int)numericSeconds.Value;

                if (min <= 0 && sec <= 0)
                    MessageBox.Show("Невалидни вредности за круг!", "НЕВАЛИДНО", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    String lap = String.Format("{0:00}", min) + ":" + String.Format("{0:00}", sec);
                    selectedRacer.Laps.Add(lap);
                    driversListBox.DataSource = null;
                    driversListBox.DataSource = racerList;
                    lapsListBox.DataSource = null;
                    lapsListBox.DataSource = selectedRacer.Laps;
                    driversListBox_SelectedIndexChanged(sender, e);
                }
                numericMinutes.Value = 0;
                numericSeconds.Value = 0;
            }
        }

        private void numericSeconds_ValueChanged(object sender, EventArgs e)
        {
            if((int)numericSeconds.Value == 60)
            {
                numericMinutes.Value += 1;
                numericSeconds.Value = 0;
            }
        }

        private void bestLapTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
