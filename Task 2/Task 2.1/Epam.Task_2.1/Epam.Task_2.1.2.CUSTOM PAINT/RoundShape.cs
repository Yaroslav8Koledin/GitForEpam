using System;

namespace Epam.Task_2._1._2.CUSTOM_PAINT
{
    public abstract class RoundShape : IFigure
    {
        private int radius;

        public RoundShape()
        {
            X = 0;
            Y = 0;
            Radius = 0;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public int Radius
        {
            get => radius;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Radius cannot be less than 0");
                }

                radius = value;
            }
        }

        public virtual void Input()
        {
            Console.WriteLine("ВЫВОД: Введите координаты центра");
            X = InputCoordinate("X");
            Y = InputCoordinate("Y");
            do
            {
                try
                {
                    Console.Write("ВВОД: Radius = ");
                    Radius = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (Radius == 0);
        }

        private static int InputCoordinate(string _coordinateName)
        {
            int inputNumber;
            bool flag;
            do
            {
                Console.Write($"ВВОД: {_coordinateName} = ");
                flag = int.TryParse(Console.ReadLine(), out inputNumber);
            } while (!flag);

            return inputNumber;
        }

        public virtual void Print() 
        {
            Console.Write($" centered at a point ({X}, {Y}), Radius = {Radius}");
        }
    }
}
