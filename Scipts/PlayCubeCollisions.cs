using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCubeCollisions : MonoBehaviour
{

    public CubePlayMovement movement;


    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "HitObject")
        {

            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
