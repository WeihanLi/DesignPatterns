# 命令模式 Command

## Intro

命令模式，将一个请求封装为一个对象，从而使得可以用不同的请求进行参数化，对请求排队或者记录请求日志以及支持可撤销的操作。

命令模式是对命令进行封装，由调用者发起命令请求，接收者执行请求。

当我们调用时，执行的时序首先是调用者类，然后是命令类，最后是接收者类。
也就是说一条命令的执行被分成了三步，它的耦合度要比把所有的操作都封装到一个类中要低的多，
而这也正是命令模式的精髓所在：把命令的调用者与执行者分开，使双方不必关心对方是如何操作的。

基本结构：

- Command：命令的抽象，类中对需要执行的命令进行声明，一般来说要对外暴露一个 Execute 方法用来执行命令
- ConcreteCommand：Command 的实现类
- Invoker：调用者，负责调用命令
- Receiver：接收者，负责接收命令并且执行命令

## Sample

``` csharp
public class Receiver
{
    public void Action()
    {
        Console.WriteLine("Action in receiver");
    }
}

public abstract class Command
{
    protected readonly Receiver Receiver;

    protected Command(Receiver receiver) =>
        Receiver = receiver ?? throw new ArgumentNullException(nameof(receiver));

    public abstract void Execute();
}
public class ConcreteCommand : Command
{
    public ConcreteCommand(Receiver receiver) : base(receiver)
    {
    }

    public override void Execute()
    {
        Receiver.Action();
    }
}

public class Invoker
{
    private Command _command;

    public void SetCommand(Command command)
    {
        _command = command;
    }

    public void ExecuteCommand()
    {
        _command.Execute();
    }
}


var receiver = new Receiver();
var command = new ConcreteCommand(receiver);
var invoker = new Invoker();
invoker.SetCommand(command);
invoker.ExecuteCommand();

// another sample
var barbecuer = new Barbecuer();
var waiter = new Waiter();

waiter.SetOrder(new BakeChickenWingCommand(barbecuer));
waiter.SetOrder(new BakeMuttonCommand(barbecuer));
waiter.SetOrder(new BakeMuttonCommand(barbecuer));

var willCancelOrder = new BakeMuttonCommand(barbecuer);
waiter.SetOrder(willCancelOrder);
waiter.CancelOrder(willCancelOrder);

waiter.Notify();
```

## More

更多设计模式及示例代码 [传送门](https://github.com/WeihanLi/DesignPatterns)
