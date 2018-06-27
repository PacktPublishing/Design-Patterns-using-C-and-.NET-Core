using System;
using System.Collections.Generic;
using System.Text;

namespace GuardiansOfTheCode
{
    public sealed class PrimaryPlayer
    {
        private static readonly PrimaryPlayer _instance;

        private PrimaryPlayer() { }

        public IWeapon Weapon { get; set; }

        static PrimaryPlayer()
        {
            _instance = new PrimaryPlayer()
            {
                Name = "Raptor",
                Level = 1,
                Armor = 25,
                Health = 100
            };
        }

        public static PrimaryPlayer Instance
        {
            get
            {
                return _instance;
            }
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public int Armor { get; set; }
        public int Health { get; set; }
    }
}
