using UnityEngine;

namespace GOFExample.状态模式.QFramework版
{
    public class MonsterState:IState
    {
        public MonsterState(StateSystem content)
        {
            Content = content;
        }
        public StateSystem Content { get; set; }

        public void Handle(int value)
        {
            Debug.Log("当前状态为怪物状态");
            Debug.Log("值为"+value);

            if (value<10)
            {
                Content.SetState(new HumanState(Content));
            }
        }
    }
}