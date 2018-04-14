namespace StrategyPattern
{
    internal class CashContext
    {
        private readonly AbstractCash _cash;

        public string StrategyType { get; }

        public CashContext(string type)
        {
            StrategyType = type;
            switch (type)
            {
                case "满300返100":
                    _cash = new CashReturn(300, 100);
                    break;

                case "8 折":
                    _cash = new CashRebate(0.8);
                    break;

                default:
                    _cash = new CashNormal();
                    break;
            }
        }

        public double GetResult(double money)
        {
            return _cash.AcceptCash(money);
        }
    }
}
