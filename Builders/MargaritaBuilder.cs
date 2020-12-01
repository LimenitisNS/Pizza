using Pizza.Pizzas;

namespace Pizza.Builders
{
    class MargaritaBuilder : PizzaBuilder
    {
        public MargaritaBuilder()
        {
            pizza = new Margarita();
        }

        public override BlankPizza GetPizza()
        {
            BlankPizza newPizza = pizza;
            pizza = new Margarita();
            return newPizza;
        }
    }
}
