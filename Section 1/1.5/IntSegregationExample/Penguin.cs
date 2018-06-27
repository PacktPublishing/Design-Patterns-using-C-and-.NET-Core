using System;
using System.Collections.Generic;
using System.Text;
using IntSegregationExample.Interfaces;

namespace IntSegregationExample
{
    public class Penguin : IEat, IWalkable
    {
        public void Eat(string food)
        {
            Console.WriteLine($"Penguin is eating {food}");
        }

        public void Walk(int distance)
        {
            Console.WriteLine($"Penguin walking in a funny way for {distance} miles");
        }
    }
}
