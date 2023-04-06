using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class CookingTaskMain : MonoBehaviour
{
    
    private bool isStarted;
    public static bool isWin;
    public static bool isLoss;
    public static bool isGiven;
    [SerializeField] Canvas startMessage;
    [SerializeField] Canvas winningMessage;
    [SerializeField] Canvas lossMessage;
    [SerializeField] TextMeshProUGUI scoreMessage;

    void Start()
    {
        Time.timeScale = 0;
        winningMessage.gameObject.SetActive(false);
        lossMessage.gameObject.SetActive(false);
    }

    void Update()
    {
        UpdateScore();

        if (!isStarted && Input.GetButton("Fire1"))
        {
            Time.timeScale = 1;
            isStarted = true;
            startMessage.gameObject.SetActive(false);
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
        Saucepan.score = 20;
        Saucepan.lives = 3;
        isWin = false;
        isLoss = false;
    }

    void UpdateScore()
    {
        scoreMessage.text = "ƒл€ приготовлени€ супа осталось собрать " + Saucepan.score.ToString() + " овощей";
    }
}
