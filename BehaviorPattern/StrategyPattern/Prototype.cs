using System;

namespace StrategyPattern
{
    internal class Context
    {
        private readonly Strategy _strategy;

        public Context(Strategy strategy) => _strategy = strategy;

        public void Implement()
        {
            _strategy.AlgorithmImplement();
        }
    }

    internal abstract class Strategy
    {
        public abstract void AlgorithmImplement();
    }

    internal class ConcreteStrategyA : Strategy
    {
        public override void AlgorithmImplement()
        {
            Console.WriteLine("算法A实现");
        }
    }

    internal class ConcreteStrategyB : Strategy
    {
        public override void AlgorithmImplement()
        {
            Console.WriteLine("算法B实现");
        }
    }

    internal class ConcreteStrategyC : Strategy
    {
        public override void AlgorithmImplement()
        {
            Console.WriteLine("算法C实现");
        }
    }
}
