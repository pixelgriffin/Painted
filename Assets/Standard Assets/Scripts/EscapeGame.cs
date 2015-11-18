using UnityEngine;
using System.Collections;

public class EscapeGame : MonoBehaviour {
	
	void Start () {
	
	}

	void Update () {
		if(Input.GetKeyUp(KeyCode.Escape))
		{
			Application.Quit();
		}
	}
}
