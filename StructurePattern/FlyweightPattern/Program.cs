var counter = 20;

var factory = new FlyWeightFactory();
factory.GetFlyweight("X").Operation(counter--);
factory.GetFlyweight("Y").Operation(counter--);
factory.GetFlyweight("X").Operation(counter--);
factory.GetFlyweight("X").Operation(counter--);

new UnsharedFlyweight().Operation(counter--);

Console.WriteLine(counter);
Console.ReadLine();
