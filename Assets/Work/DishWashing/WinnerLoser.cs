using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinnerLoser : MonoBehaviour
{

    public GameObject vin0, vin10, vin20, vin30, vin40, vin50;
    public GameObject realWin0, realWin10, realWin20, realWin30, realWin40, realWin50, end;
    public static int plusPoints, minusPoints;
    // Start is called before the first frame update
    void Start()
    {
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

            if (plusPoints == 0)
                realWin0.SetActive(true);
            if (plusPoints == 1)
                realWin10.SetActive(true);
            if (plusPoints == 2)
                realWin20.SetActive(true);
            if (plusPoints == 3)
                realWin30.SetActive(true);
            if (plusPoints == 4)
                realWin40.SetActive(true);
            if (plusPoints == 5)
                realWin50.SetActive(true);

            end.SetActive(true);
            EndGame.End();
        }
    }
}
