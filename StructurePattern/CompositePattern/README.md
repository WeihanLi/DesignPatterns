# 组合模式 Composite

## Intro

> 组合模式，将对象组合成树形结构以表示 “部分-整体” 的层次结构，组合模式使得用户对单个对象和组合对象的使用具有一致性。

## 使用场景

当你发现需求中是体现部分与整体层次的结构时，以及你希望用户可以忽略组合对象与单个对象的不同，统一地使用组合结构中的所有对象时，就应该考虑用组合模式了。

## Sample

``` csharp
public abstract class Component
{
    protected string Name;

    protected Component(string name)
    {
        Name = name;
    }

    public abstract void Add(Component c);

    public abstract void Remove(Component c);

    public abstract void Display(int depth);
}

public class Leaf : Component
{
    public Leaf(string name) : base(name)
    {
    }

    public override void Add(Component c)
    {
        throw new System.NotImplementedException();
    }

    public override void Remove(Component c)
    {
        throw new System.NotImplementedException();
    }

    public override void Display(int depth)
    {
        Console.WriteLine($"{new string('-', depth)} {Name}");
    }
}

public class Composite : Component
{
    private readonly List<Component> _children = new List<Component>();

    public Composite(string name) : base(name)
    {
    }

    public override void Add(Component c)
    {
        _children.Add(c);
    }

    public override void Remove(Component c)
    {
        _children.Remove(c);
    }

    public override void Display(int depth)
    {
        Console.WriteLine($"{new string('-', depth)} {Name}");
        foreach (var component in _children)
        {
            component.Display(depth + 2);
        }
    }
}


var root = new Composite("root");
root.Add(new Leaf("Leaf A"));
root.Add(new Leaf("Leaf B"));

var co = new Composite("CompositeA");
co.Add(new Leaf("Leaf X"));
co.Add(new Leaf("Leaf Y"));
var co1 = new Composite("CompositeA");
co1.Add(new Leaf("Leaf P"));
co1.Add(new Leaf("Leaf Q"));

co.Add(co1);
root.Add(co);
root.Display(0);
```

## More

更多设计模式及示例代码 [传送门](https://github.com/WeihanLi/DesignPatterns)
