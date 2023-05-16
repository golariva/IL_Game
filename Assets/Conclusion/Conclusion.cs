using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Conclusion : MonoBehaviour
{

    public GameObject budget, health, rating, phrase, mark;
    string[] phrases = {"≈сть два способа прожить жизнь: или так, будто чудес не бывает, или так, будто вс€ жизнь Ч чудо", "Ѕудьте тем изменением, которое вы хотите видеть в мире", "ќднажды ты проснешьс€, но не будет больше времени на то, чтобы сделать то, что ты всегда хотел. —делай это сейчас.", "”спех Ч это умение двигатьс€ от неудачи к неудаче, не тер€€ энтузиазма", "¬ас ломает не груз, а то, как вы его несете"};

    void Start()
    {
        phrase.GetComponent<Text>().text = phrases[Random.Range(0, 4)];
        budget.GetComponent<Text>().text = GameStats.budget.ToString();
        health.GetComponent<Text>().text = $"{GameStats.health * 100}%";
        rating.GetComponent<Text>().text = GameStats.rating.ToString();


        if (GameStats.health >= 0.9f)
        {
            if (GameStats.budget > 100)
            {
                if (GameStats.rating == 1)
                    mark.GetComponent<Text>().text = "10/10";
                else if (GameStats.rating <= 3)
                    mark.GetComponent<Text>().text = "9/10";
                else if (GameStats.rating <= 5)
                    mark.GetComponent<Text>().text = "8/10";
                else if (GameStats.rating <= 10)
                    mark.GetComponent<Text>().text = "7/10";
                else if (GameStats.rating <= 15)
                    mark.GetComponent<Text>().text = "6/10";
                else
                    mark.GetComponent<Text>().text = "5/10";
            }
            else if (GameStats.budget >= 85)
            {
                if (GameStats.rating == 1)
                    mark.GetComponent<Text>().text = "9/10";
                else if (GameStats.rating <= 3)
                    mark.GetComponent<Text>().text = "8/10";
                else if (GameStats.rating <= 5)
                    mark.GetComponent<Text>().text = "7/10";
                else if (GameStats.rating <= 10)
                    mark.GetComponent<Text>().text = "6/10";
                else if (GameStats.rating <= 15)
                    mark.GetComponent<Text>().text = "5/10";
                else
                    mark.GetComponent<Text>().text = "4/10";
            }
            else if (GameStats.budget >= 60)
            {
                if (GameStats.rating == 1)
                    mark.GetComponent<Text>().text = "8/10";
                else if (GameStats.rating <= 3)
                    mark.GetComponent<Text>().text = "7/10";
                else if (GameStats.rating <= 5)
                    mark.GetComponent<Text>().text = "6/10";
                else if (GameStats.rating <= 10)
                    mark.GetComponent<Text>().text = "5/10";
                else if (GameStats.rating <= 15)
                    mark.GetComponent<Text>().text = "4/10";
                else
                    mark.GetComponent<Text>().text = "3/10";
            }
            else if (GameStats.budget >= 40)
            {
                if (GameStats.rating == 1)
                    mark.GetComponent<Text>().text = "6/10";
                else if (GameStats.rating <= 3)
                    mark.GetComponent<Text>().text = "5/10";
                else if (GameStats.rating <= 5)
                    mark.GetComponent<Text>().text = "4/10";
                else if (GameStats.rating <= 10)
                    mark.GetComponent<Text>().text = "3/10";
                else if (GameStats.rating <= 15)
                    mark.GetComponent<Text>().text = "2/10";
                else
                    mark.GetComponent<Text>().text = "1/10";
            }
            else
            {
                if (GameStats.rating == 1)
                    mark.GetComponent<Text>().text = "5/10";
                else if (GameStats.rating <= 3)
                    mark.GetComponent<Text>().text = "4/10";
                else if (GameStats.rating <= 5)
                    mark.GetComponent<Text>().text = "3/10";
                else if (GameStats.rating <= 10)
                    mark.GetComponent<Text>().text = "2/10";
                else if (GameStats.rating <= 15)
                    mark.GetComponent<Text>().text = "1/10";
                else
                    mark.GetComponent<Text>().text = "0/10";
            }
        }

        else if (GameStats.health >= 0.7f)
        {
            if (GameStats.budget > 100)
            {
                if (GameStats.rating == 1)
                    mark.GetComponent<Text>().text = "9/10";
                else if (GameStats.rating <= 3)
                    mark.GetComponent<Text>().text = "8/10";
                else if (GameStats.rating <= 5)
                    mark.GetComponent<Text>().text = "7/10";
                else if (GameStats.rating <= 10)
                    mark.GetComponent<Text>().text = "6/10";
                else if (GameStats.rating <= 15)
                    mark.GetComponent<Text>().text = "5/10";
                else
                    mark.GetComponent<Text>().text = "4/10";
            }
            else if (GameStats.budget >= 85)
            {
                if (GameStats.rating == 1)
                    mark.GetComponent<Text>().text = "8/10";
                else if (GameStats.rating <= 3)
                    mark.GetComponent<Text>().text = "7/10";
                else if (GameStats.rating <= 5)
                    mark.GetComponent<Text>().text = "6/10";
                else if (GameStats.rating <= 10)
                    mark.GetComponent<Text>().text = "5/10";
                else if (GameStats.rating <= 15)
                    mark.GetComponent<Text>().text = "4/10";
                else
                    mark.GetComponent<Text>().text = "3/10";
            }
            else if (GameStats.budget >= 60)
            {
                if (GameStats.rating == 1)
                    mark.GetComponent<Text>().text = "7/10";
                else if (GameStats.rating <= 3)
                    mark.GetComponent<Text>().text = "6/10";
                else if (GameStats.rating <= 5)
                    mark.GetComponent<Text>().text = "5/10";
                else if (GameStats.rating <= 10)
                    mark.GetComponent<Text>().text = "4/10";
                else if (GameStats.rating <= 15)
                    mark.GetComponent<Text>().text = "3/10";
                else
                    mark.GetComponent<Text>().text = "2/10";
            }
            else if (GameStats.budget >= 40)
            {
                if (GameStats.rating == 1)
                    mark.GetComponent<Text>().text = "5/10";
                else if (GameStats.rating <= 3)
                    mark.GetComponent<Text>().text = "4/10";
                else if (GameStats.rating <= 5)
                    mark.GetComponent<Text>().text = "3/10";
                else if (GameStats.rating <= 10)
                    mark.GetComponent<Text>().text = "2/10";
                else if (GameStats.rating <= 15)
                    mark.GetComponent<Text>().text = "1/10";
                else
                    mark.GetComponent<Text>().text = "0/10";
            }
            else
            {
                if (GameStats.rating == 1)
                    mark.GetComponent<Text>().text = "4/10";
                else if (GameStats.rating <= 3)
                    mark.GetComponent<Text>().text = "3/10";
                else if (GameStats.rating <= 5)
                    mark.GetComponent<Text>().text = "2/10";
                else if (GameStats.rating <= 10)
                    mark.GetComponent<Text>().text = "1/10";
                else if (GameStats.rating <= 15)
                    mark.GetComponent<Text>().text = "0/10";
                else
                    mark.GetComponent<Text>().text = "0/10";
            }
        }

        else if (GameStats.health >= 0.5f)
        {
            if (GameStats.budget > 100)
            {
                if (GameStats.rating == 1)
                    mark.GetComponent<Text>().text = "8/10";
                else if (GameStats.rating <= 3)
                    mark.GetComponent<Text>().text = "7/10";
                else if (GameStats.rating <= 5)
                    mark.GetComponent<Text>().text = "6/10";
                else if (GameStats.rating <= 10)
                    mark.GetComponent<Text>().text = "5/10";
                else if (GameStats.rating <= 15)
                    mark.GetComponent<Text>().text = "4/10";
                else
                    mark.GetComponent<Text>().text = "3/10";
            }
            else if (GameStats.budget >= 85)
            {
                if (GameStats.rating == 1)
                    mark.GetComponent<Text>().text = "7/10";
                else if (GameStats.rating <= 3)
                    mark.GetComponent<Text>().text = "6/10";
                else if (GameStats.rating <= 5)
                    mark.GetComponent<Text>().text = "5/10";
                else if (GameStats.rating <= 10)
                    mark.GetComponent<Text>().text = "4/10";
                else if (GameStats.rating <= 15)
                    mark.GetComponent<Text>().text = "3/10";
                else
                    mark.GetComponent<Text>().text = "2/10";
            }
            else if (GameStats.budget >= 60)
            {
                if (GameStats.rating == 1)
                    mark.GetComponent<Text>().text = "6/10";
                else if (GameStats.rating <= 3)
                    mark.GetComponent<Text>().text = "5/10";
                else if (GameStats.rating <= 5)
                    mark.GetComponent<Text>().text = "4/10";
                else if (GameStats.rating <= 10)
                    mark.GetComponent<Text>().text = "3/10";
                else if (GameStats.rating <= 15)
                    mark.GetComponent<Text>().text = "2/10";
                else
                    mark.GetComponent<Text>().text = "1/10";
            }
            else if (GameStats.budget >= 40)
            {
                if (GameStats.rating == 1)
                    mark.GetComponent<Text>().text = "4/10";
                else if (GameStats.rating <= 3)
                    mark.GetComponent<Text>().text = "3/10";
                else if (GameStats.rating <= 5)
                    mark.GetComponent<Text>().text = "2/10";
                else if (GameStats.rating <= 10)
                    mark.GetComponent<Text>().text = "1/10";
                else if (GameStats.rating <= 15)
                    mark.GetComponent<Text>().text = "0/10";
                else
                    mark.GetComponent<Text>().text = "0/10";
            }
            else
            {
                if (GameStats.rating == 1)
                    mark.GetComponent<Text>().text = "3/10";
                else if (GameStats.rating <= 3)
                    mark.GetComponent<Text>().text = "2/10";
                else if (GameStats.rating <= 5)
                    mark.GetComponent<Text>().text = "1/10";
                else if (GameStats.rating <= 10)
                    mark.GetComponent<Text>().text = "0/10";
                else if (GameStats.rating <= 15)
                    mark.GetComponent<Text>().text = "0/10";
                else
                    mark.GetComponent<Text>().text = "0/10";
            }
        }

        else if (GameStats.health >= 0.3f)
        {
            if (GameStats.budget > 100)
            {
                if (GameStats.rating == 1)
                    mark.GetComponent<Text>().text = "7/10";
                else if (GameStats.rating <= 3)
                    mark.GetComponent<Text>().text = "6/10";
                else if (GameStats.rating <= 5)
                    mark.GetComponent<Text>().text = "5/10";
                else if (GameStats.rating <= 10)
                    mark.GetComponent<Text>().text = "4/10";
                else if (GameStats.rating <= 15)
                    mark.GetComponent<Text>().text = "3/10";
                else
                    mark.GetComponent<Text>().text = "2/10";
            }
            else if (GameStats.budget >= 85)
            {
                if (GameStats.rating == 1)
                    mark.GetComponent<Text>().text = "6/10";
                else if (GameStats.rating <= 3)
                    mark.GetComponent<Text>().text = "5/10";
                else if (GameStats.rating <= 5)
                    mark.GetComponent<Text>().text = "4/10";
                else if (GameStats.rating <= 10)
                    mark.GetComponent<Text>().text = "3/10";
                else if (GameStats.rating <= 15)
                    mark.GetComponent<Text>().text = "2/10";
                else
                    mark.GetComponent<Text>().text = "1/10";
            }
            else if (GameStats.budget >= 60)
            {
                if (GameStats.rating == 1)
                    mark.GetComponent<Text>().text = "5/10";
                else if (GameStats.rating <= 3)
                    mark.GetComponent<Text>().text = "4/10";
                else if (GameStats.rating <= 5)
                    mark.GetComponent<Text>().text = "3/10";
                else if (GameStats.rating <= 10)
                    mark.GetComponent<Text>().text = "2/10";
                else if (GameStats.rating <= 15)
                    mark.GetComponent<Text>().text = "1/10";
                else
                    mark.GetComponent<Text>().text = "0/10";
            }
            else if (GameStats.budget >= 40)
            {
                if (GameStats.rating == 1)
                    mark.GetComponent<Text>().text = "3/10";
                else if (GameStats.rating <= 3)
                    mark.GetComponent<Text>().text = "2/10";
                else if (GameStats.rating <= 5)
                    mark.GetComponent<Text>().text = "1/10";
                else if (GameStats.rating <= 10)
                    mark.GetComponent<Text>().text = "0/10";
                else if (GameStats.rating <= 15)
                    mark.GetComponent<Text>().text = "0/10";
                else
                    mark.GetComponent<Text>().text = "0/10";
            }
            else
            {
                if (GameStats.rating == 1)
                    mark.GetComponent<Text>().text = "2/10";
                else if (GameStats.rating <= 3)
                    mark.GetComponent<Text>().text = "1/10";
                else if (GameStats.rating <= 5)
                    mark.GetComponent<Text>().text = "0/10";
                else if (GameStats.rating <= 10)
                    mark.GetComponent<Text>().text = "0/10";
                else if (GameStats.rating <= 15)
                    mark.GetComponent<Text>().text = "0/10";
                else
                    mark.GetComponent<Text>().text = "0/10";
            }
        }

        else
        {
            if (GameStats.budget > 100)
            {
                if (GameStats.rating == 1)
                    mark.GetComponent<Text>().text = "6/10";
                else if (GameStats.rating <= 3)
                    mark.GetComponent<Text>().text = "5/10";
                else if (GameStats.rating <= 5)
                    mark.GetComponent<Text>().text = "4/10";
                else if (GameStats.rating <= 10)
                    mark.GetComponent<Text>().text = "3/10";
                else if (GameStats.rating <= 15)
                    mark.GetComponent<Text>().text = "2/10";
                else
                    mark.GetComponent<Text>().text = "1/10";
            }
            else if (GameStats.budget >= 85)
            {
                if (GameStats.rating == 1)
                    mark.GetComponent<Text>().text = "5/10";
                else if (GameStats.rating <= 3)
                    mark.GetComponent<Text>().text = "4/10";
                else if (GameStats.rating <= 5)
                    mark.GetComponent<Text>().text = "3/10";
                else if (GameStats.rating <= 10)
                    mark.GetComponent<Text>().text = "2/10";
                else if (GameStats.rating <= 15)
                    mark.GetComponent<Text>().text = "1/10";
                else
                    mark.GetComponent<Text>().text = "0/10";
            }
            else if (GameStats.budget >= 60)
            {
                if (GameStats.rating == 1)
                    mark.GetComponent<Text>().text = "4/10";
                else if (GameStats.rating <= 3)
                    mark.GetComponent<Text>().text = "3/10";
                else if (GameStats.rating <= 5)
                    mark.GetComponent<Text>().text = "2/10";
                else if (GameStats.rating <= 10)
                    mark.GetComponent<Text>().text = "1/10";
                else if (GameStats.rating <= 15)
                    mark.GetComponent<Text>().text = "0/10";
                else
                    mark.GetComponent<Text>().text = "0/10";
            }
            else if (GameStats.budget >= 40)
            {
                if (GameStats.rating == 1)
                    mark.GetComponent<Text>().text = "2/10";
                else if (GameStats.rating <= 3)
                    mark.GetComponent<Text>().text = "1/10";
                else if (GameStats.rating <= 5)
                    mark.GetComponent<Text>().text = "0/10";
                else if (GameStats.rating <= 10)
                    mark.GetComponent<Text>().text = "0/10";
                else if (GameStats.rating <= 15)
                    mark.GetComponent<Text>().text = "0/10";
                else
                    mark.GetComponent<Text>().text = "0/10";
            }
            else
            {
                if (GameStats.rating == 1)
                    mark.GetComponent<Text>().text = "1/10";
                else if (GameStats.rating <= 3)
                    mark.GetComponent<Text>().text = "0/10";
                else if (GameStats.rating <= 5)
                    mark.GetComponent<Text>().text = "0/10";
                else if (GameStats.rating <= 10)
                    mark.GetComponent<Text>().text = "0/10";
                else if (GameStats.rating <= 15)
                    mark.GetComponent<Text>().text = "0/10";
                else
                    mark.GetComponent<Text>().text = "0/10";
            }
        }
    }

    void Update()
    {
        GamesWork.food = 0;
        GamesWork.floor = 0;
        GamesWork.fridge = 0;

        GameStats.budget = 100;
        GameStats.health = 0.7f;
        GameStats.rating = 50;
    }
}
