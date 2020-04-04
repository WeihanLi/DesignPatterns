# 适配器模式 Adapter

## Intro

适配器模式，将一个类的接口适配成用户所期待的。一个适配允许通常因为接口不兼容而不能在一起工作的类工作在一起，做法是将类自己的接口包裹在一个已存在的类中。也被称为 Wrapper 模式。

通常这个类是外部的类，不能直接修改，所以需要做一层包装，以适配现有的接口。

## Prototype

``` csharp
public class Target
{
    public virtual void Request()
    {
        Console.WriteLine("This is a common request");
    }
}

public class Adaptee
{
    public void SpecialRequest()
    {
        Console.WriteLine("this is a special request");
    }
}

public class TargetAdapter : Target
{
    private readonly Adaptee _adaptee = new Adaptee();

    public override void Request()
    {
        _adaptee.SpecialRequest();
    }
}
```

## More

更多设计模式及示例代码 [传送门](https://github.com/WeihanLi/DesignPatterns)
