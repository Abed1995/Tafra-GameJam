using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    
    [SerializeField]
    GameObject taaweza;


    [SerializeField]
    GameObject[] people;


    // Start is called before the first frame update
    void Start()
    {
       
        StartCoroutine(SpawningTaaweza());
        StartCoroutine(SpawningPeople());
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    IEnumerator SpawningTaaweza()
    {
        while (true)
        {
            yield return new WaitForSeconds(4);
            Instantiate(taaweza, new Vector3(Random.Range(-18, 18), -7.81f, 0), Quaternion.identity);
           
        }
        
    }

    IEnumerator SpawningPeople()
    {
        while (true)
        {
            yield return new WaitForSeconds(7);
            Instantiate(people[0], new Vector3(-21.2f, -7.31f, 0), Quaternion.identity);
            
        }

    }


}
