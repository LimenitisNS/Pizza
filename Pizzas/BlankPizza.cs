using System;
using Pizza.Components;

namespace Pizza.Pizzas
{
    abstract class BlankPizza
    {
        public string Name { get; set; }
        public Cheese cheese { get; set; } = null;
        public Tomatoes tomatoes { get; set; } = null;
        public Olives olives { get; set; } = null;
        public Meat meat { get; set; } = null;

        public string GetComponentPizza()
        {
            string component = "";

            if (cheese != null)
                component += $"{cheese.GetNameComponent()}\n";

            if (tomatoes != null)
                component += $"{tomatoes.GetNameComponent()}\n";

            if (olives != null)
                component += $"{olives.GetNameComponent()}\n";

            if (meat != null)
                component += $"{meat.GetNameComponent()}";

            return component;
        }
    }
}
