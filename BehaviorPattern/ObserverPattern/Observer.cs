namespace ObserverPattern;

internal abstract class Observer
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

internal class StockObserver : Observer
{
    public StockObserver(string name, ISubject subject) : base(name, subject)
    {
    }

    public override void Update()
    {
        Console.WriteLine($"{Name} {Subject.SubjectState} 关闭股票行情，继续工作");
    }
}

// ReSharper disable once InconsistentNaming
internal class NBAObserver : Observer
{
    public NBAObserver(string name, ISubject subject) : base(name, subject)
    {
    }

    public override void Update()
    {
        Console.WriteLine($"{Name} {Subject.SubjectState} 关闭 NBA 直播，继续工作");
    }
}

internal class GamePlayerObserver
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
