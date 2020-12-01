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
                    SetComponent(carbonaraBuilder);
                    return carbonaraBuilder.pizza;

                case "Italian":
                    ItalianBuilder italianBuilder = new ItalianBuilder();
                    SetComponent(italianBuilder);
                    return italianBuilder.pizza;

                case "Margarita":
                    MargaritaBuilder margaritaBuilder = new MargaritaBuilder();
                    SetComponent(margaritaBuilder);
                    return margaritaBuilder.pizza;

                case "Pepperoni":
                    PepperoniBuilder pepperoniBuilder = new PepperoniBuilder();
                    SetComponent(pepperoniBuilder);
                    return pepperoniBuilder.pizza;

                default:
                    throw new InvalidOperationException("This pizza is not on the menu");
            }
        }

        private void SetComponent(PizzaBuilder pizza)
        {
            pizza.SetCheese();
            pizza.SetMeat();
            pizza.SetOlives();
            pizza.SetTomatoes();
        }
        
    }
}
