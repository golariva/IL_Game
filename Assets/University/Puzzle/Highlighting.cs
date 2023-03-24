using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlighting : MonoBehaviour
{
    GameObject highlight;

    private void OnEnable()
    {
        highlight = transform.GetChild(0).gameObject;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Frame")
        {
            highlight.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Frame")
        {
            highlight.SetActive(false);
        }
    }
}
