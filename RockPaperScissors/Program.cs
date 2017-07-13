using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            HumanPlayer p1 = new HumanPlayer();
            string name = p1.GetName();
            int[] outcomes = new int[2];
            ScoreBoard score = new ScoreBoard();
            bool cont = true;

            while (cont == true)
            {
                string x;
                int choice;
                int playerThrow = 0;
                int aiThrow = 0;
                Random ran = new Random();
                AIPlayer p2 = new AIPlayer(ran);
                RockyAI p3 = new RockyAI();



                Console.WriteLine($"{name}, who would you like to play?\n1) Randominator\n2) Rambo\n");
                x = Console.ReadLine();

                choice = Validator.CheckInts(x, 1, 2);

                if(choice == 1)
                {
                    aiThrow = p2.SetRosh();
                }
                else if(choice == 2)
                {
                    aiThrow = p3.SetRosh();
                }

                playerThrow = p1.SetRosh();

                outcomes = score.Play(playerThrow, aiThrow, name, "AI");


                cont = Continue();
            }

            score.DisplayScores(outcomes, name, "AI");
        }

        public static Boolean Continue()
        {
            Boolean run;
            Console.WriteLine("Continue? Y/N");
            String answer = Console.ReadLine();

            if ((answer == "Y") || (answer == "y"))
            {
                run = true;
            }
            else if ((answer == "N") || (answer == "n"))
            {
                run = false;
                Console.WriteLine("Good Bye!");
            }
            else
            {
                Console.WriteLine("I'm sorry I don't understand. Let's try again");
                run = Continue();
            }
            return run;
        }
    }
}
