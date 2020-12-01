using Pizza.Pizzas;

namespace Pizza.Builders
{
    class ItalianBuilder : PizzaBuilder
    {
        public ItalianBuilder()
        {
            pizza = new Italian();
        }

        public override BlankPizza GetPizza()
        {
            BlankPizza newPizza = pizza;
            pizza = new Italian();
            return newPizza;
        }
    }
}
