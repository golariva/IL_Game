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
        message.text = "��������� ��������� �������� ����.";
    }

    // Update is called once per frame
    void Update()
    {
        if (EndCleaningFloor.isWin)
        {
            message.text = "�� ������� �������� ���! ٸ������, ����� ��������� ������.";
        }

        if (EndCleaningFloor.isLoss)
        {
            message.text = "��������� ��������� �������� ����.";
        }
    }
}
