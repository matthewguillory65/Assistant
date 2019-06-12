using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Rain.Behaviour
{
    public class BulletScript : MonoBehaviour
    {
        public GameObject bullet;
        public static int numberofBullets = 20;
        public Text counter;
        float destructionTimer = 6;
        float timer = 0;
        Health health;
        // Use this for initialization
        void Start()
        {
            health = GetComponent<Health>();
        }

        // Update is called once per frame
        void Update()
        {
            counter.text = "Ammo: " + numberofBullets.ToString();
            Shoot();
            Reload();

        }

        public void Shoot()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (numberofBullets > 0)
                {
                    Instantiate(bullet, transform.position, Quaternion.identity);
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

