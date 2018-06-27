using IntSegregationExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntSegregationExample
{
    public class Eagle : IWalkable, IFlyable, IEat
    {
        private int _maxAlt = 2000;

        public void Eat(string food)
        {
            Console.WriteLine($"Mighty eagle is eating {food}");
        }

        public void Fly(int distance, int altitude)
        {
            if (altitude < _maxAlt)
            {
                Console.WriteLine($"The eagle spreads its wings and flies up to {altitude} feet for {distance} miles");
            }
            else
            {
                Console.WriteLine("Even eagles can't fly that high");
            }
        }

        public void Walk(int distance)
        {
            Console.WriteLine($"Eagle is walking for {distance} miles");
        }
    }
}
