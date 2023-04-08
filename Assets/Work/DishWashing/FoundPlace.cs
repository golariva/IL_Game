using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoundPlace : MonoBehaviour
{
    public GameObject person;
    public GameObject food;
    public GameObject askedFood;

    public GameObject happy, sad;

    public GameObject wrongPlace1, wrongPlace2, wrongPlace3, wrongPlace4;

    int isLost;
    int isWin;

    void Start()
    {
        person.SetActive(true);
        happy.SetActive(false);
        sad.SetActive(false);
        askedFood.SetActive(true);
        isWin = 0;
    }

    void Update()
    {
        if (Vector2.Distance(food.transform.position, person.transform.position) < 1.5)
        {
            food.SetActive(false);
            happy.SetActive(true);
            askedFood.SetActive(false);
            if (isWin<1)
            {
                isWin = 1;
                WinnerLoser.plusPoints++;
            }
        }
        else if ((Vector2.Distance(food.transform.position, wrongPlace1.transform.position) < 1)|| (Vector2.Distance(food.transform.position, wrongPlace2.transform.position) < 1) || (Vector2.Distance(food.transform.position, wrongPlace3.transform.position) < 1) || (Vector2.Distance(food.transform.position, wrongPlace4.transform.position) < 1))
        {
            food.SetActive(false);
            sad.SetActive(true);
            askedFood.SetActive(false);
            if (isLost < 1)
            {
                isLost = 1;
                WinnerLoser.minusPoints++;
            }
        }
        else if (food.transform.position.x<-20|| food.transform.position.x>20|| food.transform.position.y<-9|| food.transform.position.y>9)
        {
            food.SetActive(false);
            sad.SetActive(true);
            askedFood.SetActive(false);
            if (isLost < 1)
            {
                isLost = 1;
                WinnerLoser.minusPoints++;
            }
        }
        
    }

}
