using System;

namespace Epam.Task_2._1._2.CUSTOM_PAINT
{
    public class Round : RoundShape
    {
        public Round() : base() {}

        public Round(int _x, int _y, int _radius)
        {
            X = _x;
            Y = _y;
            Radius = _radius;
        }

        public int Area => (int)(Math.PI * Math.Pow(Radius, 2));

        public override void Print()
        {
            Console.Write("Round");
            base.Print();
            Console.WriteLine($" and Area = {Area}");
        }

        public override void Input()
        {
            Console.WriteLine("ВЫВОД: Введите параметры фигуры Круг");
            base.Input();
        }
    }
}
