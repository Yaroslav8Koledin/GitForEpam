using System;

namespace Epam.Task_2._1._2.CUSTOM_PAINT
{
    public class Circle : RoundShape
    {
        public Circle() : base() { }

        public Circle(int _x, int _y, int _radius)
        {
            X = _x;
            Y = _y;
            Radius = _radius;
        }

        public int Length
        {
            get => (int)(2 * Math.PI * Radius);

        }

        public override void Print()
        {
            Console.Write("Circle");
            base.Print();
            Console.WriteLine($" and Length = {Length}");
        }

        public override void Input()
        {
            Console.WriteLine("ВЫВОД: Введите параметры фигуры Окружность");
            base.Input();
        }
    }
}
