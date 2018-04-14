using System;
using System.Collections.Generic;

namespace VisitorPattern
{
    #region Element

    internal abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }

    internal class ConcreteElementA : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementA(this);
        }

        public void OperationA()
        {
        }
    }

    internal class ConcreteElementB : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementB(this);
        }

        public void OperationB()
        {
        }
    }

    #endregion Element

    #region Visitor

    internal abstract class Visitor
    {
        public abstract void VisitConcreteElementA(ConcreteElementA element);

        public abstract void VisitConcreteElementB(ConcreteElementB element);
    }

    internal class ConcreteVisitor1 : Visitor
    {
        public override void VisitConcreteElementA(ConcreteElementA element)
        {
            Console.WriteLine($"{element.GetType().Name} 被 {GetType().Name} 访问");
        }

        public override void VisitConcreteElementB(ConcreteElementB element)
        {
            Console.WriteLine($"{element.GetType().Name} 被 {GetType().Name} 访问");
        }
    }

    internal class ConcreteVisitor2 : Visitor
    {
        public override void VisitConcreteElementA(ConcreteElementA element)
        {
            Console.WriteLine($"{element.GetType().Name} 被 {GetType().Name} 访问");
        }

        public override void VisitConcreteElementB(ConcreteElementB element)
        {
            Console.WriteLine($"{element.GetType().Name} 被 {GetType().Name} 访问");
        }
    }

    #endregion Visitor

    internal class ObjectStructure
    {
        private readonly IList<Element> _elements = new List<Element>();

        public void Attach(Element element)
        {
            _elements.Add(element);
        }

        public void Detach(Element element)
        {
            _elements.Remove(element);
        }

        public void Accept(Visitor visitor)
        {
            foreach (var element in _elements)
            {
                element.Accept(visitor);
            }
        }
    }
}
