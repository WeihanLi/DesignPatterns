using System;

namespace ChainOfResponsibilityPattern
{
    internal abstract class Handler
    {
        protected Handler Successor;

        public void SetSuccessor(Handler successor)
        {
            Successor = successor;
        }

        public abstract void HandleRequest(int request);
    }

    internal class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 0 && request < 10)
            {
                Console.WriteLine($"{GetType().Name} 处理请求{request}");
            }
            else
            {
                Successor?.HandleRequest(request);
            }
        }
    }

    internal class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 10 && request < 20)
            {
                Console.WriteLine($"{GetType().Name} 处理请求{request}");
            }
            else
            {
                Successor?.HandleRequest(request);
            }
        }
    }

    internal class ConcreteHandler3 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 20 && request < 30)
            {
                Console.WriteLine($"{GetType().Name} 处理请求{request}");
            }
            else
            {
                Successor?.HandleRequest(request);
            }
        }
    }

    internal class ConcreteHandler4 : Handler
    {
        public override void HandleRequest(int request)
        {
            Console.WriteLine($"{GetType().Name} 处理请求{request}");
        }
    }
}
