# 状态模式 State

## Intro

> 状态模式（State），当一个对象的内在状态改变时允许改变其行为，这个对象看起来像是改变了其类。

## 使用场景

当一个对象的行为取决于它的状态，并且它必须在运行时根据状态改变它的行为时就可以考虑状态模式。

状态模式主要解决的是当控制一个对象状态转换的条件表达式过于复杂时的情况。把状态的判断逻辑转移到表示不同状态的一系列类当中，可以把复杂的判断逻辑简化。

状态模式的好处是将与特定状态相关的行为局部化，并且将不同状态的行为分隔开来。将特定的状态相关的行为都放入一个对象中，由于所有与状态相关的代码都存在于某个 `State` 中，所以通过定义新的子类可以很容易地增加新地状态和转换。

状态模式通过把各种状态转义逻辑分布到 `State` 的子类之间，来减少相互之间地依赖。

## Sample

``` csharp
class Work
{
    private WorkState _currentState;

    public Work()
    {
        _currentState = new ForenoonState();
    }

    public int Hour { get; set; }

    public bool TaskFinished { get; set; }

    public void SetState(WorkState workState)
    {
        _currentState = workState;
    }

    public void WriteProgram()
    {
        _currentState.WriteProgram(this);
    }
}


internal abstract class WorkState
{
    public abstract void WriteProgram(Work work);
}

internal class ForenoonState : WorkState
{
    public override void WriteProgram(Work work)
    {
        if (work.Hour < 12)
        {
            Console.WriteLine($"当前时间：{work.Hour}点 上午工作，精神百倍");
        }
        else
        {
            work.SetState(new NoonState());
            work.WriteProgram();
        }
    }
}

internal class NoonState : WorkState
{
    public override void WriteProgram(Work work)
    {
        if (work.Hour < 13)
        {
            Console.WriteLine($"当前时间：{work.Hour}点 饿了，午饭。犯困，午休");
        }
        else
        {
            work.SetState(new AfternoonState());
            work.WriteProgram();
        }
    }
}

internal class AfternoonState : WorkState
{
    public override void WriteProgram(Work work)
    {
        if (work.Hour < 18)
        {
            Console.WriteLine($"当前时间：{work.Hour}点 下午状态还不错，继续努力");
        }
        else
        {
            work.SetState(new EveningState());
            work.WriteProgram();
        }
    }
}

internal class EveningState : WorkState
{
    public override void WriteProgram(Work work)
    {
        if (work.TaskFinished)
        {
            work.SetState(new RestState());
            work.WriteProgram();
        }
        else
        {
            if (work.Hour < 21)
            {
                Console.WriteLine($"当前时间：{work.Hour}点 还在加班啊，疲累之极");
            }
            else
            {
                work.SetState(new SleepingState());
                work.WriteProgram();
            }
        }
    }
}

internal class RestState : WorkState
{
    public override void WriteProgram(Work work)
    {
        Console.WriteLine($"当前时间：{work.Hour}点 下班回家了");
    }
}

internal class SleepingState : WorkState
{
    public override void WriteProgram(Work work)
    {
        Console.WriteLine($"当前时间：{work.Hour}点了，不行了，睡着了。");
    }
}


var emergenceWork = new Work();

emergenceWork.Hour = 9;
emergenceWork.WriteProgram();

emergenceWork.Hour = 10;
emergenceWork.WriteProgram();

emergenceWork.Hour = 12;
emergenceWork.WriteProgram();

emergenceWork.Hour = 13;
emergenceWork.WriteProgram();

emergenceWork.Hour = 14;
emergenceWork.WriteProgram();

emergenceWork.Hour = 17;
emergenceWork.WriteProgram();

emergenceWork.TaskFinished = true;//任务完成，可以提前回家了
// emergenceWork.TaskFinished = false;//任务没完成，在公司加班吧

emergenceWork.Hour = 19;
emergenceWork.WriteProgram();

emergenceWork.Hour = 21;
emergenceWork.WriteProgram();
```

## More

更多设计模式及示例代码 [传送门](https://github.com/WeihanLi/DesignPatterns)
