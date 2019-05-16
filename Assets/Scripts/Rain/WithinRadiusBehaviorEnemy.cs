using UnityEngine;

public class WithinRadiusBehaviorEnemy : MonoBehaviour {

    public GameObject target;
    public int minRange, maxRange;
    private Vector3 targetTran;
    // Use this for initialization
    void Start()
    {
        target = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        targetTran = target.transform.position;
        if (Vector3.Distance(transform.position, targetTran) < maxRange && Vector3.Distance(transform.position, targetTran) > minRange)
        {
            transform.LookAt(targetTran);
            transform.Translate(Vector3.forward * Time.deltaTime);
        }
    }
}
