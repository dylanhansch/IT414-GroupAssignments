using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class MonsterFormatter : IFormatter<Monster>
    {
        public string Format(Monster monster)
        {
            StringBuilder builder = new StringBuilder();

            builder.Append($"Monster Type: {monster.GetType().Name}\n");
            builder.Append($"Monster Level: {monster.Level}\n");
            builder.Append($"Monster Health: {monster.Health}\n");

            return builder.ToString();
        }
    }
}
