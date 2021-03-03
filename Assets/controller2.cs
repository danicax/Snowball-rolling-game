using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller2 : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey(KeyCode.UpArrow))
			transform.Rotate(Vector3.right * 30 * Time.deltaTime);
		if (Input.GetKey(KeyCode.DownArrow))
			transform.Rotate(Vector3.left * 30 * Time.deltaTime);
		if (Input.GetKey(KeyCode.LeftArrow))
			transform.Rotate(Vector3.forward * 30 * Time.deltaTime);
		if (Input.GetKey(KeyCode.RightArrow))
			transform.Rotate(Vector3.back * 30 * Time.deltaTime);
	}
}
