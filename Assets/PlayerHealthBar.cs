using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour
{
    [SerializeField] Image bar;

    void Update()
    {
        bar.fillAmount = GameStats.health;

        if (GameStats.health <= 0)
        {
            GameOver();
        }

        if (GameStats.health > 1f) 
        { 
            GameStats.health = 1f;
        }
            
    }
    
    void GameOver()
    {
        SceneManager.LoadScene(15);
        GameStats.health = 0.7f;
        GameStats.budget = 100;
    }
}
