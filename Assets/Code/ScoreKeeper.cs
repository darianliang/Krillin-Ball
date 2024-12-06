using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static int scoreCount;

    void Start()
    {
        
    }

    void Update()
    {
        scoreText.text = "Dragon Balls: " + Mathf.Round(scoreCount);
    }
}
