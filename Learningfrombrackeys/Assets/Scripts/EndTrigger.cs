using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    void OnTriggerEnter()
    {
        FindObjectOfType<PlayerMovement>().enabled = false;
        //FindObjectOfType<Score>().enabled = false; 
        Invoke("TestDelay", 2);
    }
    void TestDelay()
    {
        FindObjectOfType<GameManager>().LevelComplete();
    }
}
