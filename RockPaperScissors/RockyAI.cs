using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class RockyAI : Player
    {
        private string name;
        private int rosh;

        public RockyAI()
        {
            name = "Rambo";
            rosh = SetRosh();
        }

        public override int SetRosh()
        {
            int rosh = 1;

            return rosh;
        }
    }
}
