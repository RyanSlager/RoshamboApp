using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Validator
    {
        static Validator()
        {

        }

        public static int CheckInts(string x, int min, int max)
        {
            int z;
            string y = x;
            Console.WriteLine(min);
            Console.WriteLine(max);
            while (!Int32.TryParse(y, out z) || z < min || z > max)
            {
                Console.WriteLine("That is not a valid input, please enter a positive number\n");
                y = Console.ReadLine();
            }

            return z;
        }

        public static double CheckDubs(string x)
        {
            double z;
            string y = x;

            while (!Double.TryParse(y, out z) || z <= 0)
            {
                Console.WriteLine("That is not a valid input, please enter a positive number\n");
                y = Console.ReadLine();
            }

            return z;
        }
    }
}
