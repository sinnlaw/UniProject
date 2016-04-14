using UnityEngine;
using System.Collections;

public class createHallway : MonoBehaviour {

    public randomSquare randomSquareCS;

    //Room number
    int a = 0;
    int b = 0;
    //create random number 
    int RanNumber = 0;
    //Store Room A & Room B
    public GameObject RoomA;
    public GameObject RoomB;
    //Store the hallyway perfab
    public GameObject hallywayGameObject;
    //spawn hallway position
    private Vector2 middlePos;

    public int maxRoom;
    public int n;

	// Use this for initialization
	void Start ()  {    }
	// Update is called once per frame
	void Update () {    }

    public void onClick()
    {
        //create random number
        RanNumber = Random.Range(0, 2);
        maxRoom = randomSquareCS.numberSquare;

        for (n = 0; n < maxRoom; n = n + 1)
        {
            //set a & b to a number
            a = n;
            b = n + 1;

            //get large room
            getLargeRoom();

            //Create main hallway
            getMiddlePoint();
            createHall();
            Instantiate(hallywayGameObject, middlePos, Quaternion.identity);
        }
    }

    //get the lagre room number
    void getLargeRoom()
    {
        RoomA = GameObject.Find("Room" + a + "(Clone)");
        RoomB = GameObject.Find("Room" + b + "(Clone)");
    }

    void getMiddlePoint()
    {
        
        //Middle position
        float middlePosX = RoomA.transform.position.x;
        float middlePosY = RoomB.transform.position.y;

        //find the middle point position
        if (RanNumber == 0)
        {
            middlePosX = RoomA.transform.position.x;
            middlePosY = RoomB.transform.position.y;
        }
        else
        {
            middlePosY = RoomA.transform.position.y;
            middlePosX = RoomB.transform.position.x;
        }

        //setup the middle point position
        middlePos = new Vector2(middlePosX, middlePosY);
    }

    void createHall()
    {
        Vector2 currentPos = new Vector2(0,0);
        float currentX = 0;
        float currentY = 0;

        //check on where is the hallway and spawn the remin hall
        //this is X only
        if (middlePos.y == RoomA.transform.position.y)
        {
            //From right to left
            if(middlePos.x > RoomA.transform.position.x)
            {
                for(currentX = middlePos.x; currentX > RoomA.transform.position.x; currentX = currentX - 1)
                {
                    currentPos = new Vector2(currentX, middlePos.y);
                    Instantiate(hallywayGameObject, currentPos, Quaternion.identity);
                }
                print("01");
            }
            //From left to right
            else if(middlePos.x < RoomA.transform.position.x)
            {
                for (currentX = middlePos.x; currentX < RoomA.transform.position.x; currentX = currentX + 1)
                {
                    currentPos = new Vector2(currentX, middlePos.y);
                    Instantiate(hallywayGameObject, currentPos, Quaternion.identity);
                }
                print("02");
            }
        }
        else if(middlePos.y == RoomB.transform.position.y)
        {
            //From right to left
            if (middlePos.x > RoomB.transform.position.x)
            {
                for (currentX = middlePos.x; currentX > RoomB.transform.position.x; currentX = currentX - 1)
                {
                    currentPos = new Vector2(currentX, middlePos.y);
                    Instantiate(hallywayGameObject, currentPos, Quaternion.identity);
                }
                print("03");
            }
            //From left to right
            else if (middlePos.x < RoomB.transform.position.x)
            {
                for (currentX = middlePos.x; currentX < RoomB.transform.position.x; currentX = currentX + 1)
                {
                    currentPos = new Vector2(currentX, middlePos.y);
                    Instantiate(hallywayGameObject, currentPos, Quaternion.identity);
                }
                print("05");
            }
        }
        else
        {
            print("ERROR ON HALL");
        }

        //check on where is the hallway and spawn the remin hall
        //this is y only
        if (middlePos.x == RoomA.transform.position.x)
        {
            //From up to down
            if (middlePos.y > RoomA.transform.position.y)
            {
                for (currentY = middlePos.y; currentY > RoomA.transform.position.y; currentY = currentY - 1)
                {
                    currentPos = new Vector2(middlePos.x, currentY);
                    Instantiate(hallywayGameObject, currentPos, Quaternion.identity);
                }
                print("05");
            }
            //From left to right
            else if (middlePos.y < RoomA.transform.position.y)
            {
                for (currentY = middlePos.y; currentY < RoomA.transform.position.y; currentY = currentY + 1)
                {
                    currentPos = new Vector2(middlePos.x, currentY);
                    Instantiate(hallywayGameObject, currentPos, Quaternion.identity);
                }
                print("06");
            }
        }
        else if (middlePos.x == RoomB.transform.position.x)
        {
            //From up to down
            if (middlePos.y > RoomB.transform.position.y)
            {
                for (currentY = middlePos.y; currentY > RoomB.transform.position.y; currentY = currentY - 1)
                {
                    currentPos = new Vector2(middlePos.x, currentY);
                    Instantiate(hallywayGameObject, currentPos, Quaternion.identity);
                }
                print("07");
            }
            //From left to right
            else if (middlePos.y < RoomB.transform.position.y)
            {
                for (currentY = middlePos.y; currentY < RoomB.transform.position.y; currentY = currentY + 1)
                {
                    currentPos = new Vector2(middlePos.x, currentY);
                    Instantiate(hallywayGameObject, currentPos, Quaternion.identity);
                }
                print("08");
            }
        }

        }

}
