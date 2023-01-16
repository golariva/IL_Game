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
        message.text = "������� ������, ����� ���������� � ������������� ����";
    }

    void Update()
    {   
        if (Input.GetKeyDown(KeyCode.Space))
        {
            message.text = "";
        }

        if (Saucepan.isWin)
        {
            message.text = "�� ������� ����������� ���!";
        }

        if (Saucepan.isLoss)
        {
            message.text = "��� �������! ��� ����.";
        }
    }


}
