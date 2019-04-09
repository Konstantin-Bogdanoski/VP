using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Trki
{
    public class Racer
    {
        public String Name { get; set; }
        public int Age { get; set; }
        public bool First { get; set; }
        public List<String> Laps { get; set; }

        public override string ToString()
        {
            return this.Name + " (" + this.Age + ") - " + (this.First ? "F" : "S");
        }

        public Racer()
        {
            this.Laps = new List<string>();
        }

        public Racer(string name, int age, bool first, List<string> laps)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Age = age;
            First = first;
            Laps = laps ?? throw new ArgumentNullException(nameof(laps));
        }

        public override bool Equals(object obj)
        {
            var racer = obj as Racer;
            return racer != null &&
                   Name == racer.Name &&
                   Age == racer.Age &&
                   First == racer.First &&
                   EqualityComparer<List<string>>.Default.Equals(Laps, racer.Laps);
        }

        public String getBestLap(int aboveSeconds)
        {
            if (!(Laps is null) && Laps.Count>0)
            {
                String bestLap = Laps[0];
                foreach (String lap in Laps)
                {
                    int min = int.Parse(lap.Substring(0, 2));
                    int sec = int.Parse(lap.Substring(3, 2));
                    int temp = aboveSeconds / 60;
                    int temp2 = aboveSeconds % 60;
                    if (min * 60 + sec > aboveSeconds)
                    {
                        int bestMin = int.Parse(bestLap.Substring(0, 2));
                        int bestSec = int.Parse(bestLap.Substring(3, 2));

                        if ((min <= bestMin && sec <= bestSec) ||
                            bestMin * 60 + bestSec <= aboveSeconds)
                            bestLap = lap;
                    }
                }
                return bestLap;
            }
            return null;
        }

        public override int GetHashCode()
        {
            var hashCode = -1374706346;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Age.GetHashCode();
            hashCode = hashCode * -1521134295 + First.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<string>>.Default.GetHashCode(Laps);
            return hashCode;
        }
    }
}
