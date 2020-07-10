# 装饰模式 Decorator

## Intro

> 装饰模式，动态地给一个对象添加一些额外的职责，就增加功能来说，装饰模式比生成子类更为灵活

## 使用场景

装饰模式是为已有功能动态地添加更多功能的一种方式

当系统需要新功能的时候，是向旧的类中添加新的代码，这些新加的代码通常装饰了原有类的核心职责或主要行为，但是往往会在主类中加入新的字段/方法/逻辑，从而增加了主类的复杂度，
而这些新加入的东西仅仅是为了满足一些只在某种特定情况下才会执行的特殊行为的需要

装饰模式提供了一个很好的方案，它把每个要装饰的功能放在单独的类中，并让这个类包装它要装饰的对象，
当需要执行特殊行为时，就可以在运行时根据需要有选择地、按顺序地使用装饰功能包装对象了。

装饰模式的优点时把类中的装饰功能从类中搬移去除，这样可以简化原有的类，这样做就有效地把类的核心职责和装饰功能区分开了，而且可以去除相关类中重复的装饰逻辑。

## Prototype

- Component 定义一个对象的抽象，可以给这些对象动态的添加职责
- ConcreteComponent 定义一个具体的对象，也可以给这个对象添加一些职责
- Decorator 装饰抽象类，继承了 Component，从外类来扩展 Component 类的功能，但对于 Component 来说是无需知道 Decorator 的存在的
- ConcreteDecorator 具体的装饰对象，起到给 Component 添加职责的功能

``` csharp
internal abstract class Component
{
    public abstract void Operation();
}
internal class ConcreteComponent : Component
{
    public override void Operation()
    {
        Console.WriteLine("Operation executed in ConcreteComponent");
    }
}

internal abstract class Decorator : Component
{
    protected Component Component;

    public void SetComponent(Component component)
    {
        Component = component;
    }

    public override void Operation()
    {
        Component?.Operation();
    }
}
internal class DecoratorA : Decorator
{
    private string _state;

    public override void Operation()
    {
        base.Operation();
        _state = "executed";
        Console.WriteLine($"operation in DecoratorA, state:{_state}");
    }
}
internal class DecoratorB : Decorator
{
    public override void Operation()
    {
        base.Operation();
        Console.WriteLine("operation in DecoratorB");
        AddBehavior();
    }

    private void AddBehavior()
    {
        Console.WriteLine("another behavior");
    }
}
```

## More

更多设计模式及示例代码 [传送门](https://github.com/WeihanLi/DesignPatterns)
