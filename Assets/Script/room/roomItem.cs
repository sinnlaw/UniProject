using UnityEngine;
using System.Collections;

public class roomItem : MonoBehaviour {

    public resetEverything resetCS;

    //set character & exit look
    public GameObject characterObj;
    public GameObject exitObj;

    //choose start & end room
    public randomSquare randomSquareCS;
    public int startRoomNum;
    public int endRoomNum;

    //seleted Room 
    public GameObject startRoom;
    public GameObject endRoom;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (resetCS.clean == true) {
			startRoomNum = 0;
			endRoomNum = 0;
		}

        if(resetCS.clean == false)
        {
            //start room number
            startRoomNum = Random.Range(0, randomSquareCS.numberSquare);
            //end room number
            endRoomNum = Random.Range(0, randomSquareCS.numberSquare);

			if (startRoomNum == endRoomNum) {
				endRoomNum = Random.Range(0, randomSquareCS.numberSquare) + 1;
			}
			if (endRoomNum > randomSquareCS.numberSquare) {
				endRoomNum = Random.Range (0, randomSquareCS.numberSquare);
				endRoomNum = endRoomNum - 1;
			}


            //spawn player at the starting room
            if(GameObject.Find("Player(Clone)") == null)
            {
                startRoom = GameObject.Find("Room" + startRoomNum + "(Clone)");
                Instantiate(characterObj, startRoom.transform.position, Quaternion.identity);
            }

            //spawn exit at the ending room
            if (GameObject.Find("Exit(Clone)") == null)
            {
                endRoom = GameObject.Find("Room" + endRoomNum + "(Clone)");
                Instantiate(exitObj, endRoom.transform.position, Quaternion.identity);
            }

        }

    }


}
