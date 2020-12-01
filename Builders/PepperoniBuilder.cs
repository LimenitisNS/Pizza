using Pizza.Pizzas;

namespace Pizza.Builders
{
    class PepperoniBuilder : PizzaBuilder
    {
        public PepperoniBuilder()
        {
            pizza = new Pepperoni();
        }

        public override BlankPizza GetPizza()
        {
            BlankPizza newPizza = pizza;
            pizza = new Pepperoni();
            return newPizza;
        }
    }
}
