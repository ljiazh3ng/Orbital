using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowScript : MonoBehaviour
{
    // Start is called before the first frame update
    Transform Leader;
    float AISpeed = 10;
    //float MaxDistance = 100000;
    public static float MinDistance = 10;


    void Start()
    {
        Leader = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Leader);

        if (Vector3.Distance(transform.position, Leader.position) >= MinDistance && Behaviour.CanMove)
        {
            transform.position += transform.forward * AISpeed * Time.deltaTime;
        }
    }
}