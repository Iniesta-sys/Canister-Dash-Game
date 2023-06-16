using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float moveRange = 5f;

    private bool moveForward = true;
    private float initialZ;

    private void Start()
    {
        initialZ = transform.position.z;
    }

    private void Update()
    {
        if (moveForward)
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }

        // Check if the object has reached the forward boundary
        if (transform.position.z >= initialZ + moveRange)
        {
            moveForward = false;
          
        }
        // Check if the object has reached the backward boundary
        else if (transform.position.z <= initialZ - moveRange)
        {
            moveForward = true;
           
        }
    }

 
}