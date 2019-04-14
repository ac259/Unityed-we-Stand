using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float defaultForwardForce = 2000f;
    public float forwardForce = 500f;
    public float sideWayForce = 500f;
  
    // FixedUpdate is used when we use physics - adding forces and velocities.
    void FixedUpdate()
    {
        // Add a forward force
        rb.AddForce(defaultForwardForce*Time.deltaTime, 0, 0);

        // Used to add movement!
        if( Input.GetKey("w"))
        {
            rb.AddForce(forwardForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(-forwardForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            // we add forcemode to make sure that when we make a turn / change in direction
            // then we don't have to wait for the object to build momentum
            rb.AddForce(0,0,sideWayForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(0, 0, -sideWayForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
