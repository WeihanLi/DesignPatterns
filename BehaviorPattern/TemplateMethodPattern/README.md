# 模板方法模式 Template Method

## Intro

> 模板方法模式，定义一个操作中的算法骨架，而将一些步骤延迟到子类中。模板方法使得子类可以不改变一个算的结构即使重定义该算法的某些特定步骤


这里的“算法”，我们可以理解为广义上的“业务逻辑”，并不特指数据结构和算法中的“算法”。这里的算法骨架就是“模板”，包含算法骨架的方法就是“模板方法”，这也是模板方法模式名字的由来。

我一直觉得模板方法这个设计模式是最简单最实用最能体验面向对象特性的一个设计模式

面向对象的三大特性，封装、继承、多态在模板方法模式中都有体现

一些通用的逻辑通常会 **封装** 在父类中，不同的部分通常在父类中定义一个抽象方法或者虚方法（具体根据实际场景选择），然后在子类中 **继承** 父类以复用父类中的通用逻辑，在具体的子类中实现需要重写的逻辑，以此来实现 **多态**

## 使用场景

模板方法模式是通过把不变行为搬移到基类中，去除子类中的重复代码来体现它的优势，提供了一个很好的代码复用平台。

当不变的和可变的行为在方法的子类实现中混合在一起的时候，不变的行为就会在子类中重复出现，我们通过可以借助模板方法模式把这些行为搬移到单一的地方，这样就帮助子类摆脱重复的不变行为的纠缠。

## Sample

来看一个简单的示例：

``` csharp
internal abstract class AbstractClass
{
    protected abstract void PrimitiveOperation1();

    protected abstract void PrimitiveOperation2();

    public void TemplateMethod()
    {
        Console.WriteLine("-------Begin-------");
        PrimitiveOperation1();
        PrimitiveOperation2();
        Console.WriteLine("-------End-------");
    }
}

internal class ConcreteClassA : AbstractClass
{
    protected override void PrimitiveOperation1()
    {
        Console.WriteLine("具体类A 方法1 的实现");
    }

    protected override void PrimitiveOperation2()
    {
        Console.WriteLine("具体类A 方法2 的实现");
    }
}

internal class ConcreteClassB : AbstractClass
{
    protected override void PrimitiveOperation1()
    {
        Console.WriteLine("具体类B 方法1 的实现");
    }

    protected override void PrimitiveOperation2()
    {
        Console.WriteLine("具体类B 方法2 的实现");
    }
}
```

## More

更多设计模式及示例代码 [传送门](https://github.com/WeihanLi/DesignPatterns)
