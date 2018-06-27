using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public interface ICardComponent
    {
        void Add(ICardComponent component);
        ICardComponent Get(int index);
        bool Remove(ICardComponent component);
        string Display();
    }
}
