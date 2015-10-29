using UnityEngine;
using System.Collections;

public class TimedDeath : MonoBehaviour {

	public float deathTime;

	private float time;

	void Start () {
		time = 0;
	}

	void Update () {
		time += Time.deltaTime;

		if(time >= deathTime)
		{
			Destroy(gameObject);
		}
	}
}
