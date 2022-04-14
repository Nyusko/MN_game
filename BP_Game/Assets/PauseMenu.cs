using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject PauseButton, pauseMenuUI;

    public void Menu() {
                 if(PauseButton) {
                if(GameIsPaused) {

                Resume();
            } else
    {
        Pause();
    }

            }
    }

    // Update is called once per frame
    void Update()
    {
   
    }
    void Pause() {
        PauseButton.SetActive(false);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    void Resume() {
        PauseButton.SetActive(true);
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void QuitGame() {
        Debug.Log("Hra sa vypína...");
        Application.Quit();
    }
}
