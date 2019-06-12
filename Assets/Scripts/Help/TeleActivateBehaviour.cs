using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This behaviour should teleport an object from its current position in Unity to the one 
/// specified by you in the Inspecter
/// </summary>
public class TeleActivateBehaviour : MonoBehaviour {

    /// <summary>
    /// If this is true, then the teleport activates
    /// </summary>
    [SerializeField]
    public bool isActive;
    [SerializeField]
    public bool isReverseActive;
    /// <summary>
    /// These 3 numbers decide the new location of the object in question.
    /// </summary>
    [SerializeField]
    private float xCoor, yCoor, zCoor;


    // Update is called once per frame
    void Update ()
    {
		if (isActive == true)
        {
            ///This is the function activation that takes in your input for the coordinates.
            Teleport(transform, xCoor, yCoor, zCoor);
            isActive = false;
        }
        if(isReverseActive == true)
        {
            Teleport(transform, -xCoor, -yCoor, -zCoor);
            isReverseActive = false;
        }
        
        if(isActive == false)
        {
            Debug.Log("Am false");
        }
	}
    public void Teleport(Transform gameObj, float xCoor, float yCoor, float zCoor)
    {
        ///This simply changes each coordinate of the game object into the new location for it 
        ///decided by the inputs above.
        gameObj.position += new Vector3(xCoor, yCoor, zCoor);
    }
}
