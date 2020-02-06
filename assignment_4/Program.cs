using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = Player.GetInstance();
            player.Level = 10;

            Scene scene = new Scene(player);

            List<Monster> monsters = scene.SpawnMonstersForLevel(player.Level);

            Console.WriteLine(scene.MonstersInfo(monsters));

            Console.ReadKey();
        }
    }
}
