using System;
using System.Collections.Generic;
using System.Text;

namespace GuardiansOfTheCode.Commands
{
    public class PlayerEnemyBattleCommand : ICommand
    {
        private PrimaryPlayer _player;

        private IEnemy _enemy;

        public PlayerEnemyBattleCommand(PrimaryPlayer player, IEnemy enemy)
        {
            _player = player;
            _enemy = enemy;
        }

        public void Execute()
        {
            PlayerAttacks();
            if(_enemy.Health >= 0)
            {
                EnemyAttacks();
            }
        }

        private void PlayerAttacks()
        {
            _player.Weapon.Use(_enemy);
        }

        private void EnemyAttacks()
        {
            int damage = _enemy.Attack(_player);
            _player.Hit(damage);
        }
    }
}
