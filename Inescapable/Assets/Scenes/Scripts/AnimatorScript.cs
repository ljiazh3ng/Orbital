using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorScript : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        anim = this.gameObject.GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
