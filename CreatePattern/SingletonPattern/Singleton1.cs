namespace SingletonPattern
{
    /// <summary>
    /// 饿汉模式-就是屌丝，担心饿死。类加载就给准备好
    /// </summary>
    public sealed class Singleton1
    {
        /// <summary>
        /// 静态初始化，由 CLR 去创建
        /// </summary>
        private static readonly Singleton1 Instance = new Singleton1();

        private Singleton1()
        {
        }

        public static Singleton1 GetInstance() => Instance;
    }
}
