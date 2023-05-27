using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class HighlightRegulation : MonoBehaviour
{
    [SerializeField] GameObject inventory;
    [SerializeField] Canvas helper;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (inventory.activeSelf || helper.enabled)
        {
            transform.GetChild(0).gameObject.SetActive(false);
        }

        //if (!inventory.activeSelf && !helper.enabled)
        //{
        //    transform.GetChild(0).gameObject.SetActive(true);
        //}
    }
}
