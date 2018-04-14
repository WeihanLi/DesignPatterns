using System;

namespace StatePattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Prototype

            var context = new Context(new ConcreteStateA());
            context.Request();
            context.Request();
            context.Request();
            context.Request();

            Console.WriteLine();

            #endregion Prototype

            var emergenceWork = new Work();

            emergenceWork.Hour = 9;
            emergenceWork.WriteProgram();

            emergenceWork.Hour = 10;
            emergenceWork.WriteProgram();

            emergenceWork.Hour = 12;
            emergenceWork.WriteProgram();

            emergenceWork.Hour = 13;
            emergenceWork.WriteProgram();

            emergenceWork.Hour = 14;
            emergenceWork.WriteProgram();

            emergenceWork.Hour = 17;
            emergenceWork.WriteProgram();

            emergenceWork.TaskFinished = true;//任务完成，可以提前回家了
            // emergenceWork.TaskFinished = false;//任务没完成，在公司加班吧

            emergenceWork.Hour = 19;
            emergenceWork.WriteProgram();

            emergenceWork.Hour = 21;
            emergenceWork.WriteProgram();

            Console.ReadLine();
        }
    }
}
