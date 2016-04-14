using UnityEngine;
using System.Collections;

public class randomSquare : MonoBehaviour {
    
    //Spawn numnber of square
    public int numberSquare = 2;
    //Square GameObject
    public GameObject squareObject;
    //Square pos X & Y
    private Vector2 squarePos;
    private float squarePosX;
    private float squarePosY;
    //Square size X & Y
    private Vector2 squareScale;
    private float squareX;
    private float squareY;
    //set seed
    public GetSeedNumber getSeedNumberCS;
    public int seed;
    //cleaning the dungeon
    public resetEverything restCS;
    //spawn circle size
    public float spawnCircleSize = 10.0f;
    //spawn square size
    public float maxSizeSqure = 6.0f;

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {
        seed = getSeedNumberCS.seedNumber;
        Random.seed = seed;
    }

    public void onClick()
    {
        restCS.clean = false;
        //create seed & saving seed
        Vector3 center = transform.position;
        for (int i = 0; i < numberSquare; i++)
        {
            Vector3 pos = RandomCircle(center, spawnCircleSize);
            createSquare();
            squareObject.name = "Room" + i;
            Instantiate(squareObject, pos, Quaternion.identity);
        }
    }

    void createSquare ()
    {
        //setUp the Random Pos X & Y
        squarePosX = 0;
        squarePosY = 0;
        //setUp the Random size X & Y
        squareX = Random.Range(4.0f, 7.0f);
        squareY = Random.Range(4.0f, 7.0f);
        //Create the Object
        squarePos = new Vector2(squarePosX, squarePosY);
        squareScale = new Vector2(squareX, squareY);
        squareObject.transform.localScale = squareScale;

    }

    Vector3 RandomCircle(Vector3 center, float radius)
    {
        float ang = Random.value * 360;
        Vector3 pos;
        pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        pos.y = center.y + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        pos.z = -0.1f;
        return pos;
    }
}
