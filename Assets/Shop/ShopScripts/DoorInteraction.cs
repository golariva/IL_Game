using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DoorInteraction : MonoBehaviour
{
    GameObject highlight;
    SpriteRenderer door;
    Coroutine lastCoroutine = null;
    public Sprite doorClosed;
    public Sprite doorState1;
    public Sprite doorState2;
    public Sprite doorOpened;

    void Start()
    {
        highlight = transform.GetChild(0).gameObject;
        door = gameObject.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && highlight.activeSelf)
        {
            SceneManager.LoadScene(1);
        }
    }


    IEnumerator OpenDoorAnimation()
    {
        yield return new WaitForSeconds(0.2f);
        door.sprite = doorState1;
        yield return new WaitForSeconds(0.2f);
        door.sprite = doorState2;
        yield return new WaitForSeconds(0.2f);
        door.sprite = doorOpened;
    }

    IEnumerator CloseDoorAnimation()
    {
        yield return new WaitForSeconds(0.2f);
        door.sprite = doorState2;
        yield return new WaitForSeconds(0.2f);
        door.sprite = doorState1;
        yield return new WaitForSeconds(0.2f);
        door.sprite = doorClosed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            highlight.SetActive(true);
            if (lastCoroutine != null)
            {
                StopCoroutine(lastCoroutine);
            }
            lastCoroutine = StartCoroutine(OpenDoorAnimation());
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
            }
            lastCoroutine = StartCoroutine(CloseDoorAnimation());
        }
    }
}
