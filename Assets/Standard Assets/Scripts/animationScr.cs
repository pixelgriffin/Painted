using UnityEngine;
using System.Collections;

public class animationScr : MonoBehaviour {

    public Animation anim;
    void Start()
    {
        anim = GetComponent<Animation>();

        
    }

    void Update()
    {
        anim.Play("Fly forward");
    }
    
}
