#region Prototype

var o = new ObjectStructure();
o.Attach(new ConcreteElementA());
o.Attach(new ConcreteElementB());
o.Accept(new ConcreteVisitor1());
o.Accept(new ConcreteVisitor2());

Console.WriteLine();

#endregion Prototype

var personStructure = new PersonStructure();
personStructure.Attach(new Man());
personStructure.Attach(new Woman());

personStructure.Display(new Success());
personStructure.Display(new Fail());
personStructure.Display(new Marriage());

Console.ReadLine();
