using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Scene
    {
        private readonly Player player;
        public int SceneLevel = 1;

        public Scene(Player player)
        {
            this.player = player;
        }

        public Scene(Player player, int sceneLevel)
        {
            this.player = player;
            this.SceneLevel = sceneLevel;
        }

        public List<Monster> SpawnMonstersForLevel(int level)
        {
            List<Monster> monsters = new List<Monster>();

            int numOfMonsters = GetLevelModifier() * 3;

            Random random = new Random();

            foreach (var _ in Enumerable.Range(0, numOfMonsters))
            {
                Monster monster = GetMonsterType(SceneLevel);
                monsters.Add(monster);
            }

            return monsters;
        }

        public string MonstersInfo(List<Monster> monsters)
        {
            StringBuilder builder = new StringBuilder();

            foreach (Monster monster in monsters)
            {
                builder.Append(new MonsterFormatter().Format(monster));
                builder.Append("\n");
            }

            return builder.ToString();
        }

        private int GetLevelModifier()
        {
            return (SceneLevel + player.Level) / 2;
        }

        private Monster GetMonsterType(int level)
        {
            int monsterLevel = GetLevelModifier() + 1;
            if(level < 5)
            {
                Monster zombie = new Zombie();
                zombie.Level = monsterLevel;
                return zombie;
            }
            else if (level < 10)
            {
                Monster wereWolf = new WereWolf();
                wereWolf.Level = monsterLevel;
                return wereWolf;
            }
            else
            {
                Monster giant = new Giant();
                giant.Level = monsterLevel;
                return giant;
            }
        }
    }
}