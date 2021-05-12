using System;

namespace Epam.Task_2._2._1.GAME
{
    public class Hero:ObjectsOnField
    {
        private int life = 2;

        public int Life
        {
            get => life;
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("I'm sorry you lost!");
                    Environment.Exit(0);
                }

                life = value;
            }
        }

        public void Step(string s)
        {
            switch (s)
            {
                case "Up":
                    Y++;
                    break;
                case "Down":
                    Y--;
                    break;
                case "Left":
                    X--;
                    break;
                case "Right":
                    X++;
                    break;
                default:
                    break;
            }
        }
    }
}
