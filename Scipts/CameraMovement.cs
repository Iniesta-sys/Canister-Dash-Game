using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float movementSpeed = 1f; // Rychlost pohybu kamery
    public float returnSpeed = 1f; // Rychlost n�vratu kamery zp�t
    public float returnPositionZ = 40f; // Z-ov� pozice, kde se kamera za�ne vracet

    private bool isMovingForward = true; // P��znak, zda se kamera pohybuje vp�ed

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