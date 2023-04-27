using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rating : MonoBehaviour
{
    [SerializeField] Text ratingPosition;

    void Update()
    {
        ratingPosition.text = GameStats.rating.ToString() + " место";
    }
}
