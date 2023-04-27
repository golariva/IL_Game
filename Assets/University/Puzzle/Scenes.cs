using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public int location;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && PiecesScript.countPieces == 36)
        {
            GameStats.rating -= 18;
            if (GameStats.rating < 1)
                GameStats.rating = 1;
            SceneManager.LoadScene(location);
        }
    }
}
