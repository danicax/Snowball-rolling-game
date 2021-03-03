using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class Ball : MonoBehaviour {
	int count = 1;
	private int score;
	public float threshold;
	public Text scoreText, HelpText;
	public Camera overheadCamera;
	public Camera firstPersonCamera;
	public GameObject platform;
	public Rigidbody rb;
	public Renderer renderer;
	public Material normal, glass;
	// Use this for initialization
	void Start () {
		score = 0;
		SetScoreText ();
		DontDestroyOnLoad(gameObject);
		Init ();
	}

	void Init() {
		if(platform == null)
			platform = GameObject.FindWithTag ("Platform");
		if(overheadCamera == null)
			overheadCamera = GameObject.FindWithTag ("OverheadCamera").GetComponent<Camera>();
		firstPersonCamera.enabled = false;
		overheadCamera.enabled = true;
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKeyDown (KeyCode.Space)) 
			SwitchCam ();
		if(platform == null)
			platform = GameObject.FindWithTag ("Platform");
		if (transform.position.y < threshold) {
			platform.transform.position = new Vector3 (7.119999f, -0.1407015f, 5.63f);
			platform.transform.rotation = Quaternion.Euler (0, 0, 0);
			transform.position = new Vector3 (-1.54f, 10.48f, -3.17f);
		}
	}

	void SwitchCam(){
		if(platform == null)
			platform = GameObject.FindWithTag ("Platform");
		if(overheadCamera == null)
			overheadCamera = GameObject.FindWithTag ("OverheadCamera").GetComponent<Camera>();
		firstPersonCamera.enabled = !firstPersonCamera.enabled;
		overheadCamera.enabled = !overheadCamera.enabled;
	}

	private void OnCollisionStay(Collision collision)
	{
		if (collision.gameObject.tag == "EndPlatform")
		{
			count++;
			Application.LoadLevel("Level" + count);
			if (count == 2) {
				HelpText.text = "Hit the bumpy ice to jump.";
			}
			else if (count == 3) {
				HelpText.text = "Use space to swap camera modes \tand use arrow keys to rotate the camera.";
			}
			else if (count == 4) {
				HelpText.text = "Good luck!";
			}
			else if (count == 5) {
				HelpText.text = "Everythings gone icy!";
				renderer.material = glass;
			}
			else if (count == 6) {
				HelpText.text = "You win!";
				Destroy (gameObject);
				if (score == 10) {
					scoreText.text = "High score!";
				}
			}
			rb.velocity = Vector3.zero;
			Init ();
			transform.position = new Vector3(-1.54f, 0.48f, -3.17f);
		}
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Pick Up")) {
			other.gameObject.SetActive (false);
			score++;
			SetScoreText ();
		}
	}

	void SetScoreText (){
		scoreText.text = "Score: " + score.ToString ();
	}
}
