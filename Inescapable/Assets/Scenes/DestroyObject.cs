using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
           //  other.GetComponent<PlayerScript>().points++;
            Destroy(gameObject);
        }
    }
}
