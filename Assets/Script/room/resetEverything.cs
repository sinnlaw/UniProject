	using UnityEngine;
using System.Collections;

public class resetEverything : MonoBehaviour {

    public bool clean = true;

    //buttons
    public GameObject createButton;
    public GameObject cleanButton;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
        //change button
        if(clean == true)
        {
            createButton.SetActive(true);
            cleanButton.SetActive(false); 
        }
        else
        {
            createButton.SetActive(false);
            cleanButton.SetActive(true);
        }

        if (clean == true)
        {
            Destroy(GameObject.FindWithTag("Player"));
            Destroy(GameObject.FindWithTag("Exit"));
        }

    }

    public void onClick()
    {
        clean = true;
        GameObject[] destoryObject = GameObject.FindGameObjectsWithTag("Room");
        foreach (GameObject destoyObj in destoryObject)
        {
            Destroy(destoyObj);
        }
    }

}
