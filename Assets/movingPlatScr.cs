using UnityEngine;
using System.Collections;

public class movingPlatScr : MonoBehaviour {
    int ctr = 0;
    Rigidbody rigidbodyRef;
    public float vectorForce;
    Transform platform;
    Transform player; 

    void Awake()
    {
        Application.targetFrameRate = 27;
        
    }

    // Use this for initialization
    void Start () {
        Debug.Log("Starting Movment");
        rigidbodyRef = this.gameObject.GetComponent<Rigidbody>();
        player = this.gameObject.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {

        if(ctr < 30)
        {
            //transform.Translate(Vector3.right * Time.deltaTime);
            rigidbodyRef.AddForce(new Vector3(1, 0, 0)*vectorForce, ForceMode.Impulse);
        }
        
        if( ctr > 30 )
        {
            //transform.Translate(Vector3.left * Time.deltaTime);
            rigidbodyRef.AddForce(new Vector3(-1, 0, 0) * vectorForce, ForceMode.Impulse);
        }

        if (ctr > 90)
        {
            ctr = 0;
        }

        ctr++;
    }


    void OnTriggerEnter(Collider other)
    {
        platform = other.gameObject.GetComponent<Transform>();
        player.transform.parent = platform.transform;
    }

    void OnTriggerExit(Collider other)
    {
        player.transform.parent = null;
    }


}
