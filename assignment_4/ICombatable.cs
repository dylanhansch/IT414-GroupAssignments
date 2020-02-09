using System;
namespace Assignment4
{
    public interface ICombatable
    {
        int Health { get; set; }
        string Attack(Combatable subject);
        string Defend(Combatable subject);
    }
}