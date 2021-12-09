#region Prototype

Abstraction ab = new RefinedAbstraction();

ab.SetImplementor(new ConcreteImplementorA());
ab.Operation();

ab.SetImplementor(new ConcreteImplementorB());
ab.Operation();

Console.WriteLine();

#endregion Prototype

HandsetBrand handsetBrand = new HandsetBrandM();
handsetBrand.SetHandsetSoft(new HandsetMp3());
handsetBrand.Run();
handsetBrand.SetHandsetSoft(new HandsetGame());
handsetBrand.Run();

handsetBrand = new HandsetBrandN();
handsetBrand.SetHandsetSoft(new HandsetAddressList());
handsetBrand.Run();

Console.ReadLine();
