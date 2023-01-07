using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class IL_PlayerController : MonoBehaviour
{
    [SerializeField] bool hasControl;
    public static IL_PlayerController localPlayer;
    //компоненты
    Rigidbody myRB;
    Transform myAvatar;
    Animator myAnim;
    //движение игрока
    [SerializeField] InputAction WASD;
    Vector2 movementInput;
    [SerializeField] float movementSpeed;
    //цвет игрока
    [SerializeField] Color myColor;
    SpriteRenderer myAvatarSprite;
    [SerializeField] GameObject bodyPrefab;

    //взаимодействие
    [SerializeField] InputAction MOUSE;
    Vector2 mousePositionInput;
    Camera myCamera;
    [SerializeField] InputAction INTERACTION;
    [SerializeField] LayerMask interactLayer;

    private void Awake()
    {
        INTERACTION.performed += Interact;
    }

    private void OnEnable()
    {
        WASD.Enable();
        MOUSE.Enable();
        INTERACTION.Enable();
    }

    private void OnDisable()
    {
        WASD.Disable();
        MOUSE.Disable();
        INTERACTION.Disable();
    }

    //start is called before the first frame update
    void Start()
    {
        if (hasControl)
        {
            localPlayer = this;
        }
        myRB = GetComponent<Rigidbody>();
        myAvatar = transform.GetChild(0);
        myAnim = GetComponent<Animator>();
        myAvatarSprite = myAvatar.GetComponent<SpriteRenderer>();
        if (!hasControl)
            return;
        if (myColor == Color.clear)
            myColor = Color.white;
        myAvatarSprite.color = myColor;
    }

    //update is called once per frame
    void Update()
    {
        if (!hasControl)
            return;
        movementInput = WASD.ReadValue<Vector2>();
        myAnim.SetFloat("Speed", movementInput.magnitude);
        if (movementInput.x != 0)
        {
            myAvatar.localScale = new Vector2(Mathf.Sign(movementInput.x), 1);
        }
        mousePositionInput = MOUSE.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        myRB.velocity = movementInput * movementSpeed;
    }

    public void SetColor(Color newColor)
    {
        myColor = newColor;
        if (myAvatarSprite != null)
        {
            myAvatarSprite.color = myColor;
        }
    }

    void Interact(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            //Debug.Log("Here");
            RaycastHit hit;
            Ray ray = myCamera.ScreenPointToRay(mousePositionInput);
            if (Physics.Raycast(ray, out hit, interactLayer))
            {
                if (hit.transform.tag == "Interactable")
                {
                    if (!hit.transform.GetChild(0).gameObject.activeInHierarchy)
                        return;
                    IL_Interactable temp = hit.transform.GetComponent<IL_Interactable>();
                    temp.PlayMiniGame();
                }
            }
        }
    }
}
