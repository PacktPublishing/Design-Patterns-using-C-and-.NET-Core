using System;
using System.Collections.Generic;
using System.Text;

namespace GuardiansOfTheCode
{
    public class Giant : IEnemy
    {
        private int _health;
        private readonly int _level;

        public int Health { get => _health; set => _health = value; }

        public int Level => _level;

        public Giant(int health, int level)
        {
            _health = health;
            _level = level;
        }

        public void Attack(PrimaryPlayer player)
        {
            Console.WriteLine("Giant attacks " + player.Name);
        }

        public void Defend(PrimaryPlayer player)
        {
            Console.WriteLine("Giant defends from " + player.Name);
        }
    }
}
