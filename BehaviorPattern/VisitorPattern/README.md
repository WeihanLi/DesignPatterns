# 访问者模式 Visitor

## Intro

> 访问者模式（Visitor），表示一个作用于某对象结构中的各元素的操作，它使你可以在不改变各元素的类的前提下定义作用于这些元素的新操作。

## 使用场景

访问者模式适用于数据结构相对稳定的系统，它把数据结构和作用域结构上的操作之间的耦合解脱开，使用操作集合可以相对自由地演化。

访问者模式的目的是要把处理从数据结构分离出来，有比较稳定的数据结构，又有易于变化的算法时，使用访问者模式就是比较适合的，
因为访问者模式使得算法操作的增加变得容易。反之，如果数据结构对象易于变化，经常有新的数据对象增加进来，就不适合使用访问者模式。

## 优缺点

优点：

- 增加新的操作很容易，增加新的操作就意味着增加一个新的访问者，访问者模式将有关的行为集中到一个访问者对象中。

缺点：

- 增加新的数据结构困难，破坏 开放封闭 原则


## Sample

``` csharp
public abstract class Person
{
    public abstract void Accept(AbstractAction visitor);
}

public class Man : Person
{
    public override void Accept(AbstractAction visitor)
    {
        visitor.GetManConclusion(this);
    }
}

public class Woman : Person
{
    public override void Accept(AbstractAction visitor)
    {
        visitor.GetWomanConclusion(this);
    }
}

public abstract class AbstractAction
{
    public abstract void GetManConclusion(Man man);

    public abstract void GetWomanConclusion(Woman woman);
}

public class Success : AbstractAction
{
    public override void GetManConclusion(Man man)
    {
        Console.WriteLine($"{man.GetType().Name} {GetType().Name} 时,背后多半有一个伟大的女人");
    }

    public override void GetWomanConclusion(Woman woman)
    {
        Console.WriteLine($"{woman.GetType().Name} {GetType().Name} 时,背后多有一个不成功的男人");
    }
}
public class Fail : AbstractAction
{
    public override void GetManConclusion(Man man)
    {
        Console.WriteLine($"{man.GetType().Name} {GetType().Name} 时,背后多半有一个伟大的女人");
    }

    public override void GetWomanConclusion(Woman woman)
    {
        Console.WriteLine($"{woman.GetType().Name} {GetType().Name} 时,背后多有一个不成功的男人");
    }
}
public class Marriage : AbstractAction
{
    public override void GetManConclusion(Man man)
    {
        Console.WriteLine($"{man.GetType().Name} {GetType().Name} 时,感慨道:恋爱游戏终结时,'有妻徒刑'遥无期");
    }

    public override void GetWomanConclusion(Woman woman)
    {
        Console.WriteLine($"{woman.GetType().Name} {GetType().Name} 时,欣慰曰:爱情长路跑漫漫,婚姻保险保平安.");
    }
}

public class PersonStructure
{
    private readonly IList<Person> _persons = new List<Person>();

    public void Attach(Person person)
    {
        _persons.Add(person);
    }

    public void Detach(Person person)
    {
        _persons.Remove(person);
    }

    public void Display(AbstractAction visitor)
    {
        foreach (var person in _persons)
        {
            person.Accept(visitor);
        }
    }
}


var personStructure = new PersonStructure();
personStructure.Attach(new Man());
personStructure.Attach(new Woman());

personStructure.Display(new Success());
personStructure.Display(new Fail());
personStructure.Display(new Marriage());
```

## More

更多设计模式及示例代码 [传送门](https://github.com/WeihanLi/DesignPatterns)
