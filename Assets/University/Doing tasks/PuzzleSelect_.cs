using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleSelect_ : MonoBehaviour
{
    public void SetPuzzlePhoto(Image Photo)
    {
        for (int i = 0; i < 36; i++)
        {
            GameObject.Find("Piece (" + i + ")").GetComponent<SpriteRenderer>().sprite = Photo.sprite;
        }
    }
}
