using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HomeworkMain : MonoBehaviour
{
    [SerializeField] int progress;
    [SerializeField] Text progressText;
    public static bool isCompleted;
    [SerializeField] GameObject button;
    [SerializeField] Text message;
    public static bool isPlayed = false;

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
        isPlayed = true;

        if (Input.GetButton("Fire1"))
        {
            Time.timeScale = 1;
            ResetData();
            Inventory.AddItem("Notebook");
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
