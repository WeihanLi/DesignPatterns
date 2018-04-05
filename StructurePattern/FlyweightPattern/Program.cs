using System;

namespace FlyweightPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var counter = 20;

            var factory = new FlyWeightFactory();
            factory.GetFlyweight("X").Operation(counter--);
            factory.GetFlyweight("Y").Operation(counter--);
            new UnsharedFlyweight().Operation(counter--);

            Console.WriteLine(counter);
            Console.ReadLine();
        }
    }
}
