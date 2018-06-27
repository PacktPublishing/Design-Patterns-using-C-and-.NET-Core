using System;
using System.Collections.Generic;
using System.Text;

namespace GuardiansOfTheCode
{
    public interface IEnemy
    {
        int Health { get; set; }
        int Level { get; }
        void Attack(PrimaryPlayer player);
        void Defend(PrimaryPlayer player);
    }
}
