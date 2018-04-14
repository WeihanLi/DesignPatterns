using System;

namespace MediatorPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var mediator = new ConcreteMediator();

            var c1 = new ConcreteColleague1(mediator);
            var c2 = new ConcreteColleague2(mediator);
            mediator.Colleague1 = c1;
            mediator.Colleague2 = c2;

            c1.Send("吃饭了吗？");
            c2.Send("没有呢，你打算请客？");

            Console.ReadLine();
        }
    }
}
