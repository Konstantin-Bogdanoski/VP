using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerodromi
{
    public class Airport
    {
        public String airportCity { get; set; }
        public String airportName { get; set; }
        public String airportSlang { get; set; }
        public List<Destination> airportDestinations { get; set; }

        public Airport(string airportCity, string airportName, string airportSlang, List<Destination> airportDestinations)
        {
            this.airportCity = airportCity ?? throw new ArgumentNullException(nameof(airportCity));
            this.airportName = airportName ?? throw new ArgumentNullException(nameof(airportName));
            this.airportSlang = airportSlang ?? throw new ArgumentNullException(nameof(airportSlang));
            this.airportDestinations = airportDestinations ?? throw new ArgumentNullException(nameof(airportDestinations));
        }

        public Airport()
        {
            this.airportCity = null;
            this.airportName = null;
            this.airportSlang = null;
            this.airportDestinations = null;
        }

        public override string ToString()
        {
            return this.airportSlang + " - " + this.airportName + " - " + this.airportCity;
        }

        public override bool Equals(object obj)
        {
            var airport = obj as Airport;
            return airport != null &&
                   airportCity == airport.airportCity &&
                   airportName == airport.airportName &&
                   airportSlang == airport.airportSlang &&
                   EqualityComparer<List<Destination>>.Default.Equals(airportDestinations, airport.airportDestinations);
        }

        public override int GetHashCode()
        {
            var hashCode = -2015757188;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(airportCity);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(airportName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(airportSlang);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Destination>>.Default.GetHashCode(airportDestinations);
            return hashCode;
        }
    }
}
