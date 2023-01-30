using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PiecesScript : MonoBehaviour
{
    private Vector3 rightPosition;
    public bool inRightPosition;
    public bool selected;
    void Start()
    {
        rightPosition = transform.position;
        transform.position = new Vector3(Random.Range(6f, 16f), Random.Range(4, -4));
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, rightPosition) < 0.5f)
        {
            if (!selected)
            {
                if (inRightPosition == false)
                {
                    transform.position = rightPosition;
                    inRightPosition = true;
                    GetComponent<SortingGroup>().sortingOrder = 0;
                }
            }
        }
    }
}
