# 职责链（责任链）模式 Chain of Responsibility

## Intro

职责链（责任链）模式，很多对象由每一个对象对其下家的引用而连接起来形成一条链。请求在这个链上传递，直到链上的某一个对象决定处理此请求。
发出这个请求的客户端并不知道链上的哪一个对象最终处理这个请求，这使得系统可以在不影响客户端的情况下动态地重新组织和分配责任。

## Sample

``` csharp
public class Request
{
    public string RequestContent { get; set; }

    public int RequestNum { get; set; }
}

public abstract class Manager
{
    protected readonly string ManagerName;
    protected Manager Superior;

    protected Manager(string managerName) => ManagerName = managerName;

    public void SetSuperior(Manager superior)
    {
        Superior = superior;
    }

    public abstract void RequestApplications(Request request);
}

public class CommonManager : Manager
{
    public CommonManager(string managerName) : base(managerName)
    {
    }

    public override void RequestApplications(Request request)
    {
        if (request.RequestNum <= 2)
        {
            Console.WriteLine($"{ManagerName}: {request.RequestContent} {request.RequestNum}天被批准");
        }
        else
        {
            Superior?.RequestApplications(request);
        }
    }
}

public class Majordomo : Manager
{
    public Majordomo(string managerName) : base(managerName)
    {
    }

    public override void RequestApplications(Request request)
    {
        if (request.RequestNum <= 5)
        {
            Console.WriteLine($"{ManagerName}: {request.RequestContent} {request.RequestNum}天被批准");
        }
        else
        {
            Superior?.RequestApplications(request);
        }
    }
}

public class GeneralManager : Manager
{
    public GeneralManager(string managerName) : base(managerName)
    {
    }

    public override void RequestApplications(Request request)
    {
        if (request.RequestNum <= 10)
        {
            Console.WriteLine($"{ManagerName}: {request.RequestContent} {request.RequestNum}天被批准");
        }
        else
        {
            Console.WriteLine($"{ManagerName}: {request.RequestContent} {request.RequestNum}天不被批准");
        }
    }
}


var manager = new CommonManager("金利");
var manager1 = new Majordomo("宗剑");
var manager2 = new GeneralManager("钟精励");

manager1.SetSuperior(manager2);
manager.SetSuperior(manager1);

var request = new Request()
{
    RequestNum = 4,
    RequestContent = "小菜请假"
};

manager.RequestApplications(request);
```

## AndMore

asp.net core 中请求管道中间件的设计就是这种模式的变形，可以很灵活的处理请求

我封装了一个 `PipelineBuilder` (<https://www.cnblogs.com/weihanli/p/12700006.html>) 用来轻松的构建中间件模式的代码，来看下面的示例：

``` csharp
private class RequestContext
{
    public string RequesterName { get; set; }

    public int Hour { get; set; }
}

public static void Test()
{
    var requestContext = new RequestContext()
    {
        RequesterName = "Kangkang",
        Hour = 12,
    };

    var builder = PipelineBuilder.Create<RequestContext>(context =>
            {
                Console.WriteLine($"{context.RequesterName} {context.Hour}h apply failed");
            })
            .Use((context, next) =>
            {
                if (context.Hour <= 2)
                {
                    Console.WriteLine("pass 1");
                }
                else
                {
                    next();
                }
            })
            .Use((context, next) =>
            {
                if (context.Hour <= 4)
                {
                    Console.WriteLine("pass 2");
                }
                else
                {
                    next();
                }
            })
            .Use((context, next) =>
            {
                if (context.Hour <= 6)
                {
                    Console.WriteLine("pass 3");
                }
                else
                {
                    next();
                }
            })
        ;
    var requestPipeline = builder.Build();
    foreach (var i in Enumerable.Range(1, 8))
    {
        Console.WriteLine();
        Console.WriteLine($"--------- h:{i} apply Pipeline------------------");
        requestContext.Hour = i;
        requestPipeline.Invoke(requestContext);
        Console.WriteLine("----------------------------");
        Console.WriteLine();
    }
}
```

## More

更多设计模式及示例代码 [传送门](https://github.com/WeihanLi/DesignPatterns)
