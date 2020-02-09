using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    abstract class Monster<T> : ICombatable
    {
        public int Level = 1;
        public int Health = 10;
        private int maxLevel = 15;

        public Monster(int level)
        {
            this.Level = level;
        }
        
        public string Attack(Player player)
        {
            return "Attacking!";
        }

        public string Defend(Player player)
        {
            int defendValue = maxLevel - player.Level;
            this.Health =- defendValue;

            return "Defending.";
        }
    }
}