using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndCleaningFloor : MonoBehaviour
{
    public static bool isWin = false;
    public static bool isLoss = true;

    // Update is called once per frame
    void Update()
    {
        if (Enemy.numberOfEnemies == 8)
        {
            isLoss = false;
            isWin = true;
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
        isLoss = true;
        isWin = false;
        Enemy.numberOfEnemies = 0;
    }
}
