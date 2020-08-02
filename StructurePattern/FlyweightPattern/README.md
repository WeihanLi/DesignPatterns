# 享元模式 Flyweight

## Intro

享元是指一个可复用的对象，通过复用这个享元来减少应用中的内存分配。

享元模式是为了减少内存占用，尽可能复用已有对象的设计模式，一般来说会把这个可复用的对象放到一个外部的数据结构中，当需要使用到的时候传给享元。

## Sample

``` csharp
public abstract class Flyweight
{
    public abstract void Operation(int extrinsicstate);
}

public class ConcreteFlyweight : Flyweight
{
    public override void Operation(int extrinsicstate)
    {
        Console.WriteLine("operation in ConcreteFlyweight");
    }
}

public class UnsharedFlyweight : Flyweight
{
    public override void Operation(int extrinsicstate)
    {
        Console.WriteLine("operation in UnsharedFlyweight");
    }
}

public class FlyWeightFactory
{
    private readonly ConcurrentDictionary<string, Flyweight> _flyweights = new ConcurrentDictionary<string, Flyweight>();

    public Flyweight GetFlyweight(string name) => _flyweights.GetOrAdd(name, n => new ConcreteFlyweight());
}

public class Program
{
    public static void Main(string[] args)
    {
        var counter = 20;

        var factory = new FlyWeightFactory();
        factory.GetFlyweight("X").Operation(counter--);
        factory.GetFlyweight("Y").Operation(counter--);
        factory.GetFlyweight("X").Operation(counter--);

        new UnsharedFlyweight().Operation(counter--);

        factory.GetFlyweight("X").Operation(counter--);

        Console.WriteLine(counter);
        Console.ReadLine();
    }
}
```

## More

更多设计模式及示例代码 [传送门](https://github.com/WeihanLi/DesignPatterns)
