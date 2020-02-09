using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public sealed class Player : ICombatable
    {
        private static readonly Player player;
        public int Level { get; set; } = 1;
        public string Name { get; set; }
        public int Health { get; set; } = 100;
        const private maxLevel = 20; 

        private Player() {}

        static Player()
        {
            player = new Player();
        }

        public static Player GetInstance()
        {
            return player;
        }

        public string Attack(Monster m)
        {
            return "Attacking!";
        }

        public string Defend(Monster m)
        {
            // I don't know if this is right
            // ex - palyer level 15, monster level 1 -> damage = 20 + 1 - 15 = 6
            //    - player level 2, monster level 2 -> damage = 20 + 2 - 2 = 20
            //    - player level 10, monster level 15 -> damage = 20 + 15 - 10 = 25... 
            int damage = maxLevel + m.Level - Level;
            this.Health =- damage;

            return "Defending.";
        }
    }
}
