using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class DefenseDecorator : CardDecorator
    {
        public DefenseDecorator(Card card, string name, int defense) : base(card, name, 0, defense)
        {
        }
    }
}
