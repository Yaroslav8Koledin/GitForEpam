using System;

namespace Epam.Task_2._2._1.GAME
{
    public class Bonuse:ObjectsOnField
    {
        public Bonuse(int _x, int _y):base(_x, _y)
        {
            Name = "Bonuse";
        }

        public Bonuse():base()
        {

        }

        public bool GetBonuse(Hero hero)
        {
            bool flag = base.CompareCoordinate(hero);
            if (flag)
            {
                Console.WriteLine("Congratulations you have collected a bonus and received one life as a gift!");
                hero.Life++;
                return true;
            }

            return false;
        }
    }
}
