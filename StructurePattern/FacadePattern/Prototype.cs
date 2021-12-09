namespace FacadePattern;

public class SubSystem1
{
    public void MethodA()
    {
        Console.WriteLine("MethodA in SubSystem1");
    }

    public void MethodB()
    {
        Console.WriteLine("MethodB in SubSystem1");
    }
}

public class SubSystem2
{
    public void MethodA()
    {
        Console.WriteLine("MethodA in SubSystem2");
    }

    public void MethodB()
    {
        Console.WriteLine("MethodB in SubSystem2");
    }
}

public class SubSystem3
{
    public void MethodA()
    {
        Console.WriteLine("MethodA in SubSystem3");
    }

    public void MethodB()
    {
        Console.WriteLine("MethodB in SubSystem3");
    }
}

public class Facade
{
    private readonly SubSystem1 _subSystem1 = new();
    private readonly SubSystem2 _subSystem2 = new();
    private readonly SubSystem3 _subSystem3 = new();

    public void MethodA()
    {
        _subSystem1.MethodA();
        _subSystem2.MethodA();
        _subSystem3.MethodA();
        Console.WriteLine();
    }

    public void MethodB()
    {
        _subSystem1.MethodB();
        _subSystem2.MethodB();
        _subSystem3.MethodB();
        Console.WriteLine();
    }
}
