using System;
using System.Collections.Generic;
using System.Text;

namespace GuardiansOfTheCode.Strategies
{
    public interface IDamageIndicator
    {
        void NotifyAboutDamage(int health, int damage);
    }
}
