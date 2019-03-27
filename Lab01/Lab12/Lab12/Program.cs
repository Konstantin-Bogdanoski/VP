using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class WrongChoiceException : Exception
    {

        [Serializable]
        public class MyException : Exception
        {
            public MyException() { }
            public MyException(string message) : base(message) {}
            public MyException(string message, Exception inner) : base(message, inner) { }
            protected MyException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double number, sum = 0, max = 0, min = 0;
            bool flag = true;
            Console.WriteLine("Input N");// Choose how many numbers you would like to generate/input
            N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Would you like to input numbers? Y/N");
            String choice = Console.ReadLine();

            if (choice.Equals("N"))// RANDOM NUMBERS
            {
                Console.WriteLine("You chose to get random generated numbers");
                Random randomNum = new Random();
                for(int i = 0; i<N; i++)
                {
                    number = randomNum.Next(1, 1000);
                    sum += number;
                    GetMin(number, out min);
                    GetMax(number, out max);
                }
            }
            else if(choice.Equals("Y")) // INPUT NUMBERS
            {
                Console.WriteLine("You chose to input the numbers manually");
                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine("Input number " + Convert.ToInt32(i + 1));
                    number = Convert.ToDouble(Console.ReadLine());
                    sum += number;
                    GetMin(number, out min);
                    GetMax(number, out max);
                }
            }
            else
                throw new WrongChoiceException();

            Console.WriteLine("AVG: " + GetAvg(sum, N));
            Console.WriteLine("MAX: " + max);
            Console.WriteLine("MIN: " + min);
            Console.WriteLine("Press any key to close terminal");
            Console.ReadKey();
        }

        private static void GetMin(double number, out double min)
        {
            min = 1000;
            if (min > number) min = number;
        }

        private static void GetMax(double number, out double max)
        {
            max = 0;
            if (max < number) max = number;
        }
        static double GetAvg(double sum, int N)
        {
            return sum / N;
        }
        
    }
}
