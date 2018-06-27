using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class CardDeck : ICardComponent
    {
        private List<ICardComponent> _components = new List<ICardComponent>();


        public void Add(ICardComponent component)
        {
            _components.Add(component);
        }

        public bool Remove(ICardComponent component)
        {
            return _components.Remove(component);
        }

        ICardComponent ICardComponent.Get(int index)
        {
            return _components[index];
        }

        public string Display()
        {
            StringBuilder builder = new StringBuilder();
            foreach (var component in _components)
            {
                builder.Append(component.Display() + "\r\n");
            }
            return builder.ToString();
        }
    }
}
