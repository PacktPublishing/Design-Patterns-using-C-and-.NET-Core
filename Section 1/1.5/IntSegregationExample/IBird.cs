using System;
using System.Collections.Generic;
using System.Text;

namespace IntSegregationExample
{
    public interface IBird
    {
        void Eat(string food);
        void Walk(int distance);
        void Fly(int distance, int altitude);
    }
}
