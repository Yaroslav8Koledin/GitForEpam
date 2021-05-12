using System;
using System.Collections.Generic;

namespace Epam.Task_3._1._1._WEAKEST_LINK
{
    internal class Program
    {
        private static void Main()
        {
            var queue = new Queue<int>();
            Console.WriteLine("ВЫВОД: Введите N");
            int numberOfPeople = GetNumberOfPeople();

            Console.WriteLine("ВЫВОД: Введите, какой по счету человек будет вычеркнут каждый раунд:");
            int numToStrikeOut = GetNumberOfPeople();

            Console.WriteLine($"ВЫВОД: Сгенерирован круг людей. Начинаем вычеркивать каждого {numToStrikeOut}.");
            for (int i = 0; i < numberOfPeople; i++)
            {
                queue.Enqueue(i + 1);
            }

            CrossOutEveryN(queue, numToStrikeOut);

            Console.WriteLine("ВЫВОД: Игра окончена. Невозможно вычеркнуть больше людей.");
        }

        private static void CrossOutEveryN(Queue<int> queue, int numToStrikeOut)
        {
            int round = 1;
            while (queue.Count >= numToStrikeOut)
            {
                for (int i = 0; i < numToStrikeOut-1; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                    
                }
                queue.Dequeue();
                Console.WriteLine($"ВЫВОД: Раунд {round}. Вычеркнут человек. Людей осталось: {queue.Count}");
                round++;
            }
        }

        private static int GetNumberOfPeople()
        {
            int inputNumberOfPeople;
            bool flag;
            do
            {
                Console.Write("ВЫВОД: ");
                flag = int.TryParse(Console.ReadLine(), out inputNumberOfPeople);
            } while (!flag);

            return inputNumberOfPeople;
        }
    }
}