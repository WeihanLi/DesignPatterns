namespace MediatorPattern
{
    internal abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleague);
    }

    internal class ConcreteMediator : Mediator
    {
        public Colleague Colleague1 { private get; set; }
        public Colleague Colleague2 { private get; set; }

        public override void Send(string message, Colleague colleague)
        {
            if (colleague == Colleague1)
            {
                Colleague2.Notify(message);
            }
            else
            {
                Colleague1.Notify(message);
            }
        }
    }
}
