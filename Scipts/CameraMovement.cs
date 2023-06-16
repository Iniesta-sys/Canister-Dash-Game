using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float movementSpeed = 1f; // Rychlost pohybu kamery
    public float returnSpeed = 1f; // Rychlost návratu kamery zpìt
    public float returnPositionZ = 40f; // Z-ová pozice, kde se kamera zaène vracet

    private bool isMovingForward = true; // Pøíznak, zda se kamera pohybuje vpøed

    void Update()
    {
        if (isMovingForward)
        {
            transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);

            if (transform.position.z >= returnPositionZ)
            {
                isMovingForward = false;
            }
        }
        else
        {
            transform.Translate(Vector3.back * returnSpeed * Time.deltaTime);

            if (transform.position.z <= 0f)
            {
                isMovingForward = true;
            }
        }
    }
}