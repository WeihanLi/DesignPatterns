using System;

namespace CommandPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Prototype

            var receiver = new Receiver();
            var command = new ConcreteCommand(receiver);
            var invoker = new Invoker();
            invoker.SetCommand(command);
            invoker.ExecuteCommand();

            #endregion Prototype

            var barbecuer = new Barbecuer();
            var waiter = new Waiter();

            waiter.SetOrder(new BakeChickenWingCommand(barbecuer));
            waiter.SetOrder(new BakeMuttonCommand(barbecuer));
            waiter.SetOrder(new BakeMuttonCommand(barbecuer));

            var willCancelOrder = new BakeMuttonCommand(barbecuer);
            waiter.SetOrder(willCancelOrder);
            waiter.CancelOrder(willCancelOrder);

            waiter.Notify();

            Console.ReadLine();
        }
    }
}
