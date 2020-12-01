using System;
using Pizza.Pizzas;
using Pizza.Builders;

namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaBuilder carbonaraBuilder = new CarbonaraBuilder();
            carbonaraBuilder.SetCheese();
            carbonaraBuilder.SetMeat();
            carbonaraBuilder.SetOlives();
            carbonaraBuilder.SetTomatoes();

            BlankPizza pizza1 = carbonaraBuilder.pizza;
            Console.WriteLine(pizza1.GetComponentPizza());

            carbonaraBuilder.SetCheese();
            carbonaraBuilder.SetTomatoes();

            BlankPizza pizza2 = carbonaraBuilder.pizza;
            Console.WriteLine("\n" + pizza2.GetComponentPizza());
            Console.ReadKey();
        }
    }
}
