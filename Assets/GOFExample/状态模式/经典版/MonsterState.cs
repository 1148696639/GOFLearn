using UnityEngine;

namespace GOFExample.状态模式
{
    public class MonsterState:State
    {
        public MonsterState(Context content) : base(content)
        {
        }

        public override void Handle(int value)
        {
            Debug.Log("当前状态为怪物状态");
            Debug.Log("值为"+value);

            if (value<10)
            {
                m_Content.SetState(new HumanState(m_Content));
            }
        }
    }
}