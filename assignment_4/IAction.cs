using System;
namespace Assignment4
{
    public interface IAction<T>
    {
        string Attack(T entity);
        string Defend(T entity);
    }
}