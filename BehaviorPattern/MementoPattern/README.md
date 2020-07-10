# 备忘录模式 Memento

## Intro

> 备忘录模式，在不破坏封装性的前提下，捕获一个对象的内部状态，并在该对象之外保存这个状态。这样以后就可将该对象恢复到原先保存的状态。

## 使用场景

备忘录（Memento）模式比较适用于功能比较复杂的，但需要维护或记录属性历史的类，或者需要保存的属性只是众多属性中的一小部分时，

`Originator` 可以根据保存的 `Memento` 信息还原到前一状态。

可以用来做数据(状态)备份和恢复。

## Prototype

- Originator 拥有状态的宿主，需要提供一个入口来获取和更新当前状态
- State/Memento 需要备份状态信息
- Caretaker 状态备忘录，备份状态信息

## Sample

``` csharp
internal class Originator
{
    public string State { get; set; }

    public Memento CreateMemento()
    {
        return new Memento(State);
    }

    public void SetMemento(Memento memento)
    {
        State = memento?.State;
    }

    public void Show()
    {
        Console.WriteLine($"State:{State}");
    }
}

internal class Memento
{
    public string State { get; }

    public Memento(string state) => State = state;
}

internal class Caretaker
{
    public Memento Memento { get; set; }
}

var originator = new Originator
{
    State = "On"
};
originator.Show();

var caretaker = new Caretaker
{
    Memento = originator.CreateMemento()
};

originator.State = "Off";
originator.Show();

originator.SetMemento(caretaker.Memento);
originator.Show();
```

## More

更多设计模式及示例代码 [传送门](https://github.com/WeihanLi/DesignPatterns)
