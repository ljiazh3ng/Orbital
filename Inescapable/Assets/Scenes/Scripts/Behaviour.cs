using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behaviour : MonoBehaviour
{

    Transform Leader;
    float G_MinDistance;
    public static AudioSource audioData;
    public static bool Found = false;
    public static bool CanMove = true;
    public static bool SlenderVisible = false;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Renderer>().enabled = false;
        Leader = GameObject.FindGameObjectWithTag("Player").transform;
        G_MinDistance = FollowScript.MinDistance - 0.2f;
        audioData = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, Leader.position) <= G_MinDistance)
        {
            this.GetComponent<Renderer>().enabled = false;
            this.GetComponent<Collider>().enabled = false;
        }
        else
        {
            this.GetComponent<Renderer>().enabled = true;
            this.GetComponent<Collider>().enabled = true;
        }

        if (this.GetComponent<Renderer>().isVisible)
        {
            CanMove = false;
        }
        else
        {
            CanMove = true;
        }

        if (this.GetComponent<Renderer>().isVisible)
        {
            SlenderVisible = true;
        }
        else
        {
            SlenderVisible = false;
        }

    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            Found = true;
        }
    }
}
