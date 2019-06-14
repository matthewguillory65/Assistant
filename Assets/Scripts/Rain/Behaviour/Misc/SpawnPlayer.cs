using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour {
    public GameObject player;
    public Transform spawn;

	// Use this for initialization
	void Start ()
    {
        Instantiate(player, spawn.position, Quaternion.identity);
	}
}
