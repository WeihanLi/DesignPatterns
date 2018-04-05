using System;
using System.Collections.Generic;

namespace CompositePattern
{
    internal abstract class Company
    {
        protected string Name;

        protected Company(string name) => Name = name;

        public abstract void Add(Company company);

        public abstract void Remove(Company company);

        public virtual void Display(int depth)
        {
            Console.WriteLine($"{new string('-', depth)} {Name}");
        }

        public abstract void LineOfDuty();
    }

    internal class ConcreteCompany : Company
    {
        private readonly List<Company> _children = new List<Company>();

        public ConcreteCompany(string name) : base(name)
        {
        }

        public override void Add(Company company)
        {
            _children.Add(company);
        }

        public override void Remove(Company company)
        {
            _children.Remove(company);
        }

        public override void Display(int depth)
        {
            Console.WriteLine($"{new string('-', depth)} {Name}");
            foreach (var company in _children)
            {
                company.Display(depth + 2);
            }
        }

        public override void LineOfDuty()
        {
            foreach (var company in _children)
            {
                company.LineOfDuty();
            }
        }
    }

    internal class HrDepartment : Company
    {
        public HrDepartment(string name) : base(name)
        {
        }

        public override void Add(Company company)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Company company)
        {
            throw new NotImplementedException();
        }

        public override void LineOfDuty()
        {
            Console.WriteLine($"{Name} Hr comes.");
        }
    }

    internal class FinanceDepartment : Company
    {
        public FinanceDepartment(string name) : base(name)
        {
        }

        public override void Add(Company company)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Company company)
        {
            throw new NotImplementedException();
        }

        public override void LineOfDuty()
        {
            Console.WriteLine($"{Name} Finance comes");
        }
    }
}
