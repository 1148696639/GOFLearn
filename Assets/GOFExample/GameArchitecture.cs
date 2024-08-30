using GOFExample.状态模式.QFramework版;
using QFramework;

namespace GOFExample
{
    public class GameArchitecture:Architecture<GameArchitecture>
    {
        protected override void Init()
        {
            RegisterSystem<IStateSystem>(new StateSystem());
        }
    }
}