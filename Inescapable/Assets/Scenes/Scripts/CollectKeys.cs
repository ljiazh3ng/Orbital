using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectKeys : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        ScoringSystem.gameScore += 1;
        Destroy(gameObject);
    }
}
