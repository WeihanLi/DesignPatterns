namespace StatePattern
{
    internal class Work
    {
        private WorkState _currentState;

        public Work()
        {
            _currentState = new ForenoonState();
        }

        public int Hour { get; set; }

        public bool TaskFinished { get; set; }

        public void SetState(WorkState workState)
        {
            _currentState = workState;
        }

        public void WriteProgram()
        {
            _currentState.WriteProgram(this);
        }
    }
}
