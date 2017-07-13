using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class ScoreBoard
    {
        public ScoreBoard()
        {
        }

        public int[] Play(int p1Choice, int p2Choice, string p1, string p2)
        {
            int p1C = p1Choice;
            int p2C = p2Choice;
            int p1Wins = 0;
            int p2Wins = 0;
            int[] outcomes = new int[2];
            
            // draw condition
            if(p1C == p2C)
            {
                Console.WriteLine("Draw!");
            }

            // paper win conditions
            if(p1C == 2 && p2C == 1)
            {
                p1Wins++;
                Console.WriteLine($"{p1} wins!");
            }
            else if(p2C == 2 && p1C == 1)
            {
                p2Wins++;
                Console.WriteLine($"{p2} wins!");
            }

            // rock win conditions
            if(p1C == 1 && p2C == 3)
            {
                p1Wins++;
                Console.WriteLine($"{p1} wins!");
            }
            else if(p2C == 1 && p1C == 3)
            {
                p2Wins++;
                Console.WriteLine($"{p2} wins!");
            }

            //scissor win conditions
            if (p1C == 3 && p2C == 2)
            {
                p1Wins++;
                Console.WriteLine($"{p1} wins!");
            }
            else if (p2C == 3 && p1C == 2)
            {
                p2Wins++;
                Console.WriteLine($"{p2} wins!");
            }

            outcomes[0] = p1Wins;
            outcomes[1] = p2Wins;

            return outcomes;
        }

        public void DisplayScores(int[] outcomes, string p1Name, string p2Name)
        {
            int p1Wins = outcomes[0];
            int p2Wins = outcomes[1];
            string scores = $"{p1Name} has won {p1Wins} games and {p2Name} has won {p2Wins} games";

            Console.WriteLine(scores);
        }
        

    }
}
