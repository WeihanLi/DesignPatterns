﻿// 这里显示 new 对象的地方同样可以通过 配置+反射 和 依赖注入 的方式去做，可参考 抽象工厂模式
ILeifengFactory factory = new UndergraduteFactory();
var studentLeifeng = factory.CreateLeifeng();
studentLeifeng.BuyRice();
var studentLeifeng1 = factory.CreateLeifeng();
studentLeifeng1.Sweep();

// 依赖注入
using var services = new ServiceCollection()
    .AddSingleton<ILeifengFactory, VolunteerFactory>()
    .BuildServiceProvider();

var leifengFactory = services.GetRequiredService<ILeifengFactory>();
var volunteer = leifengFactory.CreateLeifeng();
volunteer.Wash();

Console.ReadLine();