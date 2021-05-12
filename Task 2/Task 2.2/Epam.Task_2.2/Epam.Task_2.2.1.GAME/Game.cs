using System;
using System.Collections.Generic;

namespace Epam.Task_2._2._1.GAME
{
    public class Game
    {
        private Hero hero;
        private List<ObjectsOnField> objectsOnField;
        private int CountOfBonuses;

        public Game()
        {
            Field.Width = 10;
            Field.Heigth = 10;
            hero = new Hero();
            CountOfBonuses = 3;
            objectsOnField = new List<ObjectsOnField> { new BearMonster(3, 4), new WolfMonster(1, 2), new Bonuse(4, 5), new Bonuse(7, 3), new Bonuse(3, 4), new Bush(3, 6), new Tree(9, 9), new Stone(4, 8) };
        }

        private void Step(string step)
        {
            try
            {
                hero.Step(step);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            int indexOfObject = 0;
            while (indexOfObject < objectsOnField.Count)
            {
                if (objectsOnField[indexOfObject] is Barrier)
                {
                    var barrier = objectsOnField[indexOfObject] as Barrier;
                    barrier.Resist(hero);
                    indexOfObject++;
                }
                else
                {
                    bool flag;
                    if (objectsOnField[indexOfObject] is Monsters)
                    {
                        var monster = objectsOnField[indexOfObject] as Monsters;
                        flag = monster.Attack(hero);
                    }
                    else
                    {
                        var bonuse = objectsOnField[indexOfObject] as Bonuse;
                        flag = bonuse.GetBonuse(hero);
                        if (flag)
                        {
                            CountOfBonuses--;
                        }
                    }

                    if (flag)
                    {
                        objectsOnField.Remove(objectsOnField[indexOfObject]);
                    }
                    else
                    {
                        indexOfObject++;
                    }
                }
            }

            CheckCountOfBonuses();
        }

        private void CheckCountOfBonuses()
        {
            if (CountOfBonuses == 0)
            {
                Console.WriteLine("Congratulations you have won!");
                Environment.Exit(0);
            }
        }

        public void Play()
        {
            Console.WriteLine("Now your hero is in position (1, 1) and 3 lives. Select move on:\n1. Up \n2. Down\n3. Left\n4. Right\n5. Finish the game");
            string s = Console.ReadLine();
            while (!string.IsNullOrEmpty(s))
            {
                switch (s)
                {
                    case "1":
                        Step("Up");
                        break;
                    case "2":
                        Step("Down");
                        break;
                    case "3":
                        Step("Left");
                        break;
                    case "4":
                        Step("Right");
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }

                Console.WriteLine($"Hero position ({hero.X}, {hero.Y}) and count of life = {hero.Life}");
                foreach (var item in objectsOnField)
                {
                    Console.WriteLine($"{item.Name} position ({item.X}, {item.Y})");
                }

                Console.WriteLine("Select move on:\n1. Up \n2. Down\n3. Left\n4. Right\n5. Finish the game");
                s = Console.ReadLine();
            }
        }
    }
}
