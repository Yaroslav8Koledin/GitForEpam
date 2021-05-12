using System;

namespace Epam.Task_2._1._2.CUSTOM_PAINT
{
    public class Square:IFigure
    {
        private int a;

        public Square()
        {
            A = 0;
        }

        public Square(int _a)
        {
            A = _a;
        }

        public int A 
        {
            get => a;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Side of square can't be less than 0");
                }

                a = value;
            }
        }

        public int Area => A * A;

        public int Perimetr => 4 * A;

        public void Input()
        {
            Console.WriteLine("ВЫВОД: Введите параметры фигуры Квадрат");
            do
            {
                try
                {
                    Console.Write("ВВОД: A = ");
                    A = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (A == 0);
        }

        public void Print()
        {
            Console.WriteLine($"Square with a side {a}, Area = {Area} and Perimetr = {Perimetr}");
        }
    }
}
