# 中介者模式 Mediator

## Intro

> 中介者模式，用一个中介对象来封装一系列的对象交互。
> 中介者使得各对象不需要显式地相互引用，从而使其耦合松散，而且可以独立地改变他们之间的交互。

## 使用场景

中介者模式一般应用于一组对象以定义良好但是复杂的方式进行通信的场合，以及想定制一个分布在多个类种的行为而又不想生成太多子类的场合。

## 优缺点

> 中介者模式很容易在系统中应用，也很容易在系统中误用。当系统出现了“多对多”交互复杂的对象群时，不要急于使用中介者模式，而要先反思你的系统在设计上是不是合理。

- 优点

  > 中介者（`Mediator`）的出现减少了各个 `Colleague` 的耦合，使得可以独立地改变和复用各个 `Colleague` 类和 `Mediator`；其次，由于把对象如何协作进行了抽象，将中介作为一个独立的概念并将其封装在一个对象中，这样关注的对象就从对象各自本身的行为转移到它们之间的交互上来，也就是站在一个更宏观的角度去看待系统

- 缺点

  > 由于 `ConcreteMediator` 控制了集中化，于是就把交互复杂性变为了中介者的复杂性，这就使得中介者会变得比任何一个 `ConcreteColleague` 都复杂


## Sample

``` csharp
public abstract class Mediator
{
    public abstract void Send(string message, Colleague colleague);
}

public class ConcreteMediator : Mediator
{
    public Colleague Colleague1 { private get; set; }
    public Colleague Colleague2 { private get; set; }

    public override void Send(string message, Colleague colleague)
    {
        if (colleague == Colleague1)
        {
            Colleague2.Notify(message);
        }
        else
        {
            Colleague1.Notify(message);
        }
    }
}

public abstract class Colleague
{
    protected Mediator Mediator;

    protected Colleague(Mediator mediator) => Mediator = mediator;

    public abstract void Notify(string message);
}
public class ConcreteColleague1 : Colleague
{
    public ConcreteColleague1(Mediator mediator) : base(mediator)
    {
    }

    public void Send(string message)
    {
        Mediator.Send(message, this);
    }

    public override void Notify(string message)
    {
        Console.WriteLine($"同事1 得到信息：{message}");
    }
}
public class ConcreteColleague2 : Colleague
{
    public ConcreteColleague2(Mediator mediator) : base(mediator)
    {
    }

    public void Send(string message)
    {
        Mediator.Send(message, this);
    }

    public override void Notify(string message)
    {
        Console.WriteLine($"同事2 得到信息：{message}");
    }
}


var mediator = new ConcreteMediator();

var c1 = new ConcreteColleague1(mediator);
var c2 = new ConcreteColleague2(mediator);
mediator.Colleague1 = c1;
mediator.Colleague2 = c2;

c1.Send("吃饭了吗？");
c2.Send("没有呢，你打算请客？");
```

## More

更多设计模式及示例代码 [传送门](https://github.com/WeihanLi/DesignPatterns)
