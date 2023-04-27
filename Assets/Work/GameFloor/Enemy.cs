using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 3;
    int currentHealth;
    public static int numberOfEnemies;
    public GameObject done1, done2, done3, done4, done5;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (maxHealth==5)
        {
            if (currentHealth == 4)
                Destroy(done1);
            if (currentHealth == 3)
                Destroy(done2);
            if (currentHealth == 2)
                Destroy(done3);
            if (currentHealth == 1)
                Destroy(done4);
            if (currentHealth == 0)
                Destroy(done5);
        }

        if (maxHealth == 3)
        {
            if (currentHealth == 2) 
                Destroy(done1);
            if (currentHealth == 1)
                Destroy(done2);
            if (currentHealth == 0)
                Destroy(done3);
        }

        if (currentHealth <= 0)
        {
            Die();
            numberOfEnemies++;
            Debug.Log(numberOfEnemies);
        }
    }

    void Die()
    {
        Destroy(this.gameObject);
    }
}
