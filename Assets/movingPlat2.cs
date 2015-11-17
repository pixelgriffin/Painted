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

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (moveX)
        {
            if (transform.position.x >= point1.x)
            {
                moveFB = false;
               
            }

            if (transform.position.x <= point2.x)
            {
                moveFB = true;
                
            }
        }

        if (moveY)
        {
            if (transform.position.y >= point1.y)
            {
                moveFB = false;
                Debug.Log("HERE");
            }

            if (transform.position.y <= point2.y)
            {
                moveFB = true;
                Debug.Log("HERE2");

            }
        }

        if (moveZ)
        {
            if (transform.position.z >= point1.z)
            {
                moveFB = false;
               
            }

            if (transform.position.z <= point2.z)
            {
                moveFB = true;
                
            }
        }

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
}
