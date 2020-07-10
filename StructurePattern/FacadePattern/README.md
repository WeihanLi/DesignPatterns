# 外观模式(门面模式) Facade

## Intro

> 外观模式（Facade），为子系统中的一组接口提供一个一致的界面，此模式定义了一个高层接口，这个接口使得这一子系统更加容易使用

## Prototype

- Facade: 外观类，知道哪些子系统类负责处理请求，将请求代理给对应的子系统对象
- SubSystem Classes，实现子系统中的功能，处理 Facade 指派的任务，和 Facade 没有关联关系，没有继承，也不会引用 Facade

``` csharp
public class SubSystem1
{
    public void MethodA()
    {
        Console.WriteLine("MethodA in SubSystem1");
    }

    public void MethodB()
    {
        Console.WriteLine("MethodB in SubSystem1");
    }
}
public class SubSystem2
{
    public void MethodA()
    {
        Console.WriteLine("MethodA in SubSystem2");
    }

    public void MethodB()
    {
        Console.WriteLine("MethodB in SubSystem2");
    }
}
public class SubSystem3
{
    public void MethodA()
    {
        Console.WriteLine("MethodA in SubSystem3");
    }

    public void MethodB()
    {
        Console.WriteLine("MethodB in SubSystem3");
    }
}

public class Facade
{
    private readonly SubSystem1 _subSystem1 = new SubSystem1();
    private readonly SubSystem2 _subSystem2 = new SubSystem2();
    private readonly SubSystem3 _subSystem3 = new SubSystem3();

    public void MethodA()
    {
        _subSystem1.MethodA();
        _subSystem2.MethodA();
        _subSystem3.MethodA();
        Console.WriteLine();
    }

    public void MethodB()
    {
        _subSystem1.MethodB();
        _subSystem2.MethodB();
        _subSystem3.MethodB();
        Console.WriteLine();
    }
}

var facade = new Facade();
facade.MethodA();
facade.MethodB();
```

## More

更多设计模式及示例代码 [传送门](https://github.com/WeihanLi/DesignPatterns)
