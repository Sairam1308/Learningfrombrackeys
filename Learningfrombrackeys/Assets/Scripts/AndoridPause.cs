using UnityEngine;

public class AndroidPause : MonoBehaviour
{
    public GameObject pausePanel; // assign your pause UI panel here

    void OnApplicationPause(bool pauseStatus)
    {
        if (pauseStatus)
        {
            PauseGame();
        }
        else
        {
            ResumeGame();
        }
    }

    void OnApplicationFocus(bool hasFocus)
    {
        if (!hasFocus)
        {
            PauseGame();
        }
        else
        {
            ResumeGame();
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0f;
        if (pausePanel != null)
            pausePanel.SetActive(true);
        Debug.Log("Game Paused");
    }

    void ResumeGame()
    {
        Time.timeScale = 1f;
        if (pausePanel != null)
            pausePanel.SetActive(false);
        Debug.Log("Game Resumed");
    }
}
