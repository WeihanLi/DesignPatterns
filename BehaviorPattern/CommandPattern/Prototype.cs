using System;

namespace CommandPattern
{
    internal class Receiver
    {
        public void Action()
        {
            Console.WriteLine("Action in receiver");
        }
    }

    internal abstract class Command
    {
        protected readonly Receiver Receiver;

        protected Command(Receiver receiver) =>
            Receiver = receiver ?? throw new ArgumentNullException(nameof(receiver));

        public abstract void Execute();
    }

    internal class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver) : base(receiver)
        {
        }

        public override void Execute()
        {
            Receiver.Action();
        }
    }

    internal class Invoker
    {
        private Command _command;

        public void SetCommand(Command command)
        {
            _command = command;
        }

        public void ExecuteCommand()
        {
            _command.Execute();
        }
    }
}
