namespace Chu
{
    public class TrafficLight_Context  :IContext
    {
        public void ResetContext()
        {
            CurrentState = new InitLightState();
        }

        public IState CurrentState { get; private set; }

        public void UpdateContext()
        {
            CurrentState.UpdateState(this);
        }

        public void ChangeState(IState next)
        {
            CurrentState.OnExit(this);
            CurrentState = next;
            CurrentState.OnEnter(this);
        }

        public class InitLightState : IState
        {
            public void OnEnter(IContext context)
            {
            }

            public void UpdateState(IContext context)
            {
            }

            public void OnExit(IContext context)
            {
            }
        }
    }
}