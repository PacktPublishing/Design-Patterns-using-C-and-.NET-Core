using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class Card
    {
        protected string _name;
        protected int _attack;
        protected int _defense;

        public Card(string name, int attack, int defense)
        {
            _name = name;
            _attack = attack;
            _defense = defense;
        }

        public virtual string Name
        {
            get
            {
                return _name;
            }
        }

        public virtual int Attack
        {
            get
            {
                return _attack;
            }
        }

        public virtual int Defense
        {
            get
            {
                return _defense;
            }
        }

    }
}
