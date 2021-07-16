using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    GameObject taaweza;

   



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawningTaaweza());
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    IEnumerator SpawningTaaweza()
    {
        while (true)
        {
            yield return new WaitForSeconds(8);
            Instantiate(taaweza, new Vector3(Random.Range(-18, 18), -7.81f, 0), Quaternion.identity);
           
        }
        
    }

    


}
