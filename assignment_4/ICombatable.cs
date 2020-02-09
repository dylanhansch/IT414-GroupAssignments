using System;
namespace Assignment4
{
    public interface ICombatable
    {
        int Health { get; set; }
        int Level { get; set; }

        string Attack(ICombatable subject);
        string Defend(ICombatable subject);
    }
}