using Pizza.Components;
using Pizza.Pizzas;

namespace Pizza.Builders
{
    class CarbonaraBuilder : PizzaBuilder
    {
        public CarbonaraBuilder()
        {
            pizza = new Carbonara();
        }

        public override BlankPizza GetPizza()
        {
            BlankPizza newPizza = pizza;
            pizza = new Carbonara();
            return newPizza;
        }
    }
}
