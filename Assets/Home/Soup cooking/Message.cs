using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Message : MonoBehaviour
{
    private TextMeshProUGUI message;

    void Start()
    {
        message = GetComponent<TextMeshProUGUI>();
        message.text = "Нажмите пробел, чтобы приступить к приготовлению супа";
    }

    void Update()
    {   
        if (Input.GetKeyDown(KeyCode.Space))
        {
            message.text = "";
        }

        if (Saucepan.isWin)
        {
            message.text = "Вы успешно приготовили суп!";
        }

        if (Saucepan.isLoss)
        {
            message.text = "Вот неудача! Суп скис.";
        }
    }


}
