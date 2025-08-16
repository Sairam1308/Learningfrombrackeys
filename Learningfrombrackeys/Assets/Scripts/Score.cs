using System;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public Text finaleScoreText;
    String myScore;

    void Update()
    {
        myScore = player.position.z.ToString("0");

        scoreText.text = myScore;
        finaleScoreText.text = scoreText.text;

    }
}
