using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerichkoProgramiranje
{
    public class Game<T>
    {

        public string homeTeam { get; set; }
        public string visitorTeam { get; set; }
        public int scoreHome { get; set; }
        public int scoreVisitor { get; set; }
        public T detailsHome { get; set; }
        public T detailsVisitor { get; set; }
        public DateTime date { get; set; }

        public Game(string homeTeam, string visitorTeam, int scoreHome, int scoreVisitor, T detailsHome, T detailsVisitor, DateTime date)
        {
            this.homeTeam = homeTeam ?? throw new ArgumentNullException(nameof(homeTeam));
            this.visitorTeam = visitorTeam ?? throw new ArgumentNullException(nameof(visitorTeam));
            this.scoreHome = scoreHome;
            this.scoreVisitor = scoreVisitor;
            this.detailsHome = detailsHome;
            this.detailsVisitor = detailsVisitor;
            this.date = date;
        }

        public override string ToString()
        {
            return homeTeam + " " + scoreHome.ToString() + ":" + scoreVisitor.ToString() + " " + visitorTeam;
        }

        public override bool Equals(object obj)
        {
            var game = obj as Game<T>;
            return game != null &&
                   homeTeam == game.homeTeam &&
                   visitorTeam == game.visitorTeam &&
                   scoreHome == game.scoreHome &&
                   scoreVisitor == game.scoreVisitor &&
                   EqualityComparer<T>.Default.Equals(detailsHome, game.detailsHome) &&
                   EqualityComparer<T>.Default.Equals(detailsVisitor, game.detailsVisitor) &&
                   date == game.date;
        }

        public override int GetHashCode()
        {
            var hashCode = 792620014;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(homeTeam);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(visitorTeam);
            hashCode = hashCode * -1521134295 + scoreHome.GetHashCode();
            hashCode = hashCode * -1521134295 + scoreVisitor.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<T>.Default.GetHashCode(detailsHome);
            hashCode = hashCode * -1521134295 + EqualityComparer<T>.Default.GetHashCode(detailsVisitor);
            hashCode = hashCode * -1521134295 + date.GetHashCode();
            return hashCode;
        }
    }
}
