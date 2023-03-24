using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountWords : MonoBehaviour
{
    public Text countPoints;

    public void Setup(int score)
    {
        gameObject.SetActive(true);
        countPoints.text = "Напечатано слов: " + score.ToString();
    }

    public void DisableText()
    {
        gameObject.SetActive(false);
    }
}
