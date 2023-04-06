using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour
{
    [SerializeField] Image bar;
    
    void Update()
    {
        bar.fillAmount = GameStats.health;
    }
}
