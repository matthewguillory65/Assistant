using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Rain.Behaviour
{
    public class BulletScript : MonoBehaviour
    {
        public GameObject bullet;
        public Transform player;
        public static int numberofBullets = 20;
        public Text counter;
        float destructionTimer = 6;
        float timer = 0;
        public Transform spawn;
        // Use this for initialization
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            counter.text = "Ammo: " + numberofBullets.ToString();
            bullet.transform.forward = transform.forward;
            Shoot();
            Reload();

        }

        public void Shoot()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (numberofBullets > 0)
                {
                    GameObject bull = Instantiate(bullet, spawn.position, Quaternion.identity) as GameObject;
                    Rigidbody instBulletRigidbody = bull.GetComponent<Rigidbody>();
                    instBulletRigidbody.AddForce(Vector3.forward * 5000);
                    --numberofBullets;
                }
            }
        }

        public void Reload()
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                if (numberofBullets < 20)
                {
                    numberofBullets += (20 - numberofBullets);
                }
            }
        }
    }
}

