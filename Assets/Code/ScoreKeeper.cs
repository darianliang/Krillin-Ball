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
        scoreCount = 0;
    }

    void Update()
    {
        scoreText.text = "Dragon Balls: " + scoreCount;
    }
}
