using System; 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerGameOver : MonoBehaviour
{

    public static int countDownStartValue = 60;
    public Text timerUI;
    public static int lookSlenderDie = 3;

    // Start is called before the first frame update
    void Start()
    {
        countDownTimer();

    }

    void countDownTimer()
    {
        if (countDownStartValue >= 0)
        {
            if(Behaviour.SlenderVisible)
            {
                if(lookSlenderDie > 2)
                {
                    Behaviour.audioData.Play();
                }
                TimeSpan die = TimeSpan.FromSeconds(lookSlenderDie);
                lookSlenderDie--;
            } else
            {
                lookSlenderDie = 3;
            }
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
