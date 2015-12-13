using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class moveBossScr : MonoBehaviour {

    public List<Vector3> movePoints;
    public float speed;
    public bool move = false;
    int ctr = 0;


    // Use this for initialization
    void Start()
    {
       // movePoints = new List<Vector3>();
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;

        if (move)
        {
            transform.position = Vector3.MoveTowards(transform.position, movePoints[ctr], step);


            if (transform.position == movePoints[ctr])
            {
                move = false;
                ctr++;
            }
        }



    }

}
