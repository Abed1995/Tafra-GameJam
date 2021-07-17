using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    
    [SerializeField]
    GameObject taaweza;

    [SerializeField]
    GameObject heart;

    [SerializeField]
    GameObject[] people;


    // Start is called before the first frame update
    void Start()
    {
       
        StartCoroutine(SpawningTaawezaandPeople());
        StartCoroutine(SpawningHeart());
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    IEnumerator SpawningTaawezaandPeople()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1, 3));
            Instantiate(taaweza, new Vector3(Random.Range(-18, 18), -7.81f, 0), Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(8, 10));
            Instantiate(people[0], new Vector3(-21.2f, -7.31f, 0), Quaternion.identity);
        }
        
    }

    IEnumerator SpawningHeart()
    {
        while (true)
        {
            yield return new WaitForSeconds( 10);
            Instantiate(heart, new Vector3(Random.Range(-18,18), Random.Range(-7.7f , 9.5f), 0), Quaternion.identity);

        }

    }


}
