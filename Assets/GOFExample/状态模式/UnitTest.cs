using System;
using GOFExample.状态模式.QFramework版;
using QFramework;
using UnityEngine;

namespace GOFExample.状态模式
{
    public class UnitTest:MonoBehaviour,IController
    {
        private void Start()
        {
            var context = new Context();
           var state = new HumanState(context);
           context.SetState(state);
            context.Request(11);
            context.Request(3);

            this.GetSystem<IStateSystem>().Request(11);
            this.GetSystem<IStateSystem>().Request(3);
        }

        public IArchitecture GetArchitecture()
        {
            return GameArchitecture.Interface;
        }
    }
}