using System;

namespace BridgePattern
{
    internal abstract class Implementor
    {
        public abstract void Operation();
    }

    internal class ConcreteImplementorA : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ImplementorA Opearation");
        }
    }

    internal class ConcreteImplementorB : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ImplementorB Opearation");
        }
    }

    internal abstract class Abstraction
    {
        protected Implementor Implementor;

        public void SetImplementor(Implementor implementor)
        {
            Implementor = implementor;
        }

        public abstract void Operation();
    }

    internal class RefindAbstraction : Abstraction
    {
        public override void Operation()
        {
            Implementor.Operation();
            Console.WriteLine("Invoke in RefindAbstraction");
        }
    }
}
