using Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;r
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using GuardiansOfTheCode.Proxies;

namespace GuardiansOfTheCode.Facades
{
    public class GameboardFacade
    {
        private PrimaryPlayer _player;
        private int _areaLevel;
        private HttpClient _http;
        private EnemyFactory _factory;
        private List<IEnemy> _enemies = new List<IEnemy>();
        private CardsProxy _cardsProxy;

        public GameboardFacade()
        {
            _cardsProxy = new CardsProxy();
        }

        public async Task Play(PrimaryPlayer player, int areaLevel)
        {
            _player = player;
            _areaLevel = areaLevel;
            ConfigurePlayerWeapon();
            await AddPlayerCards();
            InitializeEnemyFactory(areaLevel);
            LoadZombies(areaLevel);
            LoadWerewolves(areaLevel);
            LoadGiants(areaLevel);
            //Begin Playing Logic
        }

        private void ConfigurePlayerWeapon()
        {
            string input;
            int choice;
            while(true)
            {
                Console.WriteLine("Pick a weapon: ");
                Console.WriteLine("1. Sword");
                Console.WriteLine("2. Fire Staff");
                Console.WriteLine("3. Ice Staff");
                input = Console.ReadLine();
                if( Int32.TryParse(input, out choice) )
                {
                    if(choice == 1)
                    {
                        _player.Weapon = new Sword(15, 7);
                        break;
                    }
                    else if(choice == 2)
                    {
                        _player.Weapon = new FireStaff(12, 14);
                        break;
                    }
                    else if(choice == 3)
                    {
                        _player.Weapon = new IceStaff(5, 1);
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }

        private async Task AddPlayerCards()
        {
            _player.Cards = (await _cardsProxy.GetCards()).ToArray();
        }

        private void InitializeEnemyFactory(int areaLevel)
        {
            _factory = new EnemyFactory(areaLevel);
        }

        private void LoadZombies(int areaLevel)
        {
            int count;
            if(areaLevel < 3)
            {
                count = 10;
            }
            else if(areaLevel >= 3 && areaLevel< 10)
            {
                count = 20;
            }
            else
            {
                count = 30;
            }
            for(int i=0; i<count; i++)
            {
                _enemies.Add(_factory.SpawnZombie(areaLevel));
            }
        }

        private void LoadWerewolves(int areaLevel)
        {
            int count;
            if (areaLevel < 5)
            {
                count = 3;
            }
            else
            {
                count = 10;
            }
            for (int i = 0; i < count; i++)
            {
                _enemies.Add(_factory.SpawnWerewolf(areaLevel));
            }
        }

        private void LoadGiants(int areaLevel)
        {
            int count;
            if (areaLevel < 8)
            {
                count = 1;
            }
            else
            {
                count = 3;
            }
            for (int i = 0; i < count; i++)
            {
                _enemies.Add(_factory.SpawnGiant(areaLevel));
            }
        }
    }
}
