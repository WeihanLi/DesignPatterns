using System.Collections.Concurrent;

namespace SingletonPattern
{
    /// <summary>
    /// 使用 ConcurrentDictionary 实现的单例方法，用到的时候再去实例化
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
