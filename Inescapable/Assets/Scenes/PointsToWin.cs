using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsToWin : MonoBehaviour
{
    public int Score;
    public int ScoreToWin;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Points")
        {
            Score++;
            Debug.Log(Score);

        }
    }
    void OnGUI()
    {
        if (Score == 1)
        {
            GUI.skin.label.fontSize = 50;
            GUI.BeginGroup(new Rect(650, 0, 2000, 400));
            // Make a box so you can see where the group is on-screen.
            //GUI.Box(new Rect(0, 0, 700, 400), "");
            GUI.Label(new Rect(660, 0, 1300, 300), "You have collected 1/3 artifact");
            GUI.EndGroup();
        }
    }
}
