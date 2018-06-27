using System;
using System.Collections.Generic;
using System.Text;

namespace GuardiansOfTheCode
{
    public interface IEnemy
    {
        int Health { get; set; }
        int Level { get; }
        int OvertimeDamage { get; set; }
        int Armor { get; set; }
        bool Paralyzed { get; set; }
        int ParalyzedFor { get; set; }
        void Attack(PrimaryPlayer player);
        void Defend(PrimaryPlayer player);
    }
}
