using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    abstract class Monster : ICombatable
    {
        public int Level { get; set; } = 1;
        public int Health { get; set; } = 10;
        public int maxLevel = 15;

        public Monster(int level = 1)
        {
            this.Level = level;
        }
        
        public string Attack(ICombatable player)
        {
            return "Attacking!";
        }

        public string Defend(ICombatable player)
        {
            int defendValue = maxLevel - player.Level;
            this.Health =- defendValue;

            return "Defending.";
        }
    }
}