using System.Collections.Generic;

namespace IteratorPattern
{
    internal abstract class Aggregate
    {
        /// <summary>
        /// 创建迭代器
        /// </summary>
        /// <returns></returns>
        public abstract Iterator CreateIterator();
    }

    internal class ConcreteAggregate : Aggregate
    {
        private readonly IList<object> _items = new List<object>();

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public int TotalCount => _items.Count;

        public object this[int index]
        {
            get => _items[index];
            set => _items.Insert(index, value);
        }
    }
}
