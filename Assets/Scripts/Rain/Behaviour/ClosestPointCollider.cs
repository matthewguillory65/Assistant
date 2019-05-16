using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rain.Behaviour
{
    public class ClosestPointCollider : MonoBehaviour
    {
        public Vector3 location;
        public new Collider collider;
        public static Vector3 closestpoint;
        void Start()
        {
            collider = GetComponent<Collider>();
        }

        void Update()
        {
            closestpoint = collider.ClosestPoint(location);
        }

    }
}


