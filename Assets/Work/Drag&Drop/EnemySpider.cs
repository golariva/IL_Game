using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpider : MonoBehaviour
{
    public int maxHealth = 3;
    int currentHealth;
    public static int numberOfEnemies;
    public GameObject done1, done2, done3;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth == 2)
            Destroy(done1);
        if (currentHealth == 1)
            Destroy(done2);
        if (currentHealth == 0)
            Destroy(done3);

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
