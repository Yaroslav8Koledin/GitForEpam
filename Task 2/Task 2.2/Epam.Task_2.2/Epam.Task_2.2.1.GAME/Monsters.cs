using System;

namespace Epam.Task_2._2._1.GAME
{
    public abstract class Monsters:ObjectsOnField
    {

        public Monsters(int _x, int _y):base(_x, _y)
        {
        }

        public bool Attack(Hero hero)
        {
            Step();
            bool flag = base.CompareCoordinate(hero);
            if (flag)
            { 
                Console.WriteLine("Ooh.... You lost your life, but managed to defeat this wild bear!");
                hero.Life--;
                return true;
            }

            return false;
        }

        public abstract void Step();
    }
}