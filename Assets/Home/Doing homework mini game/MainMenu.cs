using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] int progress;
    [SerializeField] TextMeshProUGUI progressText;
    public static bool isCompleted;
    [SerializeField] GameObject button;
    [SerializeField] TextMeshProUGUI message;

    void Start()
    {
        message.enabled = false;
    }

    public void ButtonClick()
    {
        progress+=4;
        if (progress == 100)
        {
            isCompleted = true;
        }
    }

    void Update()
    {
        progressText.text = $"Домашняя работа готова на {progress}%";


        if (isCompleted)
        {
            EndTask();
        }
    }

    public void EndTask()
    {
        Time.timeScale = 0;
        button.GetComponent<Button>().interactable = false;
        message.enabled = true;
        message.text = "Задание выполнено";

        if (Input.GetButton("Fire1"))
        {
            Time.timeScale = 1;
            ResetData();
            SceneManager.LoadScene("Home");
        }
    }

    public void ResetData()
    {
        message.enabled = false;
        button.GetComponent<Button>().interactable = true;
        isCompleted = false;
    }
}
