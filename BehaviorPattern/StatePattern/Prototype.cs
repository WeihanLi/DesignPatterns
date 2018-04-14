using System;

namespace StatePattern
{
    internal class Context
    {
        private State _state;

        public Context(State state) => _state = state;

        public State State
        {
            get => _state;
            set
            {
                _state = value;
                Console.WriteLine($"当前状态：{_state.GetType().Name}");
            }
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }

    internal abstract class State
    {
        public abstract void Handle(Context context);
    }

    internal class ConcreteStateA : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateB(); //设置 ConcreteStateA 的下一状态是 ConcreteStateB
        }
    }

    internal class ConcreteStateB : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateA();//设置 ConcreteStateB 的下一状态是 ConcreteStateA
        }
    }
}
