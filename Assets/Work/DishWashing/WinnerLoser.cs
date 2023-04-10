using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinnerLoser : MonoBehaviour
{

    public GameObject vin0, vin10, vin20, vin30, vin40, vin50;
    public GameObject realWin0, realWin10, realWin20, realWin30, realWin40, realWin50, end;
    public static int plusPoints, minusPoints;

    int done;
    // Start is called before the first frame update
    void Start()
    {
        done = 0;

        minusPoints = 0;
        plusPoints = 0;
        vin0.SetActive(false);
        vin10.SetActive(false);
        vin20.SetActive(false);
        vin30.SetActive(false);
        vin40.SetActive(false);
        vin50.SetActive(false);

        realWin0.SetActive(false);
        realWin10.SetActive(false);
        realWin20.SetActive(false);
        realWin30.SetActive(false);
        realWin40.SetActive(false);
        realWin50.SetActive(false);

        end.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (plusPoints == 0)
            vin0.SetActive(true);
        if (plusPoints == 1)
            vin10.SetActive(true);
        if (plusPoints == 2)
            vin20.SetActive(true);
        if (plusPoints == 3)
            vin30.SetActive(true);
        if (plusPoints == 4)
            vin40.SetActive(true);
        if (plusPoints == 5)
            vin50.SetActive(true);

        if (plusPoints+minusPoints==5)
        {
            vin0.SetActive(false);
            vin10.SetActive(false);
            vin20.SetActive(false);
            vin30.SetActive(false);
            vin40.SetActive(false);
            vin50.SetActive(false);

            if (plusPoints == 0 && done==0)
            {
                realWin0.SetActive(true);
                GameStats.health -= 0.05f;
                done++;
            }
            if (plusPoints == 1 && done == 0)
            {
                realWin10.SetActive(true);
                GameStats.budget += 10;
                done++;
            }
            if (plusPoints == 2 && done == 0)
            {
                realWin20.SetActive(true);
                GameStats.budget += 20;
                done++;
            }
            if (plusPoints == 3 && done == 0)
            {
                realWin30.SetActive(true);
                GameStats.budget += 30;
                done++;
            }
            if (plusPoints == 4 && done == 0)
            {
                realWin40.SetActive(true);
                GameStats.budget += 40;
                done++;
            }
            if (plusPoints == 5 && done == 0)
            {
                realWin50.SetActive(true);
                GameStats.budget += 50;
                done++;
            }

            end.SetActive(true);
            EndGame.End();
        }
    }
}
