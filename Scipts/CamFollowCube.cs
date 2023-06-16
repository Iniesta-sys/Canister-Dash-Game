using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowCube : MonoBehaviour
{

    public Transform player;
    public Vector3 offsets;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offsets;
    }
}
