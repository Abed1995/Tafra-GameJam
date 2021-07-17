using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UiManager : MonoBehaviour
{

    public  float score;
    public Text scoreText;
    float pointIncreasePerSecond;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        pointIncreasePerSecond = 1f;
    }

    private void FixedUpdate()
    {
        IncreaseScore();
    }

    // Update is called once per frame
    public   void UpdateScore()
    {
        
        score += 10;
        scoreText.text = "Score : " + score;
    }

    public void IncreaseScore()
    {
        score += pointIncreasePerSecond * Time.deltaTime;
        scoreText.text = "Score : " + (int)score;
    }
}
