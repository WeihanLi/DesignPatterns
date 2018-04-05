using System;

namespace DecoratorPattern
{
    internal abstract class Component
    {
        public abstract void Operation();
    }

    internal class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("Operation executed in ConcreteComponent");
        }
    }

    internal abstract class Decorator : Component
    {
        protected Component Component;

        public void SetComponent(Component component)
        {
            Component = component;
        }

        public override void Operation()
        {
            Component?.Operation();
        }
    }

    internal class DecoratorA : Decorator
    {
        private string _state;

        public override void Operation()
        {
            base.Operation();
            _state = "executed";
            Console.WriteLine($"operation in DecoratorA, state:{_state}");
        }
    }

    internal class DecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("opertaion in DecoratorB");
            AddBehavior();
        }

        private void AddBehavior()
        {
            Console.WriteLine("another behavior");
        }
    }
}
