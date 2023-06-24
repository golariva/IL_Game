using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineMovement : MonoBehaviour
{
    public Vector2 leftPosition;
    public Vector2 rightPosition;
    public float step;
    private float progress;

    void Start()
    {
        transform.position = leftPosition;
    }

    void FixedUpdate()
    {
        transform.position = Vector2.Lerp(leftPosition, rightPosition, progress);
        progress += step;
        progress = (float)Math.Round(progress, 2);
        if (progress == 1)
        {
            progress = 0;
            Vector2 temp = rightPosition;
            rightPosition = leftPosition;
            leftPosition = temp;
        }
    }
    
    private void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKeyDown(KeyCode.Space) && other.gameObject.name.Contains("Target"))
        {
            other.gameObject.GetComponent<Image>().enabled = false;
            other.gameObject.transform.name = "Miss";
        }
        else if (Input.GetKeyDown(KeyCode.Space) && other.gameObject.name.Contains("Miss"))
        {
            other.gameObject.transform.parent.gameObject.SetActive(false);
            transform.gameObject.SetActive(false);
        }
    }
}
