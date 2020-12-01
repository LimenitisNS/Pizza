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
            carbonaraBuilder.SetCheese().SetTomatoes().SetOlives().SetMeat();

            BlankPizza pizza1 = carbonaraBuilder.GetPizza();
            Console.WriteLine(pizza1.GetComponentPizza());

            carbonaraBuilder.SetCheese().SetMeat();

            BlankPizza pizza2 = carbonaraBuilder.GetPizza();
            Console.WriteLine("\n" + pizza2.GetComponentPizza());
            Console.ReadKey();
        }
    }
}
