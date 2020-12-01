using Pizza.Components.Interface;

namespace Pizza.Components
{
    class Cheese : IComponent
    {
        public string GetNameComponent()
        {
            return "Cheese";
        }
    }
}
