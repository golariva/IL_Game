using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject obj;
    float randomX;
    Vector2 whereToSpawn;
    [SerializeField]
    private float spawnRate = 2f;
    float nextSpawn = 0.0f;

    void Start()
    {
        
    }

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randomX = Random.Range(-9.05f, 8.85f);
            whereToSpawn = new Vector2(randomX, transform.position.y);
            Instantiate(obj, whereToSpawn, Quaternion.identity);
        }
    }
}
