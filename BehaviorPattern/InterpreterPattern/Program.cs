using System;
using System.Collections.Generic;

namespace InterpreterPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Prototype

            var context = new Context();
            ICollection<AbstractExpression> expressions = new List<AbstractExpression>();

            expressions.Add(new TerminalExpression());
            expressions.Add(new TerminalExpression());
            expressions.Add(new NoneTerminalExpresssion());

            foreach (var expression in expressions)
            {
                expression.Interpret(context);
            }

            #endregion Prototype

            var playContext = new PlayContext
            {
                PlayText = "T 500 O 2 E 0.5 G 0.5 A 3 E 0.5 G 0.5 D 3 E 0.5 G 0.5 A 0.5 O 3 E 0.5 D 3 "
            };
            MusicalExpression musicalExpression = null;

            while (!string.IsNullOrEmpty(playContext.PlayText))
            {
                var str = playContext.PlayText.Substring(0, 1);
                switch (str)
                {
                    case "O":
                        musicalExpression = new MusicalScale();
                        break;

                    case "T":
                        musicalExpression = new MusicalSpeed();
                        break;

                    case "A":
                    case "B":
                    case "C":
                    case "D":
                    case "E":
                    case "F":
                    case "G":
                    case "P":
                        musicalExpression = new MusicalNote();
                        break;
                }
                musicalExpression?.Interpret(playContext);
            }

            Console.ReadLine();
        }
    }
}
