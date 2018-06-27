using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class CardDecorator : Card
    {
        protected Card _card;

        public CardDecorator(Card card, string name, int attack, int defense) : base(name, attack, defense)
        {
            _card = card; 
        }

        public override string Name
        {
            get
            {
                return $"{_card.Name}, {_name}";
            }
        }

        public override int Attack
        {
            get
            {
                return _card.Attack + _attack;
            }
        }

        public override int Defense
        {
            get
            {
                return _card.Defense + _defense;
            }
        }
    }
}
