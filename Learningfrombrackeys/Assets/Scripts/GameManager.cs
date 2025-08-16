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


    public void LevelComplete()
    {
        levelCompleteUI.SetActive(true);
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

            pauseMenuUI.SetActive(false);
            FindObjectOfType<PlayerMovement>().enabled = true;
            pauseMenuUiEnabled = false;
            GameObject.Find("LeftButton").GetComponent<Button>().interactable = true;
            GameObject.Find("RightButton").GetComponent<Button>().interactable = true;
        }
    }
}
