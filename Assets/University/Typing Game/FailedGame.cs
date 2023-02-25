using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FailedGame : MonoBehaviour
{
    public Text pointsText;

    public void Setup(int score)
    {
        gameObject.SetActive(true);
        pointsText.text = "Напечатано слов: " + score.ToString() + " из 15";
    }
}
