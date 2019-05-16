using UnityEngine;

namespace Chu
{
    public class TrafficLight_StateMachineBehaviour : MonoBehaviour
    {
        private IContext context;

        private void Awake()
        {
            context = new TrafficLight_Context(this);
        }

        private void Update()
        {
            context.UpdateContext();
        }
    }
}
