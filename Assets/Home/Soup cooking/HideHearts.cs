using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideHearts : MonoBehaviour
{
    [SerializeField] GameObject heart1;
    [SerializeField] GameObject heart2;
    [SerializeField] GameObject heart3;

    void Update()
    {
        if (Saucepan.lives == 2)
            heart3.SetActive(false);

        if (Saucepan.lives == 1)
            heart2.SetActive(false);

        if (Saucepan.lives == 0)
            heart1.SetActive(false);
    }

}
