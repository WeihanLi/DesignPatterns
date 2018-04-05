using System;

namespace DecoratorPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            #region Prototype

            Component component = new ConcreteComponent();
            Decorator decorator = new DecoratorA();
            decorator.SetComponent(component);
            decorator.Operation();

            Decorator decorator1 = new DecoratorB();
            decorator1.SetComponent(decorator);
            decorator1.Operation();

            #endregion Prototype

            var person = new Person("小明");

            Console.WriteLine("\n第一种装扮：\n");
            var pants = new Pants();
            pants.Decorate(person);
            pants.Show();

            Console.WriteLine("\n第二种装扮：\n");
            var shirts = new Tshirts();
            shirts.Decorate(pants);
            shirts.Show();

            Console.ReadLine();
        }
    }
}
