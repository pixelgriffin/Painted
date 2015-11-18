using UnityEngine;
using System.Collections;

public class LoopingMusic : MonoBehaviour {

	private static LoopingMusic inst = null;

	public static LoopingMusic Instance {
		get { return inst; }
	}

	void Awake() {
		if(inst != null && inst != this) {
			Destroy (this.gameObject);
			return;
		} else {
			inst = this;
		}

		this.GetComponent<AudioSource>().loop = true;
		this.GetComponent<AudioSource>().Play();
		DontDestroyOnLoad(this.gameObject);
	}
}
