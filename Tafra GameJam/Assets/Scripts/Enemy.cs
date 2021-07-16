using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform player;

    [SerializeField]
    GameObject blackMagic;

    CircleCollider2D cc;

    int health;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        cc = GetComponent<CircleCollider2D>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        StartCoroutine(SpawningBlackMagic());

        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.position);

        if (transform.rotation.x == -90)
        {
            transform.rotation = Quaternion.identity;
        }
        if (transform.position.y < -7.73f )
        {
            transform.position = new Vector3(transform.position.x, -7.73f, transform.position.z);
        }
    }

    IEnumerator SpawningBlackMagic()
    {
        while (true)
        {
            yield return new WaitForSeconds(8);
            Instantiate(blackMagic, this.transform.position, Quaternion.identity);

        }

    }

    IEnumerator DelayComponents()
    {
        cc.enabled = false;
        agent.enabled = false;
        yield return new WaitForSeconds(5);
        agent.enabled = true;
        cc.enabled = true;



    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == ("Eye"))
        {
            health -= 20;
            Destroy(other.gameObject);
            StartCoroutine(DelayComponents());

            Debug.Log(health);
        }
    }
}
