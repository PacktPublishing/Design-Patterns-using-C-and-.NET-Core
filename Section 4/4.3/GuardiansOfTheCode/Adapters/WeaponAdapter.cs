using MilkyWayponLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuardiansOfTheCode.Adapters
{
    public class WeaponAdapter : IWeapon
    {
        private ISpaceWeapon _spaceWeapon;

        public WeaponAdapter(ISpaceWeapon spaceWeapon)
        {
            _spaceWeapon = spaceWeapon;
        }

        public int Damage => _spaceWeapon.ImpactDamage + _spaceWeapon.LaserDamage;

        public void Use(IEnemy enemy)
        {
            enemy.Health -= _spaceWeapon.Shoot();
        }
    }
}
