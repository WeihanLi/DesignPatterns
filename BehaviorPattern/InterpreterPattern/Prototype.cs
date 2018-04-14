using System;

namespace InterpreterPattern
{
    internal class Context
    {
        public string Input { get; set; }
        public string Output { get; set; }
    }

    internal abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }

    internal class TerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("TerminalExpressionInterpreter");
        }
    }

    internal class NoneTerminalExpresssion : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("NonTerminalExpressionInterpreter");
        }
    }
}
