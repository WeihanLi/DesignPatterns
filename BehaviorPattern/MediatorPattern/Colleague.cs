using System;

namespace MediatorPattern
{
    internal abstract class Colleague
    {
        protected Mediator Mediator;

        protected Colleague(Mediator mediator) => Mediator = mediator;

        public abstract void Notify(string message);
    }

    internal class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(Mediator mediator) : base(mediator)
        {
        }

        public void Send(string message)
        {
            Mediator.Send(message, this);
        }

        public override void Notify(string message)
        {
            Console.WriteLine($"同事1 得到信息：{message}");
        }
    }

    internal class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Mediator mediator) : base(mediator)
        {
        }

        public void Send(string message)
        {
            Mediator.Send(message, this);
        }

        public override void Notify(string message)
        {
            Console.WriteLine($"同事2 得到信息：{message}");
        }
    }
}
