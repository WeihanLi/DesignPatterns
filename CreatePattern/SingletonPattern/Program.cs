using System;

namespace SingletonPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //0
            var i0 = Singleton.GetInstance();
            Console.WriteLine($"Singleton {ReferenceEquals(i0, Singleton.GetInstance())}");
            //1
            var i1 = Singleton1.GetInstance();
            Console.WriteLine($"Singleton1 {ReferenceEquals(i1, Singleton1.GetInstance())}");
            //2
            var i2 = Singleton2.GetInstance();
            Console.WriteLine($"Singleton2 {ReferenceEquals(i2, Singleton2.GetInstance())}");

            Console.ReadLine();
        }
    }
}
