using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordCollider : MonoBehaviour
{
    public static bool isFailed;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        isFailed = true;
    }
}
