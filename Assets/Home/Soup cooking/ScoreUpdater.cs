using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdater : MonoBehaviour
{
    private TextMeshProUGUI message;

    void Start()
    {
        message = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        message.text = "��� ������������� ���� �������� ������� " + Saucepan.score.ToString() + " ������";
    }

}
