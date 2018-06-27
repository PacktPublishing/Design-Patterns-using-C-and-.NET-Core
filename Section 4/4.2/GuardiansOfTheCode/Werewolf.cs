using System;
using System.Collections.Generic;
using System.Text;

namespace GuardiansOfTheCode
{
    public class Werewolf : IEnemy
    {
        private int _health;
        private readonly int _level;

        public int Health { get => _health; set => _health = value; }

        public int Level => _level;

        public int OvertimeDamage { get; set; }
        public int Armor { get; set; }
        public bool Paralyzed { get; set; }
        public int ParalyzedFor { get; set; }

        public Werewolf(int health, int level)
        {
            _health = health;
            _level = level;
        }

        public void Attack(PrimaryPlayer player)
        {
            Console.WriteLine("Zombie attacks " + player.Name);
        }

        public void Defend(PrimaryPlayer player)
        {
            Console.WriteLine("Zombie defends from  " + player.Name);
        }
    }
}
