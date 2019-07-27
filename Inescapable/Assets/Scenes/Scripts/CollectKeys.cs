using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectKeys : MonoBehaviour
{
    public AudioSource collectSound;


    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        ScoringSystem.gameScore += 1;
        Destroy(gameObject);
    }
}
