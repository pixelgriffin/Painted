using UnityEngine;
using System.Collections;

public class OnPlayerCollides : MonoBehaviour {

	public string nextScene;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col) {
		if(col.name == "FPSController")
		{
			Application.LoadLevel(nextScene);
		}
	}
}
