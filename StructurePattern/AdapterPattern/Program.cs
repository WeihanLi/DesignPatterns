using System;

namespace AdapterPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Target target = new TargetAdapter();
            target.Request();

            Player player1 = new Forwards("巴蒂尔");
            player1.Attact();
            Player player2 = new Guards("麦迪");
            player2.Defend();
            Player specialPlayer = new Translator("姚明");
            specialPlayer.Attact();
            specialPlayer.Defend();

            Console.ReadLine();
        }
    }
}
