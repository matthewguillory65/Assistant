using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TestTurret : MonoBehaviour
{
    RaycastHit hit;
    public float lookRadius = 10f;
    NavMeshAgent agent;
    Transform target;
    float maxRange = 6f;
    public GameObject left, right;
    // Use this for initialization
    void Start()
    {
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        //bool inRange = Vector3.Distance(target.transform.position, transform.position) <= Vector3.Distance(ClosestPointCollider.closestpoint, left.transform.position) && Vector3.Distance(transform.position, target.position) > 2;
        var inFront = Vector2.Dot(transform.position, target.forward) < 0;
        if (inFront)
        {
            if(!Physics.Raycast(transform.position, new Vector3(left.transform.position.x, 0, left.transform.position.x), out hit, 8)
                && !Physics.Raycast(transform.position, new Vector3(right.transform.position.x, 0, right.transform.position.x), out hit, 8))
            {
                agent.SetDestination(target.position);
            }
        }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
