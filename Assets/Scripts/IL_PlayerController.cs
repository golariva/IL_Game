using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class IL_PlayerController : MonoBehaviour
{
    //компоненты
    Rigidbody myRB;
    Transform myAvatar;
    Animator myAnim;
    //движение игрока
    [SerializeField] InputAction moveButtons;
    Vector2 movementInput;
    [SerializeField] float movementSpeed;

    private void Awake()
    {
        
    }

    private void OnEnable()
    {
        moveButtons.Enable();
    }

    private void OnDisable()
    {
        moveButtons.Disable();
    }

    void Start()
    {
        myRB = GetComponent<Rigidbody>();
        myAvatar = transform.GetChild(0);
        myAnim = GetComponent<Animator>();
    }

    void Update()
    {
        movementInput = moveButtons.ReadValue<Vector2>();
        myAnim.SetFloat("Speed", movementInput.magnitude);
        if (movementInput.x != 0)
        {
            myAvatar.localScale = new Vector2(Mathf.Sign(movementInput.x), 1);
        }
    }

    private void FixedUpdate()
    {
        myRB.velocity = movementInput * movementSpeed;
    }
}
