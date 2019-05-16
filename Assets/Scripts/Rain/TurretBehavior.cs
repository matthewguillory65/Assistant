using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretBehavior : MonoBehaviour
{
    public float maxRange, minRange;
    //public float howClose;
    public Vector3 targetTran;
    public GameObject player;
    bool inRange;
    LayerMask layermask = -1;
    RaycastHit hit;
    public Vector3 location;
    public new BoxCollider collider;
    
    public GameObject line1, line2;
    void Start()
    {
        collider = GetComponent<BoxCollider>();
    }
    void Update()
    {
        Vector3 closestPoint = collider.ClosestPoint(location);
        targetTran = player.transform.position;
        inRange = Vector3.Distance(transform.position, targetTran) < maxRange && Vector3.Distance(transform.position, targetTran) > minRange;
        var inFront = Vector2.Dot(player.transform.forward, transform.forward) < 0;
        if (inRange && Vector3.Distance(player.transform.position, transform.position) < Vector3.Distance(closestPoint, transform.position))
        {
            transform.LookAt(targetTran);
            if (!Physics.Raycast(transform.position, new Vector3(line1.transform.position.x, 0, line1.transform.position.x), out hit, 8)
                && !Physics.Raycast(transform.position, new Vector3(line2.transform.position.x, 0, line2.transform.position.x), out hit, 8))
            {
                transform.Translate(Vector3.forward * Time.deltaTime);
                Debug.Log("hit");
            }
        }
        Debug.DrawLine(transform.position, line1.transform.position, Color.black);
        Debug.DrawLine(transform.position, line2.transform.position, Color.black);


        if(Physics.Raycast(transform.position, Vector3.forward, out hit, layermask))
        {
            Debug.Log("Hits fine");
        }
    }
}
