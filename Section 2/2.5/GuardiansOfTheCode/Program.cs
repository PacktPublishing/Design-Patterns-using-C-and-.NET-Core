using System;

namespace GuardiansOfTheCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrimaryPlayer player = PrimaryPlayer.Instance;
            //Console.WriteLine($"{player.Name} - lvl {player.Level}");

            Gameboard board = new Gameboard();
            board.PlayArea(1);

            Console.ReadKey();
        }
    }
}
