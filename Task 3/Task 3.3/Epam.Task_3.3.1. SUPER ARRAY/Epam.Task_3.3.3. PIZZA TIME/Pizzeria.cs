using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Epam.Task_3._3._3.PIZZA_TIME
{
    public class Pizzeria
    {
        public event EventHandler<PizzaEventArgs> PizzaEvent;

        public void AdditionalThread(object sender, PizzaEventArgs e)
        {
            ThreadStart ths = () => { CookingPizza(e.NameOfPerson, e.NameOfPizza); };
            Thread thread1 = new Thread(ths);
            thread1.Start();
            OnMyEvent(e.NameOfPerson, e.NameOfPizza);
        }

        private void OnMyEvent(string nameOfPerson, string nameOfPizza)
        {
            PizzaEvent?.Invoke(this, new PizzaEventArgs(nameOfPerson, nameOfPizza));
        }

        private async Task CookingPizza(string nameOfPerson, string nameOfPizza)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            switch (nameOfPizza)
            {
                case "Margarita":
                    //if (stopwatch.ElapsedMilliseconds <= 30000)
                    //{
                    //    break;
                    //}
                    await Task.Delay(3000);
                    break;
                case "B-B-Q":
                    Thread.Sleep(5000);
                    break;
                case "Sicilian":
                    Thread.Sleep(5500);
                    break;
                case "Hawaiian":
                    Thread.Sleep(1000);
                    break;
                case "Calzone":
                    Thread.Sleep(350);
                    break;
                case "Four cheeses":
                    Thread.Sleep(10000);
                    break;
                default:
                    break;
            }

            Console.WriteLine($"{nameOfPerson} your pizza is ready");
        }
    }
}
