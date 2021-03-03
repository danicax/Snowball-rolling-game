using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.UpArrow))
			transform.Translate(Vector3.forward *2* Time.deltaTime);
		if (Input.GetKey(KeyCode.DownArrow))
			transform.Translate(Vector3.back *2* Time.deltaTime);
		if (Input.GetKey(KeyCode.LeftArrow))
			transform.Translate(Vector3.left *2* Time.deltaTime);
		if (Input.GetKey(KeyCode.RightArrow))
			transform.Translate(Vector3.right *2* Time.deltaTime);
	}
}
