using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public static void End()
    {
        if (Input.GetButton("Fire1"))
        {
            SceneManager.LoadScene("Work");
        }
    }

}
