#region Prototype

var context = new Context(new ConcreteStrategyA());
context.Implement();

context = new Context(new ConcreteStrategyB());
context.Implement();

context = new Context(new ConcreteStrategyC());
context.Implement();

Console.WriteLine();

#endregion Prototype

var strategyArray = new[]
{
    "8 折",
    "正常",
    "原价",
    "满300返100"
};

var random = new Random();

for (var i = 0; i < 10; i++)
{
    var cashContext = new CashContext(strategyArray[random.Next(strategyArray.Length)]);

    var money = random.Next(500);
    Console.WriteLine($"结算方式：{cashContext.StrategyType} ，原价{money}，实际收取：{cashContext.GetResult(money)}");
}

Console.ReadLine();
