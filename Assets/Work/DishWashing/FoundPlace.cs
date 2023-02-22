using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoundPlace : MonoBehaviour
{
    public GameObject place;
    public GameObject plate;

    public GameObject realPlate;

    void Start()
    {
        place.SetActive(true);
        realPlate.SetActive(false);
    }

    void Update()
    {
        if (Vector2.Distance(plate.transform.position, place.transform.position) < 0.4)
        {
            plate.SetActive(false);

            realPlate.SetActive(true);
        }

    }

}
