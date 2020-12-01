using System;
using Pizza.Pizzas;
using Pizza.Builders;

namespace Pizza
{
    class Cafe
    {
        public BlankPizza GetPizza (string pizza)
        {
            switch(pizza)
            {

                case "Carbonara":
                    CarbonaraBuilder carbonaraBuilder = new CarbonaraBuilder();
                    carbonaraBuilder.SetCheese().SetTomatoes().SetMeat();
                    return carbonaraBuilder.pizza;

                case "Italian":
                    ItalianBuilder italianBuilder = new ItalianBuilder();
                    italianBuilder.SetCheese().SetTomatoes().SetOlives().SetMeat();
                    return italianBuilder.pizza;

                case "Margarita":
                    MargaritaBuilder margaritaBuilder = new MargaritaBuilder();
                    margaritaBuilder.SetCheese().SetTomatoes().SetOlives();
                    return margaritaBuilder.pizza;

                case "Pepperoni":
                    PepperoniBuilder pepperoniBuilder = new PepperoniBuilder();
                    pepperoniBuilder.SetCheese().SetTomatoes().SetMeat();
                    return pepperoniBuilder.pizza;

                default:
                    throw new InvalidOperationException("This pizza is not on the menu");
            }
        }
    }
}
