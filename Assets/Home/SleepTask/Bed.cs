using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed : MonoBehaviour
{
    GameObject highlight;

    private void OnEnable()
    {
        highlight = transform.GetChild(0).gameObject;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            TurnOnHighlight();
            Invoke("TurnOffHighlight", 0.5f);
        }
    }

    private void TurnOnHighlight()
    {
        highlight.SetActive(true);
    }

    private void TurnOffHighlight()
    {
        highlight.SetActive(false);
    }

}
