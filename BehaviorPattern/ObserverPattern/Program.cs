using System;

namespace ObserverPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var boss = new Boss();

            var stockObserver = new StockObserver("魏关姹", boss);
            var nbaObserver = new NBAObserver("易管查", boss);

            boss.Attact(stockObserver);
            boss.Attact(nbaObserver);

            boss.Detach(stockObserver);

            boss.SubjectState = "老板我胡汉三回来了";

            boss.Notify();
            Console.WriteLine();

            var newBoss = new NewBoss(); // 通过事件来通知的新老板
            var gameObserver = new GamePlayerObserver("西门", newBoss);

            // 注册通知事件
            newBoss.Update += stockObserver.Update;
            newBoss.Update += nbaObserver.Update;
            newBoss.Update += gameObserver.CloseGame;

            newBoss.SubjectState = "老板我胡汉三回来了";
            newBoss.Notify();

            Console.ReadLine();
        }
    }
}
