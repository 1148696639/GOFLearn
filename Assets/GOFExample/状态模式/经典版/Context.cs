namespace GOFExample.状态模式
{
    public class Context
    {
        private State m_State;

        public void SetState(State state)
        {
            m_State = state;
        }

        public void Request(int value)
        {
            m_State.Handle(value);
        }
    }
}