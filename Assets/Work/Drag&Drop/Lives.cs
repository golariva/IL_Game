using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{

    public GameObject firstHeart, secondHeart, thirdHeart, fourdHeart, fifthHeart;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Fruit.isLost == 1)
            Destroy(firstHeart);
        if (Fruit.isLost == 2)
            Destroy(secondHeart);
        if (Fruit.isLost == 3)
            Destroy(thirdHeart);
        if (Fruit.isLost == 4)
            Destroy(fourdHeart);
        if (Fruit.isLost == 5)
            Destroy(fifthHeart);
    }
}
