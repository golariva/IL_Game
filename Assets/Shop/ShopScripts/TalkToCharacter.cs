using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkToCharacter : MonoBehaviour
{
    GameObject highlight;
    public GameObject line;
    public GameObject bar;
    GameObject[] targets = new GameObject[2];
    public GameObject window;
    bool isWaiting = false;
    string way = "";
    public string firstMessage;
    public string firstAnswer;
    public string secondAnswer;
    public string secondDegreeAnswer;
    public string secondDegreeAnswer2;
    

    void Start()
    {
        targets[0] = bar.transform.GetChild(0).gameObject;
        targets[1] = bar.transform.GetChild(1).gameObject;
    }

    void Update()
    {
        Text choices = window.transform.GetChild(1).GetComponent<Text>();
        if (Input.GetKeyDown(KeyCode.F) && highlight.activeSelf && way == "")
        {
            // Активируем диалоговое окно.
            window.transform.parent.gameObject.SetActive(true);
            bar.SetActive(false);
            line.SetActive(false);
            window.SetActive(true);
            StartCoroutine(TickerCoroutine(firstMessage));
            way += "A";
        }

        if (Input.GetKeyDown(KeyCode.Alpha1) && isWaiting && highlight.activeSelf && way == "A")
        {
            // Отвечаем на взаимодействие.
            isWaiting = false;
            StartCoroutine(TickerCoroutine(firstAnswer));
            way += "1";
            choices.text = "";
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && isWaiting && highlight.activeSelf && way == "A")
        {
            isWaiting = false;
            StartCoroutine(TickerCoroutine(secondAnswer));
            way += "2";
            choices.text = "1) Попросить шоколадку";
            line.SetActive(true);
            bar.SetActive(true);
        }
        if (isWaiting && highlight.activeSelf && way.Contains("2") && !way.Contains("B") && !targets[0].activeSelf && !targets[1].activeSelf && bar.activeSelf)
        {
            line.SetActive(false);
            bar.SetActive(false);
            isWaiting = false;
            StartCoroutine(TickerCoroutine(secondDegreeAnswer));
            way += "B";
            choices.text = "";

        }
        if (isWaiting && highlight.activeSelf && way.Contains("2") && !line.activeSelf)
        {

        }
        if (isWaiting)
        {
            window.transform.GetChild(1).gameObject.SetActive(true);
        }
        else
        {
            window.transform.GetChild(1).gameObject.SetActive(false);
        }
    }

   //Здесь персонаж передает свое сообщение в диалоговое окно.
   IEnumerator TickerCoroutine(string message)
    {
        Text talk = window.transform.GetChild(0).GetComponent<Text>();
        talk.text = "";
        foreach (char letter in message)
        {
            if (!window.activeSelf)
            {
                break;
            }
            talk.text += letter;
            yield return new WaitForSeconds((float)0.1);
        }
        isWaiting = true;
    }

    private void OnEnable()
    {
        highlight = transform.GetChild(0).gameObject;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            highlight.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            highlight.SetActive(false);
            window.SetActive(false);
            isWaiting = false;
            way = "";
            Text choices = window.transform.GetChild(1).GetComponent<Text>();
            choices.text = "1) Поприветствовать\r\n2) Спросить, почему он смеется";
        }
    }
}

