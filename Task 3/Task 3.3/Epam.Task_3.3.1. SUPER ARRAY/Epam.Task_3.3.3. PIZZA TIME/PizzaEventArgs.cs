using System;

namespace Epam.Task_3._3._3.PIZZA_TIME
{
    public class PizzaEventArgs:EventArgs
    {
        public string NameOfPizza { get; }
        public string NameOfPerson { get; }

        public PizzaEventArgs(string nameOfPerson, string namePfPizza)
        {
            NameOfPerson = nameOfPerson;
            NameOfPizza = namePfPizza;
        }
    }
}
