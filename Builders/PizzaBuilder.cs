using Pizza.Components;
using Pizza.Pizzas;

namespace Pizza.Builders
{
    abstract class PizzaBuilder
    {
        public BlankPizza pizza;

        public PizzaBuilder SetCheese()
        {
            pizza.cheese = new Cheese();
            return this;
        }
        public PizzaBuilder SetTomatoes()
        {
            pizza.tomatoes = new Tomatoes();
            return this;
        }
        public PizzaBuilder SetOlives()
        {
            pizza.olives = new Olives();
            return this;
        }
        public PizzaBuilder SetMeat()
        {
            pizza.meat = new Meat();
            return this;
        }

        public abstract BlankPizza GetPizza();
    }
}
