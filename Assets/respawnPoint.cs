using UnityEngine;
using System.Collections;

public class respawnPoint : MonoBehaviour
{
    // variables
    public GameObject player;
    public Vector3 pos; 


	// Use this for initialization
	void Start ()
    {
        // assign reference
        player = GameObject.Find("FPSController");
	}
	
	// Update is called once per frame
	void Update ()
    {
	    // 
        if(player.transform.position.y < -100f)
        {
            // you have fallen and died
            player.transform.position = pos;
        }
	}
}
