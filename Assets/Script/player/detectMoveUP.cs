using UnityEngine;
using System.Collections;

public class detectMoveUP : MonoBehaviour {

	public characterSetting charSetCS;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//checking Up
	void OnCollisionEnter(Collider2D coll)
	{
		if (coll.gameObject.tag == "Room") {
			print ("Up");
		}
	}

}
