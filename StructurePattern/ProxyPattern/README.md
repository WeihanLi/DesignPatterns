# 代理模式 Proxy

## Intro

代理模式，给某一个对象提供一个代理对象，并由代理对象控制对原对象的引用。

在某些情况下，一个对象不适合或者不能直接引用另一个对象，而代理对象可以在客户端和目标对象之间起到中介的作用。

比如生活中常见的中介，VPN，网络代理等

利用代理模式，我们可以对实际的操作做一些额外的逻辑，比如加一些异常捕捉，缓存，日志记录或者耗时统计等等，基于动态代理的 AOP 模式也是代理模式的实际应用。

## Prototype

``` csharp
public abstract class Subject
{
    public abstract void Request();
}

public class RealSubject : Subject
{
    public override void Request()
    {
        Console.WriteLine("request from real subject");
    }
}

public class Proxy0 : Subject
{
    private Subject _subject;

    public override void Request()
    {
        if (null == _subject)
        {
            _subject = new RealSubject();
        }
        _subject.Request();
    }
}

public class Proxy : Subject
{
    private readonly Subject _subject;

    public Proxy(Subject subject) => _subject = subject;

    public override void Request()
    {
        _subject.Request();
    }
}
```

## More

更多设计模式及示例代码 [传送门](https://github.com/WeihanLi/DesignPatterns)
