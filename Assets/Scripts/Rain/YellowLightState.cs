﻿namespace Assets.Scripts.Rain
{
    public class YellowLightState : IState
    {

        public YellowLightState(float seconds)
        {

        }
        public void OnEnter(IContext context)
        {
            //For the yellow light, I need a timer that lasts
            //at least 1 seconds.
            throw new System.NotImplementedException();
        }
        public void OnExit(IContext context)
        {
            //Do anything here that needs to be done on the
            //exit of the state.
            throw new System.NotImplementedException();
        }
        public void UpdateState(IContext context)
        {
            //Change states here.
            throw new System.NotImplementedException();
        }
    }
}


