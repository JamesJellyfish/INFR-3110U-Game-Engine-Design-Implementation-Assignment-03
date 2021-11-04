using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody rb;
    private float movespeed;
    private float dirX, dirZ;

    void Start()
    {
        movespeed = 10f;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        dirX = Input.GetAxis("Horizontal") * movespeed;
        dirZ = Input.GetAxis("Vertical") * movespeed;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(dirX, rb.velocity.y, dirZ);
    }
}
