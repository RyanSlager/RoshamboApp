using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class AIPlayer : Player
    {
        private string name;
        private int rosh;
        private Random ran;

        public AIPlayer(Random ran)
        {
            name = "The Randominator";
            this.ran = ran;
            rosh = SetRosh();
        }

        public override int SetRosh()
        {
            int aiChoice = ran.Next(1, 4);

            return aiChoice;
        }
    }
}
