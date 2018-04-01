using System.Collections.Concurrent;

namespace SingletonPattern
{
    /// <summary>
    /// Custom Singleton
    /// 自定义实现的单例方法，大话设计模式中没有
    /// </summary>
    public class Singleton2
    {
        private static readonly ConcurrentDictionary<int, Singleton2> Instances = new ConcurrentDictionary<int, Singleton2>();

        private Singleton2()
        {
        }

        public static Singleton2 GetInstance() => Instances.GetOrAdd(1, k => new Singleton2());
    }
}
