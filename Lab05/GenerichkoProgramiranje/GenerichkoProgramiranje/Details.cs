using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerichkoProgramiranje
{
    public class Details<K, V>
    {
        public K key;
        public V value;

        public override string ToString()
        {
            return this.key + " - " + this.value;
        }

        public override bool Equals(object obj)
        {
            var details = obj as Details<K, V>;
            return details != null &&
                   EqualityComparer<K>.Default.Equals(key, details.key) &&
                   EqualityComparer<V>.Default.Equals(value, details.value);
        }

        public override int GetHashCode()
        {
            var hashCode = 1363396886;
            hashCode = hashCode * -1521134295 + EqualityComparer<K>.Default.GetHashCode(key);
            hashCode = hashCode * -1521134295 + EqualityComparer<V>.Default.GetHashCode(value);
            return hashCode;
        }
    }
}
