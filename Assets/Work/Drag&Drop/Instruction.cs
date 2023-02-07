using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instruction : MonoBehaviour
{
    public GameObject instruction;

    // Start is called before the first frame update
    void Start()
    {
        instruction.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            instruction.SetActive(false);
        }
    }
}
