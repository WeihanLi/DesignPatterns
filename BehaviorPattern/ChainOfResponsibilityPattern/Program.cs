using System;

namespace ChainOfResponsibilityPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Prototype

            Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();
            Handler h3 = new ConcreteHandler3();
            Handler h4 = new ConcreteHandler4();

            h1.SetSuccessor(h2);
            h2.SetSuccessor(h3);
            h3.SetSuccessor(h4);

            var random = new Random();
            for (var i = 0; i < 10; i++)
            {
                h1.HandleRequest(random.Next(40));
            }

            #endregion Prototype

            var manager = new CommonManager("金利");
            var manager1 = new Majordomo("宗剑");
            var manager2 = new GeneralManager("钟精励");

            manager1.SetSuperior(manager2);
            manager.SetSuperior(manager1);

            var request = new Request()
            {
                RequestNum = 1,
                RequestType = "请假",
                RequestContent = "小菜请假"
            };

            manager.RequestApplications(request);

            var request1 = new Request()
            {
                RequestNum = 4,
                RequestType = "请假",
                RequestContent = "小菜请假"
            };

            manager.RequestApplications(request1);

            var request2 = new Request()
            {
                RequestNum = 500,
                RequestType = "加薪",
                RequestContent = "小菜请求加薪"
            };

            manager.RequestApplications(request2);

            var request3 = new Request()
            {
                RequestNum = 1000,
                RequestType = "加薪",
                RequestContent = "小菜请求加薪"
            };

            manager.RequestApplications(request3);

            Console.ReadLine();
        }
    }
}
