namespace VisitorPattern
{
    internal abstract class Person
    {
        public abstract void Accept(AbstractAction visitor);
    }

    internal class Man : Person
    {
        public override void Accept(AbstractAction visitor)
        {
            visitor.GetManConclusion(this);
        }
    }

    internal class Woman : Person
    {
        public override void Accept(AbstractAction visitor)
        {
            visitor.GetWomanConclusion(this);
        }
    }
}
