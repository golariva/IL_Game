using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLost : MonoBehaviour
{
    public GameObject win, lost;

    // Start is called before the first frame update
    void Start()
    {
        win.SetActive(false);
        lost.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Fruit.IsLoser)
            lost.SetActive(true);
        if (Fruit.IsWinner)
            win.SetActive(true);
    }
}
