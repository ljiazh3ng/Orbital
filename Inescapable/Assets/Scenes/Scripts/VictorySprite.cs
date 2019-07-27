using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class VictorySprite : MonoBehaviour
{
    // Start is called before the first frame update
    public bool FalseEnter = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            if (ScoringSystem.gameScore == 8)
            {
                SceneManager.LoadScene(3);
            } else
            {
                FalseEnter = true;

                Invoke("hideBox", 3.0f);
            }
        }
    }
    void OnGUI()
    {
        if (FalseEnter)
        {
            GUI.skin.label.fontSize = 50;
            GUI.BeginGroup(new Rect(590, 0, 2000, 600));
            // Make a box so you can see where the group is on-screen.
            //GUI.Box(new Rect(0, 0, 700, 400), "");
            GUI.Label(new Rect(600, 400, 1300, 600), "You need to collect all 8 keys before entering");

            GUI.EndGroup();
        }
    }

    void hideBox()
    {
        FalseEnter = false;
    }
}

