using Common;
using MilkyWayponLib;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace GuardiansOfTheCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrimaryPlayer player = PrimaryPlayer.Instance;
            //Console.WriteLine($"{player.Name} - lvl {player.Level}");
            try
            {
                TestApiConnection().Wait();
                Gameboard board = new Gameboard();
                board.PlayArea(1).Wait();
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to initialize game");
                Console.ReadKey();
            }
        }

        private static async Task TestApiConnection()
        {
            int maxAttempts = 20;

            //Interval in milliseconds
            int attemptInterval = 2000;
            using (var http = new HttpClient())
            {
                for (int i = 0; i < maxAttempts; i++)
                {
                    try
                    {
                        var response = await http.GetAsync("http://localhost:10833/api/values");
                        if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            return;
                        }
                    }
                    catch(Exception e)
                    {

                    }
                    finally
                    {
                        Console.WriteLine("Lost connection to server. Attempting to re-connect");
                        Thread.Sleep(attemptInterval);
                    }
                }
                throw new Exception("Failed to connect to server");
            }
        }

        private static void TestDecorators()
        {
            Card soldier = new Card("Soldier", 25, 20);
            soldier = new AttackDecorator(soldier, "Sword", 15);
            soldier = new AttackDecorator(soldier, "Amulet", 5);
            soldier = new DefenseDecorator(soldier, "Helmet", 10);
            soldier = new DefenseDecorator(soldier, "Heavy Armor", 45);
            Console.WriteLine($"Final Stats: {soldier.Attack} / {soldier.Defense}");
        }
    }
}
