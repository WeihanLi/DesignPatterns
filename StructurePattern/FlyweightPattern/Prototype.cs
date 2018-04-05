using System;
using System.Collections.Concurrent;

namespace FlyweightPattern
{
    internal abstract class Flyweight
    {
        public abstract void Operation(int extrinsicstate);
    }

    internal class ConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("operation in ConcreteFlyweight");
        }
    }

    internal class UnsharedFlyweight : Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("operation in UnsharedFlyweight");
        }
    }

    internal class FlyWeightFactory
    {
        private readonly ConcurrentDictionary<string, Flyweight> _flyweights = new ConcurrentDictionary<string, Flyweight>();

        public Flyweight GetFlyweight(string name) => _flyweights.GetOrAdd(name, n => new ConcreteFlyweight());
    }
}
