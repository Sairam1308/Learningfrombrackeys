using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded=false;
    public float restartDelay;
    public GameObject levelCompleteUI;
    public GameObject pauseMenuUI;

    public void LevelComplete()
    {
        levelCompleteUI.SetActive(true);
        Debug.Log("Level Complete");
    }
 
    public void EndGame()
    {
        if(gameHasEnded==false)
        {
            gameHasEnded= true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
            
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void PauseGame()
    {
                pauseMenuUI.SetActive(true);
    }


}
