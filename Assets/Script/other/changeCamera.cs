using UnityEngine;
using System.Collections;

public class changeCamera : MonoBehaviour {

	//setup camera to GameObject
	public GameObject playerCamera;
	public GameObject fullCamera;

	//check is player choose to use player Camera
	private bool isPlayerCamera = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//player camera is true world camera is false
		if (isPlayerCamera == true) {
			playerCamera.SetActive (true);
			fullCamera.SetActive (false);
		} else {
			playerCamera.SetActive (false);
			fullCamera.SetActive (true);
		}
	}

	//player camera is true world camera is false
	public void toggleCamera(bool chooseCamera)
	{
		isPlayerCamera = chooseCamera;
	}

}
