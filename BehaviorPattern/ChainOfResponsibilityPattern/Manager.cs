using System;

namespace ChainOfResponsibilityPattern
{
    internal abstract class Manager
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

    internal class CommonManager : Manager
    {
        public CommonManager(string managerName) : base(managerName)
        {
        }

        public override void RequestApplications(Request request)
        {
            if (request.RequestType == "请假" && request.RequestNum <= 2)
            {
                Console.WriteLine($"{ManagerName}: {request.RequestContent} {request.RequestNum}天被批准");
            }
            else
            {
                Superior?.RequestApplications(request);
            }
        }
    }

    internal class Majordomo : Manager
    {
        public Majordomo(string managerName) : base(managerName)
        {
        }

        public override void RequestApplications(Request request)
        {
            if (request.RequestType == "请假" && request.RequestNum <= 5)
            {
                Console.WriteLine($"{ManagerName}: {request.RequestContent} {request.RequestNum}天被批准");
            }
            else
            {
                Superior?.RequestApplications(request);
            }
        }
    }

    internal class GeneralManager : Manager
    {
        public GeneralManager(string managerName) : base(managerName)
        {
        }

        public override void RequestApplications(Request request)
        {
            if (request.RequestType == "请假")
            {
                Console.WriteLine($"{ManagerName}: {request.RequestContent} {request.RequestNum}天被批准");
                return;
            }
            if (request.RequestType == "加薪" && request.RequestNum <= 500)
            {
                Console.WriteLine($"{ManagerName}: {request.RequestContent} 数量{request.RequestNum}被批准");
                return;
            }
            if (request.RequestType == "加薪" && request.RequestNum > 500)
            {
                Console.WriteLine($"{ManagerName}: {request.RequestContent} {request.RequestNum}，再说吧");
            }
        }
    }
}
