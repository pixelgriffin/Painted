using UnityEngine;
using System.Collections;

public class TimedText : MonoBehaviour {

	private float time;

	private CanvasRenderer group;

	public float fadeAfter = 2;
	public float speedup = 1;

	void Start () {
		group = this.GetComponent<CanvasRenderer>();

		time = 0;
	}

	void Update () {
		time += Time.deltaTime;

		if(time >= fadeAfter)
		{
			//change alpha
			group.SetAlpha(group.GetAlpha() - (Time.deltaTime * speedup));
			if(group.GetAlpha() < 0)
				group.SetAlpha(0);
		}
	}
}
