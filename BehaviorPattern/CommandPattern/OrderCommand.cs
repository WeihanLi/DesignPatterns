using System;

namespace CommandPattern
{
    public abstract class OrderCommand
    {
        protected Barbecuer Receiver;

        protected OrderCommand(Barbecuer receiver) => Receiver = receiver ?? throw new ArgumentNullException(nameof(receiver));

        public abstract void ExecuteCommand();
    }

    internal class BakeMuttonCommand : OrderCommand
    {
        public BakeMuttonCommand(Barbecuer receiver) : base(receiver)
        {
        }

        public override void ExecuteCommand()
        {
            Receiver.BakeMutton();
        }

        public override string ToString() => nameof(BakeMuttonCommand);
    }

    internal class BakeChickenWingCommand : OrderCommand
    {
        public BakeChickenWingCommand(Barbecuer receiver) : base(receiver)
        {
        }

        public override void ExecuteCommand()
        {
            Receiver.BakeChickenWing();
        }

        public override string ToString() => nameof(BakeChickenWingCommand);
    }
}
