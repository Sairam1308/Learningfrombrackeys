using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded=false;
    public float restartDelay;
    public GameObject levelCompleteUI;
    public GameObject pauseMenuUI;
    bool pauseMenuUiEnabled = false;
    public void Start()
    {
        levelCompleteUI.SetActive(false);
        pauseMenuUI.SetActive(false);
    }

    public void LevelComplete()
    {
        levelCompleteUI.SetActive(true);
        Destroy(pauseMenuUI);
        GameObject.Find("Player").GetComponent<AudioSource>().Stop();
    }
 
    public void EndGame()
    {
        if(gameHasEnded==false)
        {
            gameHasEnded= true;
            //Debug.Log("Game Over");
            FindObjectOfType<PlayerMovement>().enabled = true;
            Invoke("Restart", restartDelay);       
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void PauseGame()
    {
        if (pauseMenuUiEnabled == false)
        {
            Time.timeScale = 0f;
            pauseMenuUiEnabled = true;
            pauseMenuUI.SetActive(true);
            FindObjectOfType<PlayerMovement>().enabled = false;
            GameObject.Find("LeftButton").GetComponent<Button>().interactable = false;
            GameObject.Find("RightButton").GetComponent<Button>().interactable = false;

        }
    }
    public void ResumeGame()
    {
        if (pauseMenuUiEnabled == true)
        {
            Time.timeScale = 1f;
            pauseMenuUI.SetActive(false);
            FindObjectOfType<PlayerMovement>().enabled = true;
            pauseMenuUiEnabled = false;
            GameObject.Find("LeftButton").GetComponent<Button>().interactable = true;
            GameObject.Find("RightButton").GetComponent<Button>().interactable = true;
        }
    }
    void OnApplicationPause(bool pauseStatus)
    {
        if (pauseStatus)
        {
            PauseGame();
        }
        //else
        //{
        //    ResumeGame(); //i dont want this, manually i want to resume from resume panel
        //}
    }
    void OnApplicationFocus(bool hasFocus)
    {
        if (!hasFocus)
        {
            PauseGame();
        }
        //else
        //{
        //    ResumeGame();//i dont want this, manually i want to resume from resume panel
        //}
    }
}
