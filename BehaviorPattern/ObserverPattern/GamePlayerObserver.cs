using System;

namespace ObserverPattern
{
    internal class GamePlayerObserver
    {
        private readonly string _name;
        private readonly ISubject _subject;

        public GamePlayerObserver(string name, ISubject subject)
        {
            _name = name;
            _subject = subject;
        }

        public void CloseGame()
        {
            Console.WriteLine($"{_name} {_subject.SubjectState} 关闭 LOL 游戏，继续工作");
        }
    }
}
