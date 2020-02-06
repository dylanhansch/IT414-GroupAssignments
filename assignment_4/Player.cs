using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public sealed class Player
    {
        private static readonly Player player;
        public int Level { get; set; } = 1;
        public string Name { get; set; }

        private Player() {}

        static Player()
        {
            player = new Player();
        }

        public static Player GetInstance()
        {
            return player;
        }
    }
}
