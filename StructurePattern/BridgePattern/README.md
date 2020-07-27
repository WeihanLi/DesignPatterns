# 桥接模式 Bridge

## Intro

> 桥接模式，将抽象部分与它的实现部分分离，使得它们都可以独立地变化。
>
> 这里说到抽象与它的实现分离指的是抽象类和它的派生类用来实现自己的对象


还有另外一种理解方式，一个类存在两个（或多个）独立变化的维度，我们通过组合的方式，让这两个（或多个）维度可以独立进行扩展。

通过组合关系来替代继承关系，避免继承层次的指数级爆炸。这种理解方式非常类似于，我们之前讲过的“组合优于继承”设计原则。

## Sample

``` csharp
internal abstract class Implementor
{
    public abstract void Operation();
}

internal class ConcreteImplementorA : Implementor
{
    public override void Operation()
    {
        Console.WriteLine("ImplementorA Operation");
    }
}

internal class ConcreteImplementorB : Implementor
{
    public override void Operation()
    {
        Console.WriteLine("ImplementorB Operation");
    }
}

internal abstract class Abstraction
{
    protected Implementor Implementor;

    public void SetImplementor(Implementor implementor)
    {
        Implementor = implementor;
    }

    public abstract void Operation();
}

internal class RefinedAbstraction : Abstraction
{
    public override void Operation()
    {
        Implementor.Operation();
        Console.WriteLine("Invoke in RefinedAbstraction");
    }
}


Abstraction ab = new RefinedAbstraction();

ab.SetImplementor(new ConcreteImplementorA());
ab.Operation();

ab.SetImplementor(new ConcreteImplementorB());
ab.Operation();
```

## More

更多设计模式及示例代码 [传送门](https://github.com/WeihanLi/DesignPatterns)
