using System;

namespace BuilderPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var director = new Director();
            Builder builder1 = new ConcreteBuilder1(), builder2 = new ConcreteBuilder2();
            director.Construct(builder1);
            director.Construct(builder2);

            builder1.GetResult().Show();
            builder2.GetResult().Show();

            Console.ReadLine();
        }
    }
}
