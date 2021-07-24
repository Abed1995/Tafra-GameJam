using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UiManager : MonoBehaviour
{

    public static  float score;
    public Text scoreText;
    float pointIncreasePerSecond;

    [SerializeField]
    GameObject gameoverpanel;


    [SerializeField]
    GameObject Congratulation;

    Player player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        score = 0;
        
    }

    private void FixedUpdate()
    {
        
       
    }

    // Update is called once per frame
    public void UpdateScore()
    {
        
        score += 10;
        scoreText.text = "Score : " + score;

        if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
        {
            ShowCongratulationPanel();
        }
    }

    public void IncreaseScore()
    {
        if (Player.gameOver == false)
        {
            //score += pointIncreasePerSecond * Time.deltaTime;
            score += 2 * Time.deltaTime;
            scoreText.text = "Score : " + (int)score;
            Debug.Log("HMMMM ");
        }
           


    }

    public void ShowGameOverPanel()
    {
        gameoverpanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void RestartButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
        Player.gameOver = false;
        score = 0;
      
    }

    public void ShowCongratulationPanel()
    {
        Congratulation.SetActive(true);
        Time.timeScale = 0;
    }

}
