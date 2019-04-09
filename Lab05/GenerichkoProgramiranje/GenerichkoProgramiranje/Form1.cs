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
    public partial class Form1 : Form
    {
        public List<Game<Football>> fGames;
        public List<Game<Basketball>> bGames;
        public Form1()
        {
            InitializeComponent();
            fGames = new List<Game<Football>>();
            bGames = new List<Game<Basketball>>();


            //TEMP GAMES
            //BASKETBALL
            Basketball detailsHome = new Basketball();
            Details<int, String> detail1 = new Details<int, string>();
            detail1.key = 30;
            detail1.value = "Kobe Bryant";
            detailsHome.gameDetails = new List<Details<int, string>>();
            detailsHome.gameDetails.Add(detail1);

            Basketball detailsAway = new Basketball();
            Details<int, String> detail2 = new Details<int, string>();
            detail2.key = 25;
            detail2.value = "Rajon Rondo";
            detailsAway.gameDetails = new List<Details<int, string>>();
            detailsAway.gameDetails.Add(detail2);

            DateTime date = new DateTime();

            Game<Basketball> bGame = new Game<Basketball>("LA Lakers", "NO Pelicans", 30, 25, detailsHome, detailsAway, date);

            bGames.Add(bGame);

            //FOOTBALL
            Football detailsHome2 = new Football();
            Details<String, String> detail3 = new Details<String, String>();
            detail3.key = "25min";
            detail3.value = "Sergio Ramos";
            detailsHome2.gameDetails = new List<Details<String, String>>();
            detailsHome2.gameDetails.Add(detail3);

            Football detailsAway2 = new Football();
            Details<String, String> detail4 = new Details<String, String>();
            detail4.key = "55min";
            detail4.value = "Lionel Messi";
            detailsAway2.gameDetails = new List<Details<String, String>>();
            detailsAway2.gameDetails.Add(detail4);

            DateTime date2 = new DateTime();

            Game<Football> fGame = new Game<Football>("Real Madrid", "Barcelona", 1, 1, detailsHome2, detailsAway2, date);

            fGames.Add(fGame);
            //

            footballListBox.DataSource = fGames;
            basketballListBox.DataSource = bGames;
        }

        private void addGameButton_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
            if(!(frm2.bGame is null))
            {
                Game<Basketball> bgame = frm2.bGame;
                bGames.Add(bgame);
            }
            if(!(frm2.fGame is null))
            {
                Game<Football> fgame = frm2.fGame;
                fGames.Add(fgame);
            }

            basketballListBox.DataSource = null;
            basketballListBox.DataSource = bGames;

            footballListBox.DataSource = null;
            footballListBox.DataSource = fGames;
        }

        private void closeWindowButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void basketballListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateGameDetailsBoxBasketball(sender, e);
        }

        private void footballListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateGameDetailsBoxFootball(sender, e);
        }

        private void updateGameDetailsBoxFootball(object sender, EventArgs e)
        {
            Game<Football> selectedGame = footballListBox.SelectedItem as Game<Football>;
            if (!(selectedGame is null))
            {
                gameHomeTextBox.Text = selectedGame.homeTeam;
                gameAwayTextBox.Text = selectedGame.visitorTeam;
                gameScoreTextBox.Text = selectedGame.scoreHome + ":" + selectedGame.scoreVisitor;

                shootersHomeListBox.DataSource = selectedGame.detailsHome.gameDetails;
                shootersAwayListBox.DataSource = selectedGame.detailsVisitor.gameDetails;
                gameDateTextBox.Text = selectedGame.date.ToString();
            }
        }

        private void updateGameDetailsBoxBasketball(object sender, EventArgs e)
        {
            Game<Basketball> selectedGame = basketballListBox.SelectedItem as Game<Basketball>;
            if(!(selectedGame is null))
            {
                gameHomeTextBox.Text = selectedGame.homeTeam;
                gameAwayTextBox.Text = selectedGame.visitorTeam;
                gameScoreTextBox.Text = selectedGame.scoreHome + ":" + selectedGame.scoreVisitor;

                shootersHomeListBox.DataSource = selectedGame.detailsHome.gameDetails;
                shootersAwayListBox.DataSource = selectedGame.detailsVisitor.gameDetails;
                gameDateTextBox.Text = selectedGame.date.ToString();
            }
        }


    }
}
