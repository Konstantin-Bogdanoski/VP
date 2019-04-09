using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerichkoProgramiranje
{
    public class GameDetails<K,V>
    {
        public List<Details<K, V>> gameDetails;

        public override string ToString()
        {
            return gameDetails.ToString();
        }

        public override bool Equals(object obj)
        {
            var details = obj as GameDetails<K, V>;
            return details != null &&
                   EqualityComparer<List<Details<K, V>>>.Default.Equals(gameDetails, details.gameDetails);
        }

        public override int GetHashCode()
        {
            return -848591609 + EqualityComparer<List<Details<K, V>>>.Default.GetHashCode(gameDetails);
        }
    }
}
