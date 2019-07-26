using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public GameObject scoreText;
    public static int gameScore;
    public Text collected10KeysText;


    void Update()
    { 
        scoreText.GetComponent<Text>().text = "Keys: " + gameScore;
        if (gameScore == 8)
        {
            collected10KeysText.text = "You have collected 8 Keys, make your way to the exit!"; 
        }
    }
}
