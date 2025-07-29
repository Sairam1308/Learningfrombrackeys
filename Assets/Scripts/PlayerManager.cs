using UnityEditor;
using UnityEngine;

public class PlayManager : MonoBehaviour
{
    public GameObject Player, Canvas;

    public void StartGame()
    {
        Debug.Log("ShowPopup clicked");
        Player.SetActive(true);
        Canvas.SetActive(false);
    }
}

//using UnityEditor;
//using UnityEngine;

//public class PopupManager : MonoBehaviour
//{
//    public GameObject InfoPopup, InfoButton;

//    public void ShowPopup()
//    {
//        Debug.Log("ShowPopup clicked");
//        InfoPopup.SetActive(true);
//        InfoButton.SetActive(false);
//    }

//    public void ClosePopup()
//    {
//        InfoPopup.SetActive(false);
//        InfoButton.SetActive(true);
//    }
//}