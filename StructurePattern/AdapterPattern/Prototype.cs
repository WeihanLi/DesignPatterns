using System;

namespace AdapterPattern
{
    internal class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("This is a common request");
        }
    }

    internal class Adaptee
    {
        public void SpecialRequest()
        {
            Console.WriteLine("this is a special request");
        }
    }

    internal class TargetAdapter : Target
    {
        private readonly Adaptee _adaptee = new Adaptee();

        public override void Request()
        {
            _adaptee.SpecialRequest();
        }
    }
}
