using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public Rigidbody rb;
    float jumpForce = 2500f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "JumpPlatform")
        {
            rb.AddForce(Vector3.up * jumpForce);
            Debug.Log("hit");
        }
    }
}
