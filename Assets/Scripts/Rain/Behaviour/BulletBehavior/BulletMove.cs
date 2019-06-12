using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rain.Behaviour
{
    public class BulletMove : MonoBehaviour
    {
        public GameObject bullet;
        // Use this for initialization
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            transform.Translate(transform.forward);
            Destroy(bullet, 4);
        }
    }
}


