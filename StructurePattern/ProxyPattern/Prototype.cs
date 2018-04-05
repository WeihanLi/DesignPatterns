using System;

namespace ProxyPattern
{
    internal abstract class Subject
    {
        public abstract void Request();
    }

    internal class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("request from real subject");
        }
    }

    internal class Proxy0 : Subject
    {
        private Subject _subject;

        public override void Request()
        {
            if (null == _subject)
            {
                _subject = new RealSubject();
            }
            _subject.Request();
        }
    }

    internal class Proxy : Subject
    {
        private readonly Subject _subject;

        public Proxy(Subject subject) => _subject = subject;

        public override void Request()
        {
            _subject.Request();
        }
    }
}
