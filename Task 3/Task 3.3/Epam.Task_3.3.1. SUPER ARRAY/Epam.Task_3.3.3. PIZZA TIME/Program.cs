namespace Epam.Task_3._3._3.PIZZA_TIME
{
    class Program
    {
        static void Main()
        {
            Pizzeria pizzeria = new Pizzeria();
            
            User Anna = new User("Anna");
            User Gleb = new User("Gleb");
            User Kris = new User("Kristina");

            Anna.UserEvent += pizzeria.AdditionalThread;
            Gleb.UserEvent += pizzeria.AdditionalThread;
            Kris.UserEvent += pizzeria.AdditionalThread;

            Anna.GetOrder("Margarita");
            //Gleb.GetOrder("Sicilian");
            //Kris.GetOrder("Calzone");

        }

    }
}
