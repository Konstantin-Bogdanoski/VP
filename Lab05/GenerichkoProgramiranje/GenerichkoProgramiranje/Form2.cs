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
    public partial class Form2 : Form
    {
        public Game<Football> fGame;
        public Game<Basketball> bGame;
        public List<Details<int, string>> detailsHome;
        public List<Details<int, string>> detailsAway;
        public Form2()
        {
            List<String> tempList = new List<string>();
            tempList.Add("Фудбал");
            tempList.Add("Кошарка");
            InitializeComponent();
            detailsHome = new List<Details<int, string>>();
            detailsAway = new List<Details<int, string>>();
            fGame = null;
            bGame = null;
            gameTypeBox.DataSource = tempList;
            homeShootersListBox.DataSource = detailsHome;
            awayShootersListBox.DataSource = detailsAway;
        }

        private void addNewGameNOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateTotalScore(object sender, EventArgs e)
        {
            if (gameTypeBox.SelectedItem.Equals("Кошарка"))//Basketball
            {
                if (detailsHome is null)
                    homeTeamScoreTextBox.Text = "0";
                else
                {
                    int totalHomePoints = 0;
                    foreach (Details<int, string> detail in detailsHome)
                    {
                        totalHomePoints += detail.key;
                    }
                    homeTeamScoreTextBox.Text = totalHomePoints.ToString();
                }

                if (detailsAway is null)
                    awayTeamScoreTextBox.Text = "0";
                else
                {
                    int totalAwayPoints = 0;
                    foreach (Details<int, string> detail in detailsAway)
                    {
                        totalAwayPoints += detail.key;
                    }
                    awayTeamScoreTextBox.Text = totalAwayPoints.ToString();
                }
            }
            else //Football
            {
                if (detailsHome is null)
                    homeTeamScoreTextBox.Text = "0";
                else
                {
                    int totalHomePoints = 0;
                    foreach (Details<int, string> detail in detailsHome)
                    {
                        totalHomePoints += 1;
                    }
                    homeTeamScoreTextBox.Text = totalHomePoints.ToString();
                }

                if (detailsAway is null)
                    awayTeamScoreTextBox.Text = "0";
                else
                {
                    int totalAwayPoints = 0;
                    foreach (Details<int, string> detail in detailsAway)
                    {
                        totalAwayPoints += 1;
                    }
                    awayTeamScoreTextBox.Text = totalAwayPoints.ToString();
                }
            }
        }

        private void addNewGameOK_Click(object sender, EventArgs e)
        {
            if (gameTypeBox.SelectedItem.Equals("Кошарка"))//Basketball
            {
                if (!(homeTeamTextBox.Text is null || homeTeamTextBox.Text.Equals("")) &&
                    !(awayTeamTextBox.Text is null || awayTeamTextBox.Text.Equals("")))
                {
                    Basketball homeTeam = new Basketball();
                    Basketball awayTeam = new Basketball();
                    homeTeam.gameDetails = detailsHome;
                    awayTeam.gameDetails = detailsAway;
                    bGame = new Game<Basketball>(homeTeamTextBox.Text, awayTeamTextBox.Text,int.Parse(homeTeamScoreTextBox.Text), int.Parse(awayTeamScoreTextBox.Text), homeTeam, awayTeam, dateOfMatch.Value);
                    this.Close();
                }
                else
                    MessageBox.Show("Погрешни податоци!", "ГРЕШКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else//Football
            {
                if (!(homeTeamTextBox.Text is null || homeTeamTextBox.Text.Equals("")) &&
                    !(awayTeamTextBox.Text is null || awayTeamTextBox.Text.Equals("")))
                {
                    Football homeTeam = new Football();
                    Football awayTeam = new Football();

                    List<Details<String, String>> newHomeDetails = new List<Details<string, string>>();
                    foreach(Details<int, String> detail in detailsHome)
                    {
                        Details<String, String> newDet = new Details<string, string>();
                        newDet.key = detail.key + "min";
                        newDet.value = detail.value;
                        newHomeDetails.Add(newDet);
                    }

                    List<Details<String, String>> newAwayDetails = new List<Details<string, string>>();
                    foreach (Details<int, String> detail in detailsAway)
                    {
                        Details<String, String> newDet = new Details<string, string>();
                        newDet.key = detail.key + "min";
                        newDet.value = detail.value;
                        newAwayDetails.Add(newDet);
                    }

                    homeTeam.gameDetails = newHomeDetails;
                    awayTeam.gameDetails = newAwayDetails;
                    fGame = new Game<Football>(homeTeamTextBox.Text, awayTeamTextBox.Text, int.Parse(homeTeamScoreTextBox.Text), int.Parse(awayTeamScoreTextBox.Text), homeTeam, awayTeam, dateOfMatch.Value);
                    this.Close();
                }
                else
                    MessageBox.Show("Погрешни податоци!", "ГРЕШКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addHomeShooterButton_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(detailsHome);
            frm3.ShowDialog();
            detailsHome = frm3.details;
            homeShootersListBox.DataSource = null;
            homeShootersListBox.DataSource = detailsHome;
            updateTotalScore(sender, e);
        }

        private void addAwayShooterButton_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(detailsAway);
            frm3.ShowDialog();
            detailsAway = frm3.details;
            awayShootersListBox.DataSource = null;
            awayShootersListBox.DataSource = detailsAway;
            updateTotalScore(sender, e);
        }

        private void gameTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
