using UnityEngine;
using System.Collections;

public class SwitchScene : MonoBehaviour {
	
	void Start () {
	}

	void Update () {
	
	}

	public void ToScene(string scene) {
		Application.LoadLevel(scene);
		Debug.Log("Tried to change levels");
	}
}
