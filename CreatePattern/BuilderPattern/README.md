# 建造者模式 Builder

## Intro 简介

> 建造者模式: 建造者模式隐藏了复杂对象的创建过程，它把复杂对象的创建过程加以抽象，通过子类继承或者重载的方式，动态的创建具有复合属性的对象。

需要的组件：

- Product
- AbstractBuilder 创建一个 Product 的抽象 builder
- ConcreteBuilder1/ConcreteBuilder2 创建 Product 具体的 builder
- Director 指挥 builder 如何创建一个复杂的 Product

## More

更多设计模式及示例代码 [传送门](https://github.com/WeihanLi/DesignPatterns)
