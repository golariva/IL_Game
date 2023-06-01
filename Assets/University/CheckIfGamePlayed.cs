using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfGamePlayed : MonoBehaviour
{
    [SerializeField] GameObject puzzle;
    [SerializeField] GameObject pairs;
    [SerializeField] GameObject workbook;
    bool isObjRemovedFromPuzzle = false;
    bool isObjRemovedFromPairs = false;
    bool isObjRemovedFromWorkbook = false;

    void Update()
    {
        if (Scenes.isPlayed && !isObjRemovedFromPuzzle)
        {
            Destroy(puzzle.GetComponent<Obj>());
            isObjRemovedFromPuzzle = true;
        }

        if (PairMain.isPlayed && !isObjRemovedFromPairs)
        {
            Destroy(pairs.GetComponent<Obj>());
            isObjRemovedFromPairs = true;
        }

        if (WorkbookMain.isPlayed && !isObjRemovedFromWorkbook)
        {
            Destroy(workbook.GetComponent<Obj>());
            isObjRemovedFromWorkbook = true;
        }
    }
}
