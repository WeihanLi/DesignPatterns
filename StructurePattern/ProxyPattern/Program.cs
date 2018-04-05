using System;

namespace ProxyPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Subject proxy = new Proxy(new RealSubject());
            proxy.Request();

            proxy = new Proxy0();
            proxy.Request();

            Console.ReadLine();
        }
    }
}
