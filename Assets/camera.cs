using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {
	public GameObject player;
	private Vector3 offset;
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(gameObject);
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.LeftArrow))
			transform.Rotate(Vector3.down * 40 * Time.deltaTime);
		if (Input.GetKey(KeyCode.DownArrow))
			transform.Rotate(Vector3.right * 40 * Time.deltaTime);
		if (Input.GetKey(KeyCode.UpArrow))
			transform.Rotate(Vector3.left * 40 * Time.deltaTime);
		if (Input.GetKey(KeyCode.RightArrow))
			transform.Rotate(Vector3.up * 40 * Time.deltaTime);
	}
	void LateUpdate () {
		transform.position = player.transform.position + offset;    
	}
}
