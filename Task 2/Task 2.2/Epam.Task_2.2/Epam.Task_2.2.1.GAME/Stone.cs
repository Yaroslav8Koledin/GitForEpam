using System;

namespace Epam.Task_2._2._1.GAME
{
    public class Stone : Barrier
    {
        public Stone(int _x, int _y) : base(_x, _y)
        {
            Name = "Stone"; 
        }

        public override void MovedHero(Hero hero)
        {
            Console.WriteLine("Oh you hit a rock and it threw you 1 coordinate to the right!");
            hero.X++;
        }
    }
}
