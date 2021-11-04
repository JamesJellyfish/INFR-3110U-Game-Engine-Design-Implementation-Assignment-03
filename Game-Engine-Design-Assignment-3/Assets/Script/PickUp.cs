using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform thePickUp;

    //Pick Up
    void OnMouseDown()
    {
       //Turn off gravity of Rigidbody
       GetComponent<Rigidbody>().useGravity = false;
       //Pick up the obj to Emty game object call Pick
       this.transform.position = thePickUp.position;
       this.transform.parent = GameObject.Find("Pick").transform;
              
    }

    //Release
    void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;

    }
}
//Pick Up code is from https://www.youtube.com/watch?v=IEV64CLZra8