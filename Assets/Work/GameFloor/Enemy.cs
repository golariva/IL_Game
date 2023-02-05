using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 3;
    int currentHealth;
    public static int numberOfEnemies;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

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
