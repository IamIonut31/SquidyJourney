using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject Enemy1, Enemy2, Enemy3, Enemy4;
    public GameObject Point;
    bool hasEnemy = false;

    void Update()
    {
        if(!hasEnemy)
        {
            SpawnEnemy();
            Instantiate(Point, new Vector3(0f, transform.position.y + 3f, -1f), Quaternion.identity);
            hasEnemy = true;
        }
    }

    public void SpawnEnemy()
    {
        int randomNum = Random.Range(1, 5);

        if(randomNum == 1)
        {
            Instantiate(Enemy1, new Vector3(0f, transform.position.y + 6f, -1f), Quaternion.identity);
        }
        if (randomNum == 2)
        {
            Instantiate(Enemy2, new Vector3(0f, transform.position.y + 6f, -1f), Quaternion.identity);
        }
        if (randomNum == 3)
        {
            Instantiate(Enemy3, new Vector3(0f, transform.position.y + 6f, 1f), Quaternion.identity);
        }
        if (randomNum == 4)
        {
            Instantiate(Enemy4, new Vector3(0f, transform.position.y + 6f, -1f), Quaternion.identity);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            hasEnemy = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            hasEnemy = false;
        }
    }
}
