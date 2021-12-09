#region Prototype

AbstractClass c = new ConcreteClassA();
c.TemplateMethod();
c = new ConcreteClassB();
c.TemplateMethod();

Console.WriteLine();

#endregion Prototype

var paper1 = new TestPaperA();
paper1.TestResult();

var pager2 = new TestPaperB();
pager2.TestResult();

Console.ReadLine();
