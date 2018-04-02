using System;

namespace SimpleFactoryPattern
{
    public class Operation
    {
        public double NumberA { get; set; }
        public double NumberB { get; set; }

        public virtual double GetResult()
        {
            return 0;
        }
    }

    public class OperationAdd : Operation
    {
        public override double GetResult()
        {
            return NumberA + NumberB;
        }
    }

    public class OpertaionSub : Operation
    {
        public override double GetResult()
        {
            return NumberA - NumberB;
        }
    }

    public class OperationMul : Operation
    {
        public override double GetResult()
        {
            return NumberA * NumberB;
        }
    }

    public class OperationDiv : Operation
    {
        public override double GetResult()
        {
            if (NumberB == 0)
            {
                throw new Exception("除数不能为0");
            }
            return NumberA / NumberB;
        }
    }
}
