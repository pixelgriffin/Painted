using UnityEngine;
using System.Collections;

public class sticky : MonoBehaviour
{

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
            if(collision.gameObject.name == "Cube 1")
                Debug.Log("Colliding enter" + collision.gameObject.name);
            GameObject tempCube = GameObject.Find(collision.gameObject.name);
            transform.parent = tempCube.transform;
        }
    }

    void OnCollisionExit(Collision collision)
    {
      
        if (collision.gameObject.tag == "cube")
            transform.parent = null;
    }
}
