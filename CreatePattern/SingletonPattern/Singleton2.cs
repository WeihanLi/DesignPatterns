using System.Collections.Concurrent;

namespace SingletonPattern
{
    /// <summary>
    /// 使用 ConcurrentDictionary 实现的单例方法，用到的时候再去实例化
    /// 这种方式类似于双重锁定方式，只是使用了并发集合代替了双重判断和 lock
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
