﻿using System;
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
            Type[] monsterTypes = { typeof(Zombie), typeof(WereWolf), typeof(Giant) };
            List<Monster> monsters = new List<Monster>();

            int numOfMonsters = GetLevelModifier() * 3;
            int monsterLevel = GetLevelModifier() + 1;

            Random random = new Random();

            foreach (var _ in Enumerable.Range(0, numOfMonsters))
            {
                // int randomIdx = random.Next(0, monsterTypes.Length);

                // Monster monster = (Monster) Activator.CreateInstance(monsterTypes[randomIdx]); // TODO: Pick monster types based on player level
                Monster monster = GetMonsterType(SceneLevel);
                //  monster.Level = monsterLevel; // TODO: Add this to constructor?

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
                Monster zombie = new Zombie(monsterLevel);
                return zombie;
            }
            else if (level < 10)
            {
                Monster wereWolf = new WereWolf(monsterLevel);
                return wereWolf;
            }
            else
            {
                Monster giant = new Giant(monsterLevel);
                return giant;
            }
        }
    }
}