using System;
using System.Collections.Generic;

namespace CommandPattern
{
    public class Waiter
    {
        private readonly ICollection<OrderCommand> _orders = new List<OrderCommand>();

        public void SetOrder(OrderCommand order)
        {
            if (order.ToString() == "BakeChickenWingCommand")
            {
                Console.WriteLine("鸡翅没有了，换点别的吧");
            }
            else
            {
                Console.WriteLine($"{order} 下单成功");
                _orders.Add(order);
            }
        }

        public void CancelOrder(OrderCommand order)
        {
            _orders.Remove(order);
            Console.WriteLine($"取消订单:{order}，取消时间：{DateTime.Now:yyyy-MM-dd HH:mm:ss}");
        }

        public void Notify()
        {
            foreach (var order in _orders)
            {
                order.ExecuteCommand();
            }
        }
    }
}
