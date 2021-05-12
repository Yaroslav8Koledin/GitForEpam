using System;

namespace Epam.Task_2._1._2.CUSTOM_PAINT
{
    public class Rectangle : IFigure
    {
        private int a;
        private int b;

        public Rectangle()
        {
            A = 0;
            B = 0;
        }
        public Rectangle(int _a, int _b)
        {
            A = _a;
            B = _b;
        }

        public int A
        {
            get => a;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Side of rectangle can't be less than 0");
                }

                a = value;
            }
        }

        public int B
        {
            get => b;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Side of rectangle can't be less than 0");
                }

                b = value;
            }
        }

        public int Area => A * B;

        public int Perimetr => 2 * (a + b);

        public void Input()
        {
            Console.WriteLine("ВЫВОД: Введите параметры фигуры Прямоугольник");
            do
            {
                try
                {
                    Console.Write($"ВВОД: A = ");
                    A = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (A == 0);

            do
            {
                try
                {
                    Console.Write($"ВВОД: B = ");
                    B = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (B == 0);
        }

        public void Print()
        {
            Console.WriteLine($"Rectangle with sides a = {A}, b = {B}, Area = {Area} and Perimetr = {Perimetr}");
        }
    }
}
