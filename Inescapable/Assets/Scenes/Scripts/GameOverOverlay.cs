using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverOverlay : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject User;
    public Text gameOverTextUI; 

    void Update()
    {
        bool gameIsOver = TimerGameOver.countDownStartValue == -1;
        if (gameIsOver)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
            int keysCollected = ScoringSystem.gameScore;
            if (keysCollected < 10)
            {
                gameOverTextUI.text = "You have collected " + keysCollected + "/10 keys.";
            } else
            {
                gameOverTextUI.text = "You have collected " + keysCollected + "/10 keys but have not made it to the exit.";

            }
            endGame();
        }
    }

    void endGame()
    {
        User.SetActive(false);
        gameOverUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
