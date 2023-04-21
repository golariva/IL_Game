using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class SleepTaskMain : MonoBehaviour
{
    [SerializeField] Canvas startMessage;
    [SerializeField] Canvas winningMessage;
    [SerializeField] Canvas lossMessage;
    [SerializeField] Timer timer;
    private bool isStarted;
    public static bool isWin;
    public static bool isLoss;

    void Start()
    {
        Time.timeScale = 0;
        winningMessage.gameObject.SetActive(false);
        lossMessage.gameObject.SetActive(false);
    }

    void Update()
    {
        if (!isStarted && Input.GetButton("Fire1"))
        {
            Time.timeScale = 1;
            isStarted = true;
            startMessage.gameObject.SetActive(false);
        }

        if (timer.timeStart <= 0 && !isLoss)
        {
            isWin = true;
        }
            
        if (isWin || isLoss)
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        Time.timeScale = 0;

        if (isWin)
            winningMessage.gameObject.SetActive(true);
        else
            lossMessage.gameObject.SetActive(true);

        if (Input.GetButton("Fire1"))
        {
            Time.timeScale = 1;
            ResetData();
            SceneManager.LoadScene("Home");
        }
    }

    private void ResetData()
    {
        HealthBar.fill = 1f;
        timer.timeStart = 30;
        isWin = false;
        isLoss = false;
    }
}
