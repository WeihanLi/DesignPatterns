using System;
using System.Linq;
using System.Threading.Tasks;
using WeihanLi.Extensions;

namespace SingletonPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // //0
            // var i0 = Singleton.GetInstance();
            // Console.WriteLine($"Singleton {ReferenceEquals(i0, Singleton.GetInstance())}");
            // //1
            // var i1 = Singleton1.GetInstance();
            // Console.WriteLine($"Singleton1 {ReferenceEquals(i1, Singleton1.GetInstance())}");
            // //2
            // var i2 = Singleton2.GetInstance();
            // Console.WriteLine($"Singleton2 {ReferenceEquals(i2, Singleton2.GetInstance())}");


            Console.WriteLine($"Singleton");
            Enumerable.Range(1, 10).Select(i=> Task.Run(()=>{
                Console.WriteLine($"{Singleton.GetInstance().GetHashCode()}");
            })).WhenAll().Wait();


            Console.WriteLine($"Singleton1");
            Enumerable.Range(1, 10).Select(i=> Task.Run(()=>{
                Console.WriteLine($"{Singleton1.GetInstance().GetHashCode()}");
            })).WhenAll().Wait();


            Console.WriteLine($"Singleton2");
            Enumerable.Range(1, 10).Select(i=> Task.Run(()=>{
                Console.WriteLine($"{Singleton2.GetInstance().GetHashCode()}");
            })).WhenAll().Wait();

            Console.ReadLine();
        }
    }
}
