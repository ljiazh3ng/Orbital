using System; 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerGameOver : MonoBehaviour
{

    public static int countDownStartValue = 5;
    public Text timerUI; 

    // Start is called before the first frame update
    void Start()
    {
        countDownTimer();

    }

    void countDownTimer()
    {
        if (countDownStartValue >= 0)
        {
            TimeSpan spanTime = TimeSpan.FromSeconds(countDownStartValue);            
            timerUI.text = spanTime.Minutes + ":" + spanTime.Seconds;
            if (spanTime.Seconds < 10)
            {
                timerUI.text = spanTime.Minutes + ":" + "0" + spanTime.Seconds;
            }
            countDownStartValue--;
            Invoke("countDownTimer", 1.0f);
        }
        else
        {
            timerUI.text = "Game Over!"; 
        }
    }

}
