using Assets.Scripts.Rain;
using UnityEngine;

namespace Chu
{
    public class TrafficLight_Context : IContext
    {
        public TrafficLight_Context(TrafficLight_StateMachineBehaviour behaviour)
        {
            CurrentState = new InitLightState();
            StateMachineBehaviour = behaviour;
            CurrentState.OnEnter(this);
        }

        public TrafficLight_StateMachineBehaviour StateMachineBehaviour
        { get; private set; }

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
                Debug.Log("Enter the InitState");
                var trafficContext = context as TrafficLight_Context;
                var smBehaviour = trafficContext.StateMachineBehaviour;
                smBehaviour.GetComponent<MeshRenderer>().enabled = true;
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