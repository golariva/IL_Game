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
    bool isLost = false;
    Coroutine lastCoroutine = null;
    
    bool UncatchedTargets(GameObject bar)
    {
        bool isTarget = false;
        for (int i = 0; i < bar.transform.childCount; i++)
        {
            if (bar.transform.GetChild(i).gameObject.name.Contains("Target"))
            {
                isTarget = true;
                break;
            }
        }
        return isTarget;
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
            lastCoroutine = StartCoroutine(TickerCoroutine(firstMessage));
            way += "A";
            choices.text = "1) 'Привет'\n2) Спросить, почему он смеется";
        }

        if (Input.GetKeyDown(KeyCode.Alpha1) && isWaiting && highlight.activeSelf && way == "A")
        {
            // Отвечаем на взаимодействие.
            isWaiting = false;
            lastCoroutine = StartCoroutine(TickerCoroutine(firstAnswer));
            way += "A";
            choices.text = "1) Попросить шоколадку";
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) && isWaiting && highlight.activeSelf && way == "A")
        {
            isWaiting = false;
            lastCoroutine = StartCoroutine(TickerCoroutine(secondAnswer));
            way += "B";
            choices.text = "";
        }

        if (Input.GetKeyDown(KeyCode.Alpha1) && isWaiting && highlight.activeSelf && way == "AA")
        {
            if (!isLost)
            {
                line.SetActive(true);
                bar.SetActive(true);
            }
            way += "A";
            choices.text = "";
        }

        
        if (isWaiting && highlight.activeSelf && way == "AAA" && !UncatchedTargets(bar) && bar.activeSelf)
        {
            isWaiting = false;
            way += "A";
            bar.SetActive(false);
            line.SetActive(false);
            lastCoroutine = StartCoroutine(TickerCoroutine(secondDegreeAnswer));
        }
        else if (isWaiting && highlight.activeSelf && way == "AAA" && !bar.activeSelf)
        {
            isWaiting = false;
            isLost = true;
            way += "B";
            lastCoroutine = StartCoroutine(TickerCoroutine(secondDegreeAnswer2));
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
            if (lastCoroutine != null)
            {
                StopCoroutine(lastCoroutine);
                lastCoroutine = null;
            }
            window.transform.parent.gameObject.SetActive(false);
            isWaiting = false;
            way = "";
        }
    }
}

