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
    public static int lives = 3;
    public static int score = 20;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    void Update()
    {

        if (Input.GetButton("Horizontal"))
            RunRL();   
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
                CookingTaskMain.isLoss = true;
            }  
        }

        if (collision.CompareTag("Vegetable"))
        {
            score--;
            if (score == 0)
            {
                CookingTaskMain.isWin = true;
                Inventory.AddItem("Soup");
            }
        }
    }
}
