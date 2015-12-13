using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class checkPointCollider : MonoBehaviour {

    public List<Vector3> movePoints;
    public Renderer rend;
    public float speed;
    int ctr = -1;
    int waitTime = 90;
    bool collid;
    bool move = false;
    public string collName;
    public moveBossScr moveScr;

    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();

  

    }
	
	// Update is called once per frame
	void Update () {
        float step = speed * Time.deltaTime;

        if(move)
        {
            transform.position = Vector3.MoveTowards(transform.position, movePoints[ctr], step);


            if(transform.position == movePoints[ctr])
            {
                rend.enabled = true;
                move = false;
            }
        }

        if(collid)
        {
            waitTime++;
        }

    }

	void OnTriggerEnter(Collider col) {
		if(col.name == collName )
		{
            rend.enabled = false;
            if(waitTime > 80)
            { 
                ctr++;
                collid = false;
                waitTime = 0;
                moveScr.move = true;
            }
            collid = true;
            move = true;
            Debug.Log("collison palyer move true " + collName);
        }
	}
}
