using System;
using System.Collections.Generic;
using System.Text;

namespace GuardiansOfTheCode
{
    public interface IWeapon
    {
        int Damage { get; }
        void Use(IEnemy enemy);
    }
}
