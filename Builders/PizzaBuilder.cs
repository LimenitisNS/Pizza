using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizza.Pizzas;

namespace Pizza.Builders
{
    abstract class PizzaBuilder
    {
        public BlankPizza pizza;

        public abstract void SetCheese();
        public abstract void SetTomatoes();
        public abstract void SetOlives();
        public abstract void SetMeat();
    }
}
