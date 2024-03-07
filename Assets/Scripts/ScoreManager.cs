using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI scoreNumberText;
     
     
    public void IncrementScore()
    {
         
        int currentScore = int.Parse(scoreNumberText.text);
        currentScore++; 
        scoreNumberText.text = currentScore.ToString();

    }


}
