using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    [SerializeField] Text moneyAmount;

    void Update()
    {
        moneyAmount.text = GameStats.budget.ToString();
    }
}
