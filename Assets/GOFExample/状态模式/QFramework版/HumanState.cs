using UnityEngine;

namespace GOFExample.状态模式.QFramework版
{
    public class HumanState:IState
    {
        public HumanState(StateSystem content)
        {
            Content = content;
        }
        public StateSystem Content { get; set; }

        public  void Handle(int value)
        {
            Debug.Log("当前状态为人类状态");
            Debug.Log("值为"+value);
            if (value>10)
            {
                Content.SetState(new MonsterState(Content));
            }
        }
    }
}