using System;
using UnityEngine;
using UnityEngine.UI;

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
        finaleScoreText.text = "Score:"+scoreText.text;

    }
}
