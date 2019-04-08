using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerodromi
{
    public class Destination : IComparable
    {
        public String destinationName { get; set; }
        public double destinationLength { get; set; }
        public double destinationPrice { get; set; }

        public Destination(string destinationName, double destinationLength, double destinationPrice)
        {
            this.destinationName = destinationName ?? throw new ArgumentNullException(nameof(destinationName));
            this.destinationLength = destinationLength;
            this.destinationPrice = destinationPrice;
        }

        public override string ToString()
        {
            return this.destinationName + " " + this.destinationLength + "km - " + String.Format("{0}", this.destinationPrice) + " EUR";
        }

        public override bool Equals(object obj)
        {
            var destination = obj as Destination;
            return destination != null &&
                   destinationName == destination.destinationName &&
                   destinationLength == destination.destinationLength &&
                   destinationPrice == destination.destinationPrice;
        }

        public override int GetHashCode()
        {
            var hashCode = 1497456251;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(destinationName);
            hashCode = hashCode * -1521134295 + destinationLength.GetHashCode();
            hashCode = hashCode * -1521134295 + destinationPrice.GetHashCode();
            return hashCode;
        }

        public int CompareTo(object obj)
        {
            Destination dest = obj as Destination;
            return this.destinationPrice.CompareTo(dest.destinationPrice);
        }
    }
}
