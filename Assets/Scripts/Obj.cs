using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obj : MonoBehaviour
{
    GameObject highlight;
    public int location;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && highlight.activeSelf)
        {
            SceneManager.LoadScene(location);
        }
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
        }
    }
}
