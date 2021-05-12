using System;

namespace Epam.Task_3._3._3.PIZZA_TIME
{
    public class User
    {
        public EventHandler<PizzaEventArgs> UserEvent=delegate { };

        public string Name { get; set; }

        public User(string _name)
        {
            Name = _name;
        }

        public void GetOrder(string nameOfPizza)
        {
            UserEvent?.Invoke(this, new PizzaEventArgs(Name, nameOfPizza));
        }
    }
}
