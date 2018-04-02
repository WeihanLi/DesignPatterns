namespace BuilderPattern
{
    internal class ConcreteBuilder2 : Builder
    {
        private readonly Product _product = new Product();

        public override void BuildPartA() => _product.Add("PartX");

        public override void BuildPartB() => _product.Add("PartY");

        public override Product GetResult() => _product;
    }
}
