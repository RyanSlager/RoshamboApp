using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class HumanPlayer : Player
    {
        private string name;

        public HumanPlayer()
        {
            name = SetName();
        }

        public string SetName()
        {
            Console.WriteLine("Hello player!\nWhat is your name?\n");
            return Console.ReadLine();
        }

        public string GetName()
        {
            return name;
        }

        public override int SetRosh()
        {
            string rawChoice;
            int choice;

            Console.WriteLine("Throw that roshambo, bro!\n1) Rock\n2) Paper\n3) Scissors");
            rawChoice = Console.ReadLine();
            choice = Validator.CheckInts(rawChoice, 1, 4);

            return choice;
        }
    }
}
