# 解释器模式 Interpreter

## Intro

解释器模式，给定一个语言，定义它的文法的一种表示，并定义一个解释器，这个解释器使用该表示来解释语言中的句子。

这和解释型编程语言的解释器有点类似，要根据一段输入转换成一段输出，将不易读的文本转换为易读的文本，将机器不能识别的输入转成二进制机器可读的输出

当有一个语言需要解释执行，并且你可以将该语言中的句子表示为一个抽象语法树时，可以使用解释器模式。

## Prototype

- Context: 解释器上下文
- AbstractExpression: 解释表达式抽象，定义解释操作
- ConcreteExpression: 解释表达式实现类，实现具体的解释逻辑

## Sample

``` csharp
public class Context
{
    public string Input { get; set; }
    public string Output { get; set; }
}

public abstract class AbstractExpression
{
    public abstract void Interpret(Context context);
}
public class TerminalExpression : AbstractExpression
{
    public override void Interpret(Context context)
    {
        Console.WriteLine("TerminalExpressionInterpreter");
    }
}
public class NoneTerminalExpression : AbstractExpression
{
    public override void Interpret(Context context)
    {
        Console.WriteLine("NonTerminalExpressionInterpreter");
    }
}


var context = new Context();
ICollection<AbstractExpression> expressions = new List<AbstractExpression>();

expressions.Add(new TerminalExpression());
expressions.Add(new TerminalExpression());
expressions.Add(new NoneTerminalExpression());

foreach (var expression in expressions)
{
    expression.Interpret(context);
}
```

## More

更多设计模式及示例代码 [传送门](https://github.com/WeihanLi/DesignPatterns)
