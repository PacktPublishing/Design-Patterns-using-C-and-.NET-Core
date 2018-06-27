using System;
using System.Collections.Generic;
using System.Text;

namespace GuardiansOfTheCode
{
    public class Sword : IWeapon
    {
        private int _damage;
        public int Damage { get => _damage; }

        private int _armorDamage;
        public int ArmorDamage { get => _armorDamage; }

        public Sword(int damage, int armorDamage)
        {
            _damage = damage;
            _armorDamage = armorDamage;
        }

        public void Use(IEnemy enemy)
        {
            enemy.Health -= Damage;
            enemy.Armor -= ArmorDamage;
        }
    }
}
