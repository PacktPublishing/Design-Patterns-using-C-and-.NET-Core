using System;
using System.Collections.Generic;
using System.Text;

namespace GuardiansOfTheCode
{
    public class Gameboard
    {
        private PrimaryPlayer _player;

        public Gameboard()
        {
            _player = PrimaryPlayer.Instance;
            _player.Weapon = new Sword(12, 8);
        }

        public void PlayArea(int lvl)
        {
            if(lvl == 1)
            {
                PlayFirstLevel();
            }
        }

        public void PlayFirstLevel()
        {
            const int currentLvl = 1;
            List<IEnemy> enemies = new List<IEnemy>();
            for(int i=0; i<10; i++)
            {
                enemies.Add(EnemyFactory.SpawnZombie(currentLvl));
            }

            for(int i=0; i< 3; i++)
            {
                enemies.Add(EnemyFactory.SpawnWerewolf(currentLvl));
            }

            foreach (var enemy in enemies)
            {
                while(enemy.Health > 0 || _player.Health > 0)
                {
                    _player.Weapon.Use(enemy);
                    enemy.Attack(_player);
                }
            }
        }
    }
}
