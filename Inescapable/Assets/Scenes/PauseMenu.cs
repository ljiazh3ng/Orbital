using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public static bool UserInOption = false; 
    public GameObject pauseMenuUI;
    public GameObject optionMenuUI;
    public GameObject User;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                if (UserInOption)
                {
                    OptionToPause();
                }
                else
                {
                    Resume();
                }
            } else
            {
                Pause();
            }
        }
    }
    // Resume the game
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        User.SetActive(true);
    }
    // Pause the game
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        User.SetActive(false);
    }

    //Option to Pause
    public void OptionToPause()
    {
        optionMenuUI.SetActive(false);
        pauseMenuUI.SetActive(true);
        UserInOption = false;
    }

    public void Option()
    {
        pauseMenuUI.SetActive(false);
        optionMenuUI.SetActive(true);
        UserInOption = true;
    }
    public void quitGame()
    {
        Application.Quit();
    }
}
