using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    internal class Boss : ISubject
    {
        private readonly IList<Observer> _observers = new List<Observer>();

        public void Attact(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }

        public string SubjectState { get; set; }
    }

    internal class NewBoss : ISubject
    {
        public event Action Update;

        public void Notify()
        {
            Update?.Invoke();
        }

        public string SubjectState { get; set; }
    }
}
