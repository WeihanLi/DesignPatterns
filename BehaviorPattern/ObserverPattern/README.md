# 观察者模式 Observer

## Intro

> 观察者模式又叫做 发布订阅（Publish/Subscribe）模式
> 观察者模式定义了一种一对多的依赖关系，让多个观察者同时监听某一主题对象。
> 这个主题对象在状态发生变化时，会通知所有观察者对象，使得他们能够自动更新自己。

## 使用场景

观察者模式所做的工作其实就是在解耦，让耦合的双方都依赖于抽象而不是具体，从而使得各自的变化都不会影响另一边的变化。

当一个对象的改变需要改变其他对象的时候，而且它不知道具体有多少对象有待改变的时候，应该考虑使用观察者模式。

一个抽象模型有两方面，其中一方面依赖于另一方面，这时用观察者模式可以将这两者封装在独立的对象中使得他们各自独立地改变和复用。

## Sample


``` csharp
public interface ISubject
{
    void Notify();

    string SubjectState { get; set; }
}
public class Boss : ISubject
{
    private readonly IList<Observer> _observers = new List<Observer>();

    public void Attach(Observer observer)
    {
        _observers.Add(observer);
    }

    public void Detach(Observer observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update();
        }
    }

    public string SubjectState { get; set; }
}

public abstract class Observer
{
    protected string Name;
    protected ISubject Subject;

    protected Observer(string name, ISubject subject)
    {
        Name = name;
        Subject = subject;
    }

    public abstract void Update();
}
public class StockObserver : Observer
{
    public StockObserver(string name, ISubject subject) : base(name, subject)
    {
    }

    public override void Update()
    {
        Console.WriteLine($"{Name} {Subject.SubjectState} 关闭股票行情，继续工作");
    }
}
public class NBAObserver : Observer
{
    public NBAObserver(string name, ISubject subject) : base(name, subject)
    {
    }

    public override void Update()
    {
        Console.WriteLine($"{Name} {Subject.SubjectState} 关闭 NBA 直播，继续工作");
    }
}


var boss = new Boss();
var stockObserver = new StockObserver("魏关姹", boss);
var nbaObserver = new NBAObserver("易管查", boss);

boss.Attach(stockObserver);
boss.Attach(nbaObserver);

boss.Detach(stockObserver);

boss.SubjectState = "老板我胡汉三回来了";
boss.Notify();
```

借助 event（委托） 我们可以实现可以灵活的观察者模式，我们定义了一个新老板来演示事件的方式，来看下面的示例：

``` csharp
public class NewBoss : ISubject
{
    public event Action Update;

    public void Notify()
    {
        Update?.Invoke();
    }

    public string SubjectState { get; set; }
}

public class GamePlayerObserver
{
    private readonly string _name;
    private readonly ISubject _subject;

    public GamePlayerObserver(string name, ISubject subject)
    {
        _name = name;
        _subject = subject;
    }

    public void CloseGame()
    {
        Console.WriteLine($"{_name} {_subject.SubjectState} 关闭 LOL 游戏，继续工作");
    }
}

var newBoss = new NewBoss();
var stockObserver = new StockObserver("魏关姹", boss);
var nbaObserver = new NBAObserver("易管查", boss);
var gameObserver = new GamePlayerObserver("西门", newBoss);

// 注册通知事件
newBoss.Update += stockObserver.Update;
newBoss.Update += nbaObserver.Update;
newBoss.Update += gameObserver.CloseGame;

newBoss.Update -= stockObserver.Update;

newBoss.SubjectState = "老板我胡汉三回来了";
newBoss.Notify();
```

从上面这个示例可以看到，通过事件的方式，我们可以不要求显示继承于 `Observer` 这个抽象类，可以更加灵活，扩展性更强，这也是很多类库中会使用事件来扩展的重要原因

## More

更多设计模式及示例代码 [传送门](https://github.com/WeihanLi/DesignPatterns)
