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

            if (taawezaCount < 3)
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
    }

    void InstantiateEyes ()
    {
        if (taawezaCount ==3 && Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(eye, this.transform.position, Quaternion.identity);
            taawezaCount -= 3;
        }
    }
}
