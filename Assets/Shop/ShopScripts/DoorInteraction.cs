using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DoorInteraction : MonoBehaviour
{
    SpriteRenderer door;
    Coroutine lastCoroutine = null;
    public Sprite doorClosed;
    public Sprite doorState1;
    public Sprite doorState2;
    public Sprite doorOpened;

    void Start()
    {
        door = gameObject.GetComponent<SpriteRenderer>();
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
            if (lastCoroutine != null)
            {
                StopCoroutine(lastCoroutine);
            }
            lastCoroutine = StartCoroutine(CloseDoorAnimation());
        }
    }
}
