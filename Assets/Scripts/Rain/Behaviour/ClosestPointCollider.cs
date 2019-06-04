﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rain.Behaviour
{
    public class ClosestPointCollider : MonoBehaviour
    {
        public static Vector3 closestpoint;
        GameObject closestgameobj;
        void Start()
        {
            
        }

        void Update()
        {

        }
        void OnTriggerEnter(Collider coll)
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
            var closercollider = Vector3.Distance(closestpoint, transform.position);
            var closerplayer = Vector3.Distance(player.transform.position, transform.position);
            if (closerplayer < closercollider)
            {
                Debug.Log("Is working");
                IsItTho = true;
            }
            else
            {
                Debug.Log("No working");
                IsItTho = false;
            }

            return IsItTho;
        }
    }
}


