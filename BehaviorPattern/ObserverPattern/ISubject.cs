namespace ObserverPattern
{
    internal interface ISubject
    {
        void Notify();

        string SubjectState { get; set; }
    }
}
