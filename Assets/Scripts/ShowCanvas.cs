using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCanvas : MonoBehaviour
{
    [SerializeField] Canvas canvas;

    public void ChangeCondition()
    {
        canvas.enabled = !canvas.enabled;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && canvas.enabled)
        {
            ChangeCondition();
        }
    }
}
