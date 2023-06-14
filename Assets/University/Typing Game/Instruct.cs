using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instruct : MonoBehaviour
{
    public GameObject instruction;

    void Start()
    {
        Time.timeScale = 0;
        instruction.SetActive(true);
    }

    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Time.timeScale = 1;
            instruction.SetActive(false);
        }
    }
}
