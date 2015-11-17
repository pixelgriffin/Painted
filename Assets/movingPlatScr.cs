using UnityEngine;
using System.Collections;

public class movingPlatScr : MonoBehaviour
{
    int ctr = 0;
    Rigidbody rigidbodyRef;
    public float vectorForce;
    Transform platform;
    Transform player;
    public Vector3 point1, point2;
    public bool moveX, moveY, moveZ;
    bool moveFB = true;


    void Awake()
    {
        Application.targetFrameRate = 27;

    }

    // Use this for initialization
    void Start()
    {
        Debug.Log("Starting Movment");
        rigidbodyRef = this.gameObject.GetComponent<Rigidbody>();
        player = this.gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        if (moveX)
        {
            if (transform.position.x >= point1.x)
            {
                moveFB = false;
                transform.position = point1;
            }

            if (transform.position.x <= point2.x)
            {
                moveFB = true;
                transform.position = point2;
            }
        }

        if (moveY)
        {
            if (transform.position.y >= point1.y)
            {
                moveFB = false;
                transform.position = point1;
            }

            if (transform.position.y <= point2.y)
            {
                moveFB = true;
                transform.position = point2;
            }
        }

        if (moveZ)
        {
            if (transform.position.z >= point1.z)
            {
                moveFB = false;
                transform.position = point1;
            }

            if (transform.position.z <= point2.z)
            {
                moveFB = true;
                transform.position = point2;
            }
        }

        if (moveFB)
        {
            //transform.Translate(Vector3.right * Time.deltaTime);
            if (moveX)
            {
                rigidbodyRef.AddForce(new Vector3(1, 0, 0) * vectorForce, ForceMode.Impulse);
            }
            if (moveY)
            {
                rigidbodyRef.AddForce(new Vector3(0, 1, 0) * vectorForce, ForceMode.Impulse);
                Debug.Log("Moving Up");
            }
            if (moveZ)
            {
                rigidbodyRef.AddForce(new Vector3(0, 0, 1) * vectorForce, ForceMode.Impulse);
            }

        }

        if (!moveFB)
        {
            //transform.Translate(Vector3.left * Time.deltaTime);
            if (moveX)
            {
                rigidbodyRef.AddForce(new Vector3(-1, 0, 0) * vectorForce, ForceMode.Impulse);
            }
            if (moveY)
            {
                rigidbodyRef.AddForce(new Vector3(0, -1, 0) * vectorForce, ForceMode.Impulse);
            }
            if (moveZ)
            {

                rigidbodyRef.AddForce(new Vector3(0, 0, -1) * vectorForce, ForceMode.Impulse);

            }


        }

    }





}
