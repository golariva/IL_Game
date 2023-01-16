using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideHearts : MonoBehaviour
{
    GameObject heart1;
    GameObject heart2;
    GameObject heart3;

    void Start()
    {
        heart1 = GameObject.Find("Heart 1");
        heart2 = GameObject.Find("Heart 2");
        heart3 = GameObject.Find("Heart 3");
    }

    void OnGUI()
    {
        if (Saucepan.lives == 2)
            heart3.SetActive(false);

        if (Saucepan.lives == 1)
            heart2.SetActive(false);

        if (Saucepan.lives == 0)
            heart1.SetActive(false);
    }

}
