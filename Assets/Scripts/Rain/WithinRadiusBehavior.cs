using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithinRadiusBehavior : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player;
    public int minRange, maxRange;
    private Vector3 targetTran;
    // Use this for initialization
    void Start()
    {
        enemy = GameObject.FindWithTag("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        targetTran = enemy.transform.position;
        if(Vector3.Distance(player.transform.position, targetTran) < maxRange && Vector3.Distance(player.transform.position, targetTran) > minRange)
        {
            transform.LookAt(targetTran);
            transform.Translate(Vector3.forward * Time.deltaTime);
        }
    }
}
