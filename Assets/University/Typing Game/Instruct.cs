using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instruct : MonoBehaviour
{
    public GameObject instruction;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        instruction.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Time.timeScale = 1;
            instruction.SetActive(false);
        }
    }
}
