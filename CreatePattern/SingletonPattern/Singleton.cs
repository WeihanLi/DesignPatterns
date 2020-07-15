namespace SingletonPattern
{
    /// <summary>
    /// 双重判空加锁，饱汉模式（懒汉式），用到的时候再去实例化
    /// </summary>
    public class Singleton
    {
        private static Singleton _instance;
        private static readonly object SyncLock = new object();

        private Singleton()
        {
        }

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                lock (SyncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }

            return _instance;
        }
    }
}
