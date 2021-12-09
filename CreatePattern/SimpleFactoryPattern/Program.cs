var oper = OperationFactory.CreateOperation("+");
oper.NumberA = 2.1;
oper.NumberB = 1.2;
Console.WriteLine($"Opertaion: {oper.NumberA} + {oper.NumberB}, result:{oper.GetResult()}");
Console.ReadLine();
