using QFramework;

namespace GOFExample.状态模式.QFramework版
{
    internal interface IStateSystem : ISystem
    {
        void Request(int value);
    }

    public class StateSystem : AbstractSystem, IStateSystem
    {
        private IState m_State;

        public void Request(int value)
        {
            m_State.Handle(value);
        }

        public void SetState(IState state)
        {
            m_State = state;
        }

        protected override void OnInit()
        {
            SetState(new HumanState(this));
        }
    }
}