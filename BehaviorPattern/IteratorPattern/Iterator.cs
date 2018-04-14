namespace IteratorPattern
{
    internal abstract class Iterator
    {
        public abstract object First();

        public abstract object Next();

        public abstract bool IsDone();

        public abstract object CurrentItem();
    }

    internal class ConcreteIterator : Iterator
    {
        private readonly ConcreteAggregate _aggregate;
        private int _current = 0;

        public ConcreteIterator(ConcreteAggregate aggregate) => _aggregate = aggregate;

        public override object First()
        {
            return _aggregate[0];
        }

        public override object Next()
        {
            _current++;
            return _current >= _aggregate.TotalCount ? null : _aggregate[_current];
        }

        public override bool IsDone() => _current >= _aggregate.TotalCount;

        public override object CurrentItem() => _aggregate[_current];
    }

    internal class ConcreteIteratorDesc : Iterator
    {
        private readonly ConcreteAggregate _aggregate;
        private int _current;

        public ConcreteIteratorDesc(ConcreteAggregate aggregate)
        {
            _aggregate = aggregate;
            _current = _aggregate.TotalCount - 1;
        }

        public override object First() => _aggregate[_aggregate.TotalCount - 1];

        public override object Next()
        {
            _current--;
            return _current >= 0 ? _aggregate[_current] : null;
        }

        public override bool IsDone() => _current < 0;

        public override object CurrentItem() => _aggregate[_current];
    }
}
