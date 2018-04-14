using System;

namespace StrategyPattern
{
    /// <summary>
    /// 结算方式
    /// </summary>
    internal abstract class AbstractCash
    {
        /// <summary>
        /// 实际收取金额
        /// </summary>
        /// <param name="money">原价</param>
        /// <returns>按算法计算之后的实收金额</returns>
        public abstract double AcceptCash(double money);
    }

    internal class CashNormal : AbstractCash
    {
        public override double AcceptCash(double money)
        {
            //正常收费，原价
            return money;
        }
    }

    internal class CashRebate : AbstractCash
    {
        private readonly double _rebate;

        public CashRebate(double rebate) => _rebate = rebate;

        public override double AcceptCash(double money)
        {
            return money * _rebate;
        }
    }

    internal class CashReturn : AbstractCash
    {
        private readonly double _condition;
        private readonly double _return;

        public CashReturn(double condition, double mReturn)
        {
            _condition = condition;
            _return = mReturn;
        }

        public override double AcceptCash(double money)
        {
            return money >= _condition ? money - Math.Floor(money / _condition) * _return : money;
        }
    }
}
