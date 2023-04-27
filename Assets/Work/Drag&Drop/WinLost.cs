using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLost : MonoBehaviour
{
    public GameObject win, lost;

    int done;

    // Start is called before the first frame update
    void Start()
    {
        win.SetActive(false);
        lost.SetActive(false);
        done = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Fruit.IsLoser && done==0)
        {
            lost.SetActive(true);
            GameStats.health -= 0.05f;
            done++;
        }
        if (Fruit.IsWinner && done==0)
        {
            win.SetActive(true);
            if (Fruit.isLost == 1)
                GameStats.budget += 40;
            if (Fruit.isLost == 2)
                GameStats.budget += 30;
            if (Fruit.isLost == 3)
                GameStats.budget += 20;
            if (Fruit.isLost == 4)
                GameStats.budget += 10;
            if (Fruit.isLost == 0)
                GameStats.budget += 50;
            done++;
        }
    }
}
