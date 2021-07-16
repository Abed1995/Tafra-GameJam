using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UiManager : MonoBehaviour
{

    int score;
    public Text scoreText; 
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    public   void UpdateScore()
    {
        score += 10;
        scoreText.text = "Score : " + score;
    }
}
