namespace GOFExample.状态模式.QFramework版
{
    public interface  IState
    {
       StateSystem Content { get; set; }

       void Handle(int value);
    }
}