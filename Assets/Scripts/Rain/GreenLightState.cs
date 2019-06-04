namespace Assets.Scripts.Rain
{
    public class GreenLightState : IState
    {
        YellowLightState yellow;
        public GreenLightState(float seconds)
        {

        }

        public void OnEnter(IContext context)
        {
            //For the green light, I need a timer that lasts
            //at least 1 seconds.

        }
        public void OnExit(IContext context)
        {
            //Do anything here that needs to be done on the
            //exit of the state.

        }
        public void UpdateState(IContext context)
        {
            //Change states here.
            context.ChangeState(yellow);
        }
    }
}