using UnityEngine;
using System.Collections;

public class BlobCreator : MonoBehaviour {

	public int maxBlobs = 100;

	public GameObject bloob;

	private float lastX;
	private float lastZ;

	private float time;

	private ArrayList blobs;


	void Start () {
		lastX = gameObject.transform.position.x;
		lastZ = gameObject.transform.position.z;

		blobs = new ArrayList();

		time = 0;
	}

	void Update () {
		//shooting
		time += Time.deltaTime;

		if(Input.GetMouseButton(0))
		{
			if(time > 0.015)
			{
				time = 0;
				RaycastHit hit;

				if(Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, 15))
				{
					Vector3 cp = hit.point;
					cp.y += 10;

                    GameObject tempCube = GameObject.Find(hit.collider.gameObject.name);
                    GameObject tempProject = (GameObject)Instantiate(bloob, cp, Quaternion.Euler(new Vector3(90, 0, 0)));

					blobs.Add(tempProject);

					int i = 0;
					while(blobs.Count > maxBlobs)
					{
						if(blobs[i] != null)
						{
							Destroy(blobs[i] as GameObject);
							blobs.RemoveAt(i);
						}
						i++;
					}


                    if (hit.collider.gameObject.tag == "cube")
                    {
                        tempProject.transform.parent = tempCube.transform;
                    }


                    
					if(tempCube.name != "FPSController")
					{
						tempProject.transform.parent = tempCube.transform;
					}

                }
			}
		}

		//movement
		/*if(lastX != gameObject.transform.position.x)
		{
			if(lastZ != gameObject.transform.position.z)
			{
				lastX = gameObject.transform.position.x;
				lastZ = gameObject.transform.position.z;

				Vector3 cp = this.gameObject.transform.position;
				cp.y += 5;

				Instantiate(bloob, cp, Quaternion.Euler(new Vector3(90, 0, 0)));
			}
		}*/
	}
}
