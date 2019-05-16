namespace Chu
{
    public abstract class Context : IContext
    {
        public abstract void ResetContext();
        public abstract IState CurrentState { get; }
        public abstract void UpdateContext();
        public abstract void ChangeState(IState next);
    }
}