using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GetSeedNumber : MonoBehaviour {

    public InputField nameField;
    public string setSeed;
    public int seedNumber;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
    }

    public void getSeedNumber(string getSeed)
    {
        setSeed = getSeed;
        int.TryParse(setSeed, out seedNumber);
    }

}
