using System;

namespace MementoPattern
{
    /// <summary>
    /// 发起人
    /// </summary>
    internal class Originator
    {
        public string State { get; set; }

        public Memento CreateMemento()
        {
            return new Memento(State);
        }

        public void SetMemento(Memento memento)
        {
            State = memento?.State;
        }

        public void Show()
        {
            Console.WriteLine($"State:{State}");
        }
    }

    internal class Memento
    {
        public string State { get; }

        public Memento(string state) => State = state;
    }

    internal class Caretaker
    {
        public Memento Memento { get; set; }
    }
}
