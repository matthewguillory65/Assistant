using UnityEngine;

namespace Rain.Behaviour
{
    public class PlayerMovement : MonoBehaviour
    {
        private Rigidbody rgbd;
        public float speed;
        // Use this for initialization
        void Start()
        {
            rgbd = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(0, 0, moveVertical);
            transform.Rotate(0, moveHorizontal, 0);
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += transform.forward * Time.deltaTime * speed;
            }

        }
    }
}
