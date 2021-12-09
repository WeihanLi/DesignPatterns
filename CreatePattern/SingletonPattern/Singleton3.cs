namespace SingletonPattern;

/// <summary>
/// 使用 Lazy 实现的单例方法，用到的时候再去实例化
/// </summary>
public class Singleton3
{
    private static readonly Lazy<Singleton3>
        LazyInstance = new(() => new Singleton3());

    private Singleton3()
    {
    }

    public static Singleton3 GetInstance() => LazyInstance.Value;
}
