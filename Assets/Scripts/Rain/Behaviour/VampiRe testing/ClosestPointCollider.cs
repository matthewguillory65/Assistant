using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rain.Behaviour
{
    public class ClosestPointCollider : MonoBehaviour
    {
        public static Vector3 closestpoint;
        public GameObject closestgameobj;
        public GameObject guard;
        void Start()
        {
            
        }

        void Update()
        {

        }
        void OnCollisionEnter(Collision coll)
        {
            if (coll.gameObject.CompareTag("HideAble"))
            {
                closestgameobj = coll.gameObject;
                Debug.Log("Something hit");
                closestpoint = closestgameobj.transform.position;
            }
        }

        public bool WhosCloser(GameObject player)
        {
            bool IsItTho = false;
            var closercollider = Vector3.Distance(closestpoint, guard.transform.position);
            var closerplayer = Vector3.Distance(player.transform.position, guard.transform.position);
            if (closerplayer < closercollider)
            {
                Debug.Log("I see you!");
                IsItTho = true;
            }
            else if(closerplayer > closercollider)
            {
                Debug.Log("Who's there");
                IsItTho = false;
            }

            return IsItTho;
        }
    }
}


