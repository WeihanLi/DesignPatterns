using System;

namespace FacadePattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var facade = new Facade();
            facade.MethodA();
            facade.MethodB();

            Console.ReadLine();
        }
    }
}
