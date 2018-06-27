using System;
using System.Collections.Generic;
using System.Text;

namespace GuardiansOfTheCode
{
    public class Zombie : IEnemy
    {
        private int _health;
        private readonly int _level;

        public int Health { get => _health; set => _health = value; }

        public int Level => _level;

        public Zombie(int health, int level)
        {
            _health = health;
            _level = level;
        }

        public void Attack(PrimaryPlayer player)
        {
            Console.WriteLine("Zombie attacking " + player.Name);
        }

        public void Defend(PrimaryPlayer player)
        {
            Console.WriteLine("Zombie defending from " + player.Name);
        }
    }
}
