using System;

namespace DecoratorPattern
{
    internal class Person
    {
        protected readonly string Name;

        public Person()
        {
        }

        public Person(string name)
        {
            Name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine($"装扮的{Name}");
        }
    }

    internal class Finery : Person
    {
        protected Person Person;

        public void Decorate(Person person)
        {
            Person = person;
        }

        public override void Show()
        {
            Person?.Show();
        }
    }

    internal class Tshirts : Finery
    {
        public override void Show()
        {
            Console.WriteLine("Tshirts");
            base.Show();
        }
    }

    internal class Pants : Finery
    {
        public override void Show()
        {
            Console.WriteLine("Pants");
            base.Show();
        }
    }
}
