namespace PrototypePattern
{
    internal abstract class Prototype
    {
        public string Id { get; }

        protected Prototype(string id) => Id = id;

        public abstract Prototype Clone();
    }

    internal class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(string id) : base(id)
        {
        }

        public override Prototype Clone()
        {
            return (Prototype)MemberwiseClone();
        }
    }
}
