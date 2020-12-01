using Pizza.Components;
using Pizza.Pizzas;

namespace Pizza.Builders
{
    class ItalianBuilder : PizzaBuilder
    {
        public ItalianBuilder()
        {
            pizza = new Italian();
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
            pizza.olives = new Olives();
        }

        public override void SetTomatoes()
        {
            pizza.tomatoes = new Tomatoes();
        }
    }
}
