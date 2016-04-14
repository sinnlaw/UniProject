using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class silder : MonoBehaviour {

    //change dungeon size
    public randomSquare randomSquareCS;
    public float circleSize;

    //change number of room
    public int numOfRoomInt;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
    }

    //change the dungeon size
    public void changeSize(float sizeValue)
    {
        circleSize = sizeValue;
        randomSquareCS.spawnCircleSize = circleSize;
    }

    public void numbersofRooms(float numOfRoom)
    {
        numOfRoomInt = (int)numOfRoom;
        randomSquareCS.numberSquare = numOfRoomInt;
    }

}
