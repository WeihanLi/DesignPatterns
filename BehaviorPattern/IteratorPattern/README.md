# 迭代器模式 Iterator

## Intro

迭代器模式，提供一种方法顺序访问一个聚合对象中的各个元素，而又不暴露该对象的内部表示。

迭代器模式是分离了集合对象的遍历行为，抽象出一个迭代器类来负责，这样既可以做到不暴露集合的内部结构，又可以让外部代码透明地访问集合内部的数据。

## 使用场景

当你需要访问一个聚集对象，而且不管这些对象是什么都需要遍历的时候，你就应该考虑用迭代器模式。

当你需要对聚集有多种方式遍历时，可以考虑用迭代器模式。

## 实现方式

在 C# 中实现 `IEnumerable` 接口就可以比较方便的实现一个迭代器

来看它的实现：

``` csharp
// 聚集抽象
public interface IEnumerable
{
    /// <summary>Returns an enumerator that iterates through a collection.</summary>
    /// <returns>An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.</returns>
    IEnumerator GetEnumerator();
}

// 迭代器抽象
public interface IEnumerator
{
    /// <summary>Advances the enumerator to the next element of the collection.</summary>
    /// <returns>
    /// <see langword="true" /> if the enumerator was successfully advanced to the next element; <see langword="false" /> if the enumerator has passed the end of the collection.</returns>
    /// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created.</exception>
    bool MoveNext();

    /// <summary>Gets the element in the collection at the current position of the enumerator.</summary>
    /// <returns>The element in the collection at the current position of the enumerator.</returns>
    object Current { get; }

    /// <summary>Sets the enumerator to its initial position, which is before the first element in the collection.</summary>
    /// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created.</exception>
    void Reset();
}
```

如果要自己实现需要有下面几个类：

一个迭代器抽象类（或接口）

一个聚集抽象类（或接口）

具体实现的迭代器类

具体实现的聚集类

## Sample

``` csharp
public abstract class Iterator
{
    public abstract object First();

    public abstract object Next();

    public abstract bool IsDone();

    public abstract object CurrentItem();
}

public class ConcreteIterator : Iterator
{
    private readonly ConcreteAggregate _aggregate;
    private int _current = 0;

    public ConcreteIterator(ConcreteAggregate aggregate) => _aggregate = aggregate;

    public override object First()
    {
        return _aggregate[0];
    }

    public override object Next()
    {
        _current++;
        return _current >= _aggregate.TotalCount ? null : _aggregate[_current];
    }

    public override bool IsDone() => _current >= _aggregate.TotalCount;

    public override object CurrentItem() => _aggregate[_current];
}

public abstract class Aggregate
{
    /// <summary>
    /// 创建迭代器
    /// </summary>
    /// <returns></returns>
    public abstract Iterator CreateIterator();
}

public class ConcreteAggregate : Aggregate
{
    private readonly IList<object> _items = new List<object>();

    public override Iterator CreateIterator()
    {
        return new ConcreteIterator(this);
    }

    public int TotalCount => _items.Count;

    public object this[int index]
    {
        get => _items[index];
        set => _items.Insert(index, value);
    }
}


var aggregate = new ConcreteAggregate
{
    [0] = "大鸟",
    [1] = "小菜",
    [2] = "行李",
    [3] = "老外",
    [4] = "公交员工",
    [5] = "小偷"
};

Iterator iterator = new ConcreteIterator(aggregate);
do
{
    Console.WriteLine($"{iterator.CurrentItem()} 请买车票");
    iterator.Next();
} while (!iterator.IsDone());

```

## More

更多设计模式及示例代码 [传送门](https://github.com/WeihanLi/DesignPatterns)
