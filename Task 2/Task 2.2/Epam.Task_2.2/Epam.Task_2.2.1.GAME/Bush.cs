using System;

namespace Epam.Task_2._2._1.GAME
{
    public class Bush : Barrier
    {
        public Bush(int _x, int _y) : base(_x, _y)
        {
            Name = "Bush";
        }

        public override void MovedHero(Hero hero)
        {
            Console.WriteLine("Oh you hit a Bush and it threw you 2 coordinates down!");
            hero.Y -= 2;
        }
    }
}
