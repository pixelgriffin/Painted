using UnityEngine;
using System.Collections;

public class ScreenLook : MonoBehaviour {




	// Use this for initialization
	void Start () {
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Cursor.visible = true;
			Application.Quit();
		}
	}
}
