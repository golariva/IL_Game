using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndThisGame : MonoBehaviour
{
    void Update()
    {
        if (Fruit.IsWinner||Fruit.IsLoser)
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        if (Input.GetButton("Fire1"))
        {
            ResetData();
            SceneManager.LoadScene("Work");
        }
    }

    private void ResetData()
    {
        Fruit.IsLoser = false;
        Fruit.IsWinner = false;
        Fruit.isDone = 0;
        Fruit.isLost = 0;
    }
}
