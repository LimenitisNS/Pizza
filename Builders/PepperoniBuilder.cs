﻿using Pizza.Components;
using Pizza.Pizzas;

namespace Pizza.Builders
{
    class PepperoniBuilder : PizzaBuilder
    {
        public PepperoniBuilder()
        {
            pizza = new Pepperoni();
        }

        public override void SetCheese()
        {
            pizza.cheese = new Cheese();
        }

        public override void SetMeat()
        {
            pizza.meat = new Meat();
        }

        public override void SetOlives()
        {

        }

        public override void SetTomatoes()
        {
            pizza.tomatoes = new Tomatoes();
        }
    }
}
