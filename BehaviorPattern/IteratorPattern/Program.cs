using System;

namespace IteratorPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var aggregate = new ConcreteAggregate
            {
                [0] = "大鸟",
                [1] = "小菜",
                [2] = "行李",
                [3] = "老外",
                [4] = "公交员工",
                [5] = "小偷"
            };

            Console.WriteLine("ConcreteIterator:");
            Iterator iterator = new ConcreteIterator(aggregate);
            do
            {
                Console.WriteLine($"{iterator.CurrentItem()} 请买车票");
                iterator.Next();
            } while (!iterator.IsDone());

            Console.WriteLine("ConcreteIteratorDesc:");
            Iterator iteratorDesc = new ConcreteIteratorDesc(aggregate);
            do
            {
                Console.WriteLine($"{iteratorDesc.CurrentItem()} 请买车票");
                iteratorDesc.Next();
            } while (!iteratorDesc.IsDone());

            Console.ReadLine();
        }
    }
}
