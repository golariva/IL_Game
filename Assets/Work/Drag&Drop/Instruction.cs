using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instruction : MonoBehaviour
{
    public GameObject instruction;

    void Start()
    {
        instruction.SetActive(true);
    }

    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            instruction.SetActive(false);
        }
    }
}
