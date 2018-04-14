using System;

namespace TemplateMethodPattern
{
    internal abstract class AbstractClass
    {
        protected abstract void PrimitiveOperation1();

        protected abstract void PrimitiveOperation2();

        public void TemplateMethod()
        {
            Console.WriteLine("-------Begin-------");
            PrimitiveOperation1();
            PrimitiveOperation2();
            Console.WriteLine("-------End-------");
        }
    }

    internal class ConcreteClassA : AbstractClass
    {
        protected override void PrimitiveOperation1()
        {
            Console.WriteLine("具体类A 方法1 的实现");
        }

        protected override void PrimitiveOperation2()
        {
            Console.WriteLine("具体类A 方法2 的实现");
        }
    }

    internal class ConcreteClassB : AbstractClass
    {
        protected override void PrimitiveOperation1()
        {
            Console.WriteLine("具体类B 方法1 的实现");
        }

        protected override void PrimitiveOperation2()
        {
            Console.WriteLine("具体类B 方法2 的实现");
        }
    }
}
