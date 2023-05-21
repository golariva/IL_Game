using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkToSeller : MonoBehaviour
{
    Coroutine lastCoroutine = null;
    GameObject highlight;
    string greetings = "Свободная касса!";
    public GameObject message;
    Text talk;

    void Start()
    {
        highlight = transform.GetChild(0).gameObject;
        talk = message.transform.GetChild(0).GetComponent<Text>();
    }

    IEnumerator GreetCharacterCoroutine()
    {
        talk.text = "";
        foreach (char letter in greetings)
        {
            talk.text += letter;
            yield return new WaitForSeconds(0.1f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            highlight.SetActive(true);
            message.SetActive(true);
            lastCoroutine = StartCoroutine(GreetCharacterCoroutine());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            highlight.SetActive(false);
            message.SetActive(false);
            if (lastCoroutine != null)
            {
                StopCoroutine(lastCoroutine);
                lastCoroutine = null;
            }
            talk.text = "";
        }
    }
}
