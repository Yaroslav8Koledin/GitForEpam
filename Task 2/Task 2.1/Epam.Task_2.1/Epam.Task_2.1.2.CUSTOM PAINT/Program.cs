using System;
using System.Collections.Generic;

namespace Epam.Task_2._1._2.CUSTOM_PAINT
{
    internal class Program
    {
        public static Dictionary<string, User> users = new Dictionary<string, User>();
        private static void Main()
        {
            Console.Write("Введите имя пользвателя: ");
            string name = Console.ReadLine();
            User user = new User(name);
            users.Add(name, user);
            int k = 0;
            do
            {
                Console.Write("ВЫВОД: Выберите действие\n1. Добавить фигуру\n2. Вывести фигуры\n3. Очистить холст\n4. Сменить пользователя\n5. Выход\nВВОД: ");
                int.TryParse(Console.ReadLine(), out k);
                switch (k)
                {
                    case 1:
                        Console.WriteLine("Выберите тип фигуры\n\t1. Линия\n\t2. Круг\n\t3. Прямоугольник\n\t4. Квадрат\n\t5. Кольцо\n\t6. Окружность");
                        ChooseFigure(user);
                        break;
                    case 2:
                        user.Output();
                        break;
                    case 3:
                        user.ClearFigure();
                        break;
                    case 4:
                        Console.Write("Введите имя пользвателя: ");
                        name = Console.ReadLine();
                        bool flag = users.TryGetValue(name, out user);
                        if (!flag)
                        {
                            user = new User(name);
                            users.Add(name, user);
                        }
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Uncorrect choice");
                        break;
                }
            } while (k != 5);
        }

        private static void ChooseFigure(User user)
        {
            int number;
            int.TryParse(Console.ReadLine(), out number);
            switch (number)
            {
                case 1:
                    user.AddFigure(new Line());
                    break;
                case 2:
                    user.AddFigure(new Circle());
                    break;
                case 3:
                    user.AddFigure(new Rectangle());
                    break;
                case 4:
                    user.AddFigure(new Square());
                    break;
                case 5:
                    user.AddFigure(new Ring());
                    break;
                case 6:
                    user.AddFigure(new Round());
                    break;
                default:
                    break;
            }
        }
    }
}