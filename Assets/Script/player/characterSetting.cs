using UnityEngine;
using System.Collections;

public class characterSetting : MonoBehaviour {

	private Rigidbody2D rigidbody2D;

	//player movement
	public float Speed = 10.0f;
	public float movex = 0f;
	public float movey = 0f;

	// Use this for initialization
	void Start () {
		rigidbody2D = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Update is called once per frame
	void FixedUpdate () {
		movex = Input.GetAxis ("Horizontal");
		movey = Input.GetAxis ("Vertical");
		rigidbody2D.velocity = new Vector2 (movex * Speed, movey * Speed);
	}


}
