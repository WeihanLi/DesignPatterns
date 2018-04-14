using System;

namespace StatePattern
{
    internal abstract class WorkState
    {
        public abstract void WriteProgram(Work work);
    }

    internal class ForenoonState : WorkState
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour < 12)
            {
                Console.WriteLine($"当前时间：{work.Hour}点 上午工作，精神百倍");
            }
            else
            {
                work.SetState(new NoonState());
                work.WriteProgram();
            }
        }
    }

    internal class NoonState : WorkState
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour < 13)
            {
                Console.WriteLine($"当前时间：{work.Hour}点 饿了，午饭。犯困，午休");
            }
            else
            {
                work.SetState(new AfternoonState());
                work.WriteProgram();
            }
        }
    }

    internal class AfternoonState : WorkState
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour < 18)
            {
                Console.WriteLine($"当前时间：{work.Hour}点 下午状态还不错，继续努力");
            }
            else
            {
                work.SetState(new EveningState());
                work.WriteProgram();
            }
        }
    }

    internal class EveningState : WorkState
    {
        public override void WriteProgram(Work work)
        {
            if (work.TaskFinished)
            {
                work.SetState(new RestState());
                work.WriteProgram();
            }
            else
            {
                if (work.Hour < 21)
                {
                    Console.WriteLine($"当前时间：{work.Hour}点 还在加班啊，疲累之极");
                }
                else
                {
                    work.SetState(new SleepingState());
                    work.WriteProgram();
                }
            }
        }
    }

    internal class RestState : WorkState
    {
        public override void WriteProgram(Work work)
        {
            Console.WriteLine($"当前时间：{work.Hour}点 下班回家了");
        }
    }

    internal class SleepingState : WorkState
    {
        public override void WriteProgram(Work work)
        {
            Console.WriteLine($"当前时间：{work.Hour}点了，不行了，睡着了。");
        }
    }
}
