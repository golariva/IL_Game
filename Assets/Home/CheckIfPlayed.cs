using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfPlayed : MonoBehaviour
{
    [SerializeField] GameObject bed;
    [SerializeField] GameObject desk;
    [SerializeField] GameObject stove;
    bool isObjRemovedFromBed = false;
    bool isObjRemovedFromDesk = false;
    bool isObjRemovedFromStove = false;

    void Update()
    {
        if (SleepTaskMain.isPlayed && !isObjRemovedFromBed)
        {
            Destroy(bed.GetComponent<Obj>());
            isObjRemovedFromBed = true;
        }

        if (HomeworkMain.isPlayed && !isObjRemovedFromDesk)
        {
            Destroy(desk.GetComponent<Obj>());
            isObjRemovedFromDesk=true;
        }

        if (CookingTaskMain.isPlayed && !isObjRemovedFromStove)
        {
            Destroy(stove.GetComponent<Obj>());
            isObjRemovedFromStove = true;
        }
    }
}
