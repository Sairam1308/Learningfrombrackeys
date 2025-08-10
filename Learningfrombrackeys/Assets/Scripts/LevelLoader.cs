using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelLoader : MonoBehaviour
{
    public void LoadLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}


