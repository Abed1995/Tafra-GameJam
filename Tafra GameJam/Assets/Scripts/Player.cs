using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    float _horizontalInput;
    float _verticalInput;

    [SerializeField]
    float _speed;

    int taawezaCount = 0;

    [SerializeField]
    GameObject eye;

    UiManager uiManager;

    bool gameOver = false;

    int playerHealth = 100;
     
    // Start is called before the first frame update
    void Start()
    {
        uiManager = GameObject.Find("Canvas").GetComponent<UiManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        Move();
        InstantiateEyes();
        Die();
    }
    void Move()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * _speed * _horizontalInput * Time.deltaTime);
        transform.Translate(Vector3.up * _speed * _verticalInput * Time.deltaTime);
    }

   

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == ("Ta3weza"))
        {
          
            Destroy(other.gameObject);

            if (taawezaCount < 1)
            {
                taawezaCount++;
            }

            uiManager.UpdateScore();
        }

        if (other.gameObject.tag == ("Black Magic"))
        {

            Destroy(other.gameObject);

            playerHealth -= 20;

            Debug.Log(playerHealth);
        }

        if (other.gameObject.tag == ("Enemy"))
        {

            Destroy(this.gameObject);

            gameOver = true;

          
        }

        if (other.gameObject.tag == ("Heart"))
        {
            Destroy(other.gameObject);
            playerHealth += 20;
            if (playerHealth >= 100)
            {
                playerHealth = 100;
            }


        }
    }

    void InstantiateEyes ()
    {
        if (taawezaCount == 1 && Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(eye, this.transform.position, Quaternion.identity);
            taawezaCount -= 1;
        }
    }

    void Die()
    {
        if (playerHealth == 0)
        {
            Destroy(this.gameObject);
            gameOver = true; 
        }
    }
}
