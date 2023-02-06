using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _renderer;

    private Vector2 offset, originalPosition;
    private bool dragging, placed;

    public GameObject place;

    void Awake()
    {
        originalPosition = transform.position;
    }

    void Update()
    {
        if (placed) return;
        if (!dragging) return;

        var mousePosition = GetMousePos();

        transform.position = mousePosition - offset;
    }

    void OnMouseDown()
    {
        dragging = true;
        offset = GetMousePos() - (Vector2)transform.position;
    }

    void OnMouseUp()
    {
        if (Vector2.Distance(transform.position, place.transform.position) < 3)
        {
            transform.position = place.transform.position;
            placed = true;
        }
        else
        {
            transform.position = originalPosition;
            dragging = false;
        }
    }

    Vector2 GetMousePos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
