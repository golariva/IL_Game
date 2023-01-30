using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class messageFloorCleaning : MonoBehaviour
{
    private TextMeshProUGUI message;

    // Start is called before the first frame update
    void Start()
    {
        message = GetComponent<TextMeshProUGUI>();
        message.text = "Начальник недоволен чистотой пола.";
    }

    // Update is called once per frame
    void Update()
    {
        if (EndCleaningFloor.isWin)
        {
            message.text = "Вы успешно прибрали пол! Щёлкните, чтобы закончить работу.";
        }

        if (EndCleaningFloor.isLoss)
        {
            message.text = "Начальник недоволен чистотой пола.";
        }
    }
}
