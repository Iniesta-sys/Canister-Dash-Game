using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePlayMovement : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(0, 0, 200);
    }

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float jumpForce = 700f;
    private bool canJump = true;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            rb.AddForce(0, jumpForce, 0, ForceMode.Impulse);
            canJump = false;
            StartCoroutine(EnableJump());
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    IEnumerator EnableJump()
    {
        yield return new WaitForSeconds(2f);
        canJump = true;
    }
}