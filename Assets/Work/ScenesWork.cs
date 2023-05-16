using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneFloor : MonoBehaviour
{
    GameObject highlight;
    public int location;

    void Update()
    {
        if (GamesWork.floor==0)
        {
            if (Input.GetKeyDown(KeyCode.F) && highlight.activeSelf)
            {
                SceneManager.LoadScene(location);
            }
        }
        
    }

    private void OnEnable()
    {
        if (GamesWork.floor == 0)
        {
            highlight = transform.GetChild(0).gameObject;
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (GamesWork.floor == 0)
        {
            if (other.tag == "Player")
            {
                highlight.SetActive(true);
            }
        }
       
    }

    private void OnTriggerExit(Collider other)
    {
        if (GamesWork.floor == 0)
        {
            if (other.tag == "Player")
            {
                highlight.SetActive(false);
            }
        }
        
    }
}
