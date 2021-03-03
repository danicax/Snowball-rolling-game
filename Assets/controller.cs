using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            transform.Rotate(Vector3.right * 30 * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
            transform.Rotate(Vector3.left * 30 * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.forward * 30 * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.back * 30 * Time.deltaTime);
    }
}
