namespace BuilderPattern
{
    internal class ConcreteBuilder1 : Builder
    {
        private readonly Product _product = new Product();

        public override void BuildPartA() => _product.Add("PartA");

        public override void BuildPartB() => _product.Add("PartB");

        public override Product GetResult() => _product;
    }
}
