using UnityEngine;
using System.Collections;

public class sticky : MonoBehaviour
{

    // variables


    // Use this for initialization
    void Start()
    {
        Debug.Log("Sticky Started");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "cube")
        {
            GameObject tempCube = GameObject.Find(collision.gameObject.name);
            transform.parent = tempCube.transform;
            // we are a childof the block
        }
    }

    void OnCollisionExit(Collision collision)
    {
      
        if (collision.gameObject.tag == "cube")
            transform.parent = null;

    }
}
