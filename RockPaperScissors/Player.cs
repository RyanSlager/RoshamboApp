using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    abstract class Player
    {
        string name;
        public Player()
        {
        }

        public abstract int SetRosh();

        public string GetName()
        {
            return name;
        }
    }
}
