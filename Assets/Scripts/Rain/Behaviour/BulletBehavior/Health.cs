using UnityEngine;
using UnityEngine.UI;

namespace Rain.Behaviour
{
    public class Health : MonoBehaviour
    {
        public int health;
        public Text counter;
        GameObject currentGameObject;
        // Use this for initialization
        void Start ()
        {
            health = 100;
            currentGameObject = GetComponent<GameObject>();
        }
	
        // Update is called once per frame
        void Update ()
        {
            if(gameObject.tag == "Player")
            {
                counter.text = "Player Health: " + health;
            }

            if(health <= 0)
            {
                Destroy(gameObject);
            }
        }

        void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Bullet"))
            {
                health = health - 10;
                Destroy(other.gameObject);
            }
        }
    }
}
