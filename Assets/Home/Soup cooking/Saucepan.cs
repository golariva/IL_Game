using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.SceneManagement;

public class Saucepan : MonoBehaviour
{
    [SerializeField] private float speed = 3f;

    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private bool isStarted;
    public static int lives = 3;
    public static int score = 20;
    public static bool isWin;
    public static bool isLoss;


    void Start()
    {
        Time.timeScale = 0;
    }

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    void Update()
    {
        if (!isStarted && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 1;
            isStarted = true;
        }

        if (Input.GetButton("Horizontal"))
            RunRL();

        if (isWin || isLoss)
        {
            EndGame();
        }     
    }

    private void RunRL()
    {
        Vector3 dir = transform.right * Input.GetAxis("Horizontal");

        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Poison"))
        {
            lives--;
            if (lives == 0)
            {
                isLoss = true;
            }  
        }

        if (collision.CompareTag("Vegetable"))
        {
            score--;
            if (score == 0)
            {
                isWin = true;
            }
        }
    }

    private void EndGame()
    {
        Time.timeScale = 0;
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 1;
            ResetData();
            SceneManager.LoadScene("Home");
        }
    }

    private void ResetData()
    {
        score = 20;
        lives = 3;
        isWin = false;
        isLoss = false;
    }

}
