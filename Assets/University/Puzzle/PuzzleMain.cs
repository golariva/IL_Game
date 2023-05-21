using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class PuzzleMain : MonoBehaviour
{
    public static int countTables = 0;
    public static bool isEnd = false;
    public int location;
    public static bool isPlayed = false;

    void Update()
    {
        if (isEnd && Input.GetKeyDown("Fire1"))
        {
            EndGame();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Frame1")
        {
            countTables += 1;
            if (countTables == 1)
            {
                isEnd = true;
            }
        }
        //Destroy(other.gameObject);
    }

    private void EndGame()
    {
        isPlayed = true;
        ResetData();
        SceneManager.LoadScene(location);
    }

    private void ResetData()
    {
        countTables = 0;
        isEnd = false;
    }
}
