using UnityEngine;
using System.Collections;

public class movingPlat2 : MonoBehaviour {
    int ctr = 0;
    Rigidbody rigidbodyRef;
    public float vectorForce;
    Transform platform;
    GameObject player;
    public Vector3 point1, point2;
    public bool moveX, moveY, moveZ;
    bool moveFB = true;

	public float waitTime = 2f;
	float time;

    // Use this for initialization
    void Start () {
		time = 0f;
	}
	
	// Update is called once per frame
	void Update () {
	        if (moveX)
	        {
	            if (transform.position.x >= point1.x)
	            {
					if(moveFB == true)
						time = 0;

	                moveFB = false;
	            }

	            if (transform.position.x <= point2.x)
	            {
					if(moveFB == false)
						time = 0;

	                moveFB = true;
	            }
	        }

	        if (moveY)
	        {
	            if (transform.position.y >= point1.y)
	            {
					if(moveFB == true)
						time = 0;

	                moveFB = false;
	            }

	            if (transform.position.y <= point2.y)
	            {
					if(moveFB == false)
						time = 0;

	                moveFB = true;

	            }
	        }

	        if (moveZ)
	        {
	            if (transform.position.z >= point1.z)
	            {
					if(moveFB == true)
						time = 0;

	                moveFB = false;
	            }

	            if (transform.position.z <= point2.z)
	            {
					if(moveFB == false)
						time = 0;

	                moveFB = true;
	            }
	        }

		//else
		//{
			time += Time.deltaTime;
			if(time >= (waitTime + 1))
			{
				//time = 0;

		        if (moveFB)
		        {
		            //transform.Translate(Vector3.right * Time.deltaTime);
		            if (moveX)
		            {
		                transform.Translate(Vector3.right * Time.deltaTime * vectorForce);
		            }
		            if (moveY)
		            {
		                transform.Translate(Vector3.up * Time.deltaTime * vectorForce);
		            }
		            if (moveZ)
		            {
		                transform.Translate(Vector3.forward * Time.deltaTime * vectorForce);
		            }

		        }

		        if (!moveFB)
		        {
		            //transform.Translate(Vector3.left * Time.deltaTime);
		            if (moveX)
		            {
		                transform.Translate(Vector3.left * Time.deltaTime * vectorForce);
		            }
		            if (moveY)
		            {
		                transform.Translate(Vector3.down * Time.deltaTime * vectorForce);
		            }
		            if (moveZ)
		            {

		                transform.Translate(Vector3.back * Time.deltaTime * vectorForce);

		            }
		        }
			}
		//}

    }
}
