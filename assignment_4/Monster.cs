using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    abstract class Monster:IAction
    {
        public int Level = 1;
        public int Health = 10;

        public string Attack()
        {
            return "Attacking!";
        }

        public string Defend()
        {
            return "Defending.";
        }
    }
}
