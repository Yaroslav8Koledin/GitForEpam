using System;

namespace Epam.Task_2._2._1.GAME
{
    public abstract class ObjectsOnField
    {
        private int x;
        private int y;
        private string name;

        public string Name 
        { 
            get => name;
            set => name = value;
        }

        public int X
        {
            get => x;
            set
            {
                if (value > Field.Width || value < 0)
                {
                    throw new ArgumentException("Invalid coordinate X");
                }

                x = value;
            }
        }

        public int Y
        {
            get => y;
            set
            {
                if (value > Field.Heigth || value < 0)
                {
                    throw new ArgumentException("Invalid coordinate Y");
                }

                y = value;
            }
        }

        public ObjectsOnField(int _x, int _y)
        {
            X = _x;
            Y = _y;
        }

        public ObjectsOnField()
        {
            X = 1;
            Y = 1;
        }

        public bool CompareCoordinate(Hero hero)
        {
            if (X == hero.X && Y == hero.Y)
                return true;
            return false;
        }
    }
}
