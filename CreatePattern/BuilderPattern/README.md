# 建造者模式 Builder

## Intro 简介

> 建造者模式: 建造者模式隐藏了复杂对象的创建过程，它把复杂对象的创建过程加以抽象，通过子类继承或者重载的方式，动态的创建具有复合属性的对象。

需要的组件：

- Product
- AbstractBuilder 创建一个 Product 的抽象 builder
- ConcreteBuilder1/ConcreteBuilder2 创建 Product 具体的 builder
- Director 指挥 builder 如何创建一个复杂的 Product

## Sample

``` csharp
var director = new Director();
Builder builder1 = new ConcreteBuilder1(), builder2 = new ConcreteBuilder2();

director.Construct(builder1);
director.Construct(builder2);

var product2 = builder1.GetResult();
var product2 = builder2.GetResult();
```

.net core 中的各种 builder (`HostBuilder`/`ConfigurationBuilder`/...) 我觉得也是属于建造者模式的，只是 Builder 本身就是 Director，
通过 builder 来实现对象的各种参数配置构建最后的 Product (`Host`/`Configuration`/...)

## More

更多设计模式及示例代码 [传送门](https://github.com/WeihanLi/DesignPatterns)
