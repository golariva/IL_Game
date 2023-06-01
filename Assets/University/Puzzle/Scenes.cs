using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public int location;
    public static bool isPlayed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && PiecesScript.countPieces == 36)
        {
            isPlayed = true;
            GameStats.rating -= 18;
            if (GameStats.rating < 1)
                GameStats.rating = 1;
            SceneManager.LoadScene(location);
        }
    }
}
