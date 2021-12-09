namespace StrategyPattern;

internal class CashContext
{
    private readonly AbstractCash _cash;

    public string StrategyType { get; }

    public CashContext(string type)
    {
        StrategyType = type;
        _cash = type switch
        {
            "满300返100" => new CashReturn(300, 100),
            "8 折" => new CashRebate(0.8),
            _ => new CashNormal()
        };
    }

    public double GetResult(double money)
    {
        return _cash.AcceptCash(money);
    }
}
