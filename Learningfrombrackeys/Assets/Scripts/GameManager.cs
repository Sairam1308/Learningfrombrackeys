using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded=false;
    public float restartDelay;
    public GameObject levelCompleteUI;
    public GameObject pauseMenuUI;
    public bool pauseMenuUiEnabled = false;

    void Start()
    {
        pauseMenuUI.SetActive(false);
    }

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
            pauseMenuUI.SetActive(true);
            FindObjectOfType<PlayerMovement>().enabled = false;
            pauseMenuUiEnabled = true;
        }
    }
    public void ResumeGame()
    {
        
            pauseMenuUI.SetActive(false);
            FindObjectOfType<PlayerMovement>().enabled = true;
        
    }
}
