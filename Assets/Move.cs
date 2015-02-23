using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	// Movement keys (customizable in inspector)
	public KeyCode upKey;
	public KeyCode downKey;
	public KeyCode rightKey;
	public KeyCode leftKey;

	// Movement Speed
	public float speed = 16;

	// Use this for initialization
	void Start () {
		// Initial Movement Direction
		GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
	}
	
	// Update is called once per frame
	void Update () {
		// Check for key presses
		if (Input.GetKeyDown (upKey)) {
			GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
		} else if (Input.GetKeyDown (downKey)) {
			GetComponent<Rigidbody2D>().velocity = -Vector2.up * speed;
		} else if (Input.GetKeyDown (rightKey)) {
			GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
		} else if (Input.GetKeyDown (leftKey)) {
			GetComponent<Rigidbody2D>().velocity = -Vector2.right * speed;
		}
	}
}
