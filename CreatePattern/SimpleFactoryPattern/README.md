# SimpleFactory 简单工厂

## Intro 简介

简单工厂模式是由一个工厂对象决定创建出哪一种产品类的实例。

简单工厂模式是工厂模式家族中最简单实用的模式，但不属于23种GOF设计模式之一。因为每次要新增类型的时候必须修改工厂内部代码，不符合开闭原则。

在实际的业务代码里，简单工厂的应用还是蛮多的。

## 实现方式

实现方式大致如下：

``` csharp
public class OperationFactory
{
    public static Operation CreateOperation(string operate)
    {
        Operation operation = null;
        switch (operate)
        {
            case "+":
                operation = new OperationAdd();
                break;

            case "-":
                operation = new OpertaionSub();
                break;

            case "*":
                operation = new OperationMul();
                break;

            case "/":
                operation = new OperationDiv();
                break;
        }
        return operation;
    }
}
```

## More

更多设计模式及示例代码 [传送门](https://github.com/WeihanLi/DesignPatterns)