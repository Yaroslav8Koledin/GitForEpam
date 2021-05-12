using System;

namespace Epam.Task_2._1._2.CUSTOM_PAINT
{
    public class Ring : RoundShape
    {
        private int internalRadius;

        public Ring()
        {
            X = 0;
            Y = 0;
            Radius = 0;
            internalRadius = 0;
        }

        public Ring(int _x, int _y, int _externalRadius, int _internalRadius)
        {
            if (_internalRadius > _externalRadius)
            {
                throw new ArgumentException();
            }
            else
            {
                Radius = _externalRadius;
                internalRadius = _internalRadius;
                X = _x;
                Y = _y;
            }
        }

        public int InternalRadius
        {
            get => internalRadius;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Radius cannot be negative");
                }

                if (value > Radius)
                {
                    throw new ArgumentException("internal radius cannot be more than external radius");
                }

                internalRadius = value;
            }
        }

        public double Area => Math.PI * (Math.Pow(Radius, 2) - Math.Pow(internalRadius, 2));

        public double LengthOfBigCircle => Math.PI * 2 * Radius;

        public double LengthOfSmallCircle => Math.PI * 2 * internalRadius;

        public override void Print()
        {
            Console.Write("Ring");
            base.Print();
            Console.WriteLine($", internal radius = {internalRadius}, Area ~ {(int)Area}, length of big circle ~ {(int)LengthOfBigCircle}, length of small sircle ~ {(int)LengthOfSmallCircle}");
        }

        public override void Input()
        {
            Console.WriteLine("ВЫВОД: Введите параметры фигуры Кольцо");
            base.Input();
            do
            {
                Console.Write("ВВОД: Internal radius = ");
                try
                {
                    InternalRadius = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (InternalRadius == 0);
        }
    }
}
