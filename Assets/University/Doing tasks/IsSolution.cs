using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class IsSolution : MonoBehaviour
{
    public static int countTables = 0;
    public static bool isEnd = false;
    public int location;

    void Update()
    {
        if (isEnd)
        {
            EndGame();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Frame1") && collision.CompareTag("Frame2"))
        {
            countTables++;
            if (countTables == 1)
            {
                isEnd = true;
            }
        }
        Destroy(collision.gameObject);
    }

    private void EndGame()
    {
            ResetData();
            SceneManager.LoadScene(location);
    }

    private void ResetData()
    {
        countTables = 0;
        isEnd = false;
    }
}
