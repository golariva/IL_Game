using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SocialPlatforms.Impl;

public class Note : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] GameObject bed;
    private Rigidbody2D rb;
    private Animator anim;
    public static bool isTouched = false;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, bed.transform.position , speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Destr"))
        {
            Destroy(gameObject);
            HealthBar.fill -= Time.deltaTime * 5;
            if (HealthBar.fill <= 0)
            {
                SleepTaskMain.isLoss = true;
                GameStats.health -= 0.34f;
            }
        }
    }

    void OnMouseDown()
    {
        speed = 0;
        Destroy(gameObject, 0.3f);
        anim.SetTrigger("Play");
    }
}
