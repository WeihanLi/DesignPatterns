using System;

namespace VisitorPattern
{
    internal abstract class AbstractAction
    {
        public abstract void GetManConclusion(Man man);

        public abstract void GetWomanConclusion(Woman woman);
    }

    internal class Success : AbstractAction
    {
        public override void GetManConclusion(Man man)
        {
            Console.WriteLine($"{man.GetType().Name} {GetType().Name} 时,背后多半有一个伟大的女人");
        }

        public override void GetWomanConclusion(Woman woman)
        {
            Console.WriteLine($"{woman.GetType().Name} {GetType().Name} 时,背后多有一个不成功的男人");
        }
    }

    internal class Fail : AbstractAction
    {
        public override void GetManConclusion(Man man)
        {
            Console.WriteLine($"{man.GetType().Name} {GetType().Name} 时,背后多半有一个伟大的女人");
        }

        public override void GetWomanConclusion(Woman woman)
        {
            Console.WriteLine($"{woman.GetType().Name} {GetType().Name} 时,背后多有一个不成功的男人");
        }
    }

    internal class Marriage : AbstractAction
    {
        public override void GetManConclusion(Man man)
        {
            Console.WriteLine($"{man.GetType().Name} {GetType().Name} 时,感慨道:恋爱游戏终结时,'有妻徒刑'遥无期");
        }

        public override void GetWomanConclusion(Woman woman)
        {
            Console.WriteLine($"{woman.GetType().Name} {GetType().Name} 时,欣慰曰:爱情长路跑漫漫,婚姻保险保平安.");
        }
    }
}
