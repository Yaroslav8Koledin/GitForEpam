using System;

namespace Epam.Task_2._2._1.GAME
{
    public class Tree : Barrier
    {
        public Tree(int _x, int _y) : base(_x, _y)
        {
            Name = "Tree";
        }

        public override void MovedHero(Hero hero)
        {
            Console.WriteLine("Oh you hit a tree and it threw you 1 coordinate to the left!");
            hero.Y--;
        }
    }
}
