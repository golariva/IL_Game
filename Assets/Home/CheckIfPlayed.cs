using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfPlayed : MonoBehaviour
{
    [SerializeField] GameObject bed;
    [SerializeField] GameObject desk;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SleepTaskMain.isPlayed)
        {
            bed.GetComponent<Obj>().enabled = false;
        }

        if (HomeworkMain.isPlayed)
        {
            desk.GetComponent<Obj>().enabled = false;
        }
    }
}
