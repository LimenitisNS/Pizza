using Pizza.Components;
using Pizza.Pizzas;

namespace Pizza.Builders
{
    class MargaritaBuilder : PizzaBuilder
    {
        public MargaritaBuilder()
        {
            pizza = new Margarita();
        }

        public override void SetCheese()
        {
            pizza.cheese = new Cheese();
        }

        public override void SetMeat()
        {

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
