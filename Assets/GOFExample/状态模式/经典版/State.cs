namespace GOFExample.状态模式
{
    /// <summary>
    ///  能够被继承的状态类
    /// </summary>
    public abstract class State
    {
        protected Context m_Content;

        protected State(Context content)
        {
            m_Content = content;
        }

       public abstract void Handle(int value);
    }
}