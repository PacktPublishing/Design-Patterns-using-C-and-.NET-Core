using Common;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Linq;
using GuardiansOfTheCode.Adapters;
using MilkyWayponLib;

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

        public async Task PlayArea(int lvl)
        {
            if(lvl == 1)
            {
                _player.Cards = (await FetchCards()).ToArray();
                Console.WriteLine("Ready to play Level 1?");
                Console.ReadKey();
                PlayFirstLevel();
            }
            else if(lvl == -1)
            {
                Console.WriteLine("Play special level?");
                Console.ReadKey();
                PlaySpecialLevel();
            }
        }

        private void PlaySpecialLevel()
        {
            _player.Weapon = new WeaponAdapter(new Blaster(20, 15, 15));
        }

        public void PlayFirstLevel()
        {
            const int currentLvl = 1;
            EnemyFactory factory = new EnemyFactory(currentLvl);
            List<IEnemy> enemies = new List<IEnemy>();
            for(int i=0; i<10; i++)
            {
                enemies.Add(factory.SpawnZombie(currentLvl));
            }

            for(int i=0; i< 3; i++)
            {
                enemies.Add(factory.SpawnWerewolf(currentLvl));
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

        private async Task<IEnumerable<Card>> FetchCards()
        {
            using (var http = new HttpClient())
            {
                var cardsJson = await http.GetStringAsync("http://localhost:10833/api/cards");
                return JsonConvert.DeserializeObject<IEnumerable<Card>>(cardsJson);
            }
        }
    }
}
