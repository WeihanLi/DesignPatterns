# 单例模式 Singleton

## Intro

单例模式主要用来确保某个类型的实例只能有一个。

基本实现方式是将构造方法私有化，让实例的过程控制在类的内部去完成。

## 实现方式

1. 双重判空加锁（懒汉模式）

    ``` csharp
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
    ```

1. 静态初始化 （饿汉模式）

    ``` csharp
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
    ```

1. 并发集合（懒汉模式）

    ``` csharp
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
    ```