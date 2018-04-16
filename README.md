# DesignPatterns

## Intro 简介

Design patterns from 《大话设计模式》 and implemented by C# language.

《大话设计模式》 中设计模式总结/C#代码实现，示例代码是以 C# + .NetCore2.0 写的，如果要自己编译请[下载](https://www.microsoft.com/net/download)安装 .NetCore Sdk

## 设计模式设计原则

- 单一职责原则

    > 对于一个类而言，应该仅有一个引起它变化的原因
    >
    > 如果一个类承担的职责过多，就等于把这些职责耦合再一起，一个职责的变化可能会削弱或者抑制这个类完全其他职责的能力。这种耦合会导致脆弱的设计，当发生变化时，设计会遭受到意想不到的破坏。

- 开放-封闭原则

    > 开放-封闭原则是说软件实体（类、模块、函数等等）应该可以扩展，但是不可修改。
    >
    > 对于扩展开放，对于更改封闭

- 依赖倒转原则

    > - 高层模块不应该依赖低层模式，两个都应该依赖抽象。
    > - 抽象不应该依赖细节，细节应该依赖于抽象。基于接口编程。

- 里氏代换原则

    > 子类型必须能够替换掉它们的父类型

- 迪米特法则

    > 如果两个类不必彼此通信，那么这两个类就不应当发生直接的相互作用。如果其中一个类需要调用另一个类的某一个方法，可以通过第三者转发这个调用。
    >
    > 类的结构设计上，每一个类都应当尽量降低成员的访问权限
    >
    > 类之间的耦合越弱，越有利于复用，一个处在弱耦合的类别修改，不会对有关系的类造成波及

## Overview 概览

设计模式大体上可分为三类：

- 创建型模式（Create）
    1. [简单工厂（SimpleFactory）](./CreatePattern/SimpleFactoryPattern)
    1. [抽象工厂（AbstractFactory）](./CreatePattern/AbstractFactoryPattern)
    1. [工厂方法（FactoryMethod）](./CreatePattern/FactoryMethodPattern)
    1. [建造者模式（Builder）](./CreatePattern/BuilderPattern)
    1. [原型模式（Prototype）](./CreatePattern/PrototypePattern)
    1. [单例模式（Singleton）](./CreatePattern/SingletonPattern)

- 结构型模式（Structure）
    1. [适配器模式（Adapter）](./StructurePattern/AdapterPattern)
    1. [桥接模式（Bridge）](./StructurePattern/BridgePattern)
    1. [组合模式（Composite）](./StructurePattern/CompositePattern)
    1. [装饰者模式（Decorator）](./StructurePattern/DecoratorPattern)
    1. [外观模式（Facade）](./StructurePattern/FacadePattern)
    1. [享元模式（Flyweight）](./StructurePattern/FlyweightPattern)
    1. [代理模式（Proxy）](./StructurePattern/ProxyPattern)

- 行为型模式（Behavior）
    1. [观察者模式（Observer）](./BehaviorPattern/ObserverPattern)
    1. [模板方法（TemplateMethod）](./BehaviorPattern/TemplateMethodPattern)
    1. [命令模式（Command）](./BehaviorPattern/CommandPattern)
    1. [状态模式（State）](./BehaviorPattern/StatePattern)
    1. [职责链模式（Chain of Responsibility）](./BehaviorPattern/ChainOfResponsibilityPattern)
    1. [解释器模式（Interpreter）](./BehaviorPattern/InterpreterPattern)
    1. [中介者模式（Mediator）](./BehaviorPattern/MediatorPattern)
    1. [访问者模式（Visitor）](./BehaviorPattern/VisitorPattern)
    1. [备忘录模式（Memento）](./BehaviorPattern/MementoPattern)
    1. [迭代器模式（Iterator）](./BehaviorPattern/IteratorPattern)

## Contact

Contact me: <weihanli@outlook.com>
