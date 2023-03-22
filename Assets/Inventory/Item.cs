using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class Item : ScriptableObject
{
    public string Name = "Item";
    public Sprite Icon;
    public int price = 0;

    public static Item Load(string name)
    {
        return Resources.Load("Data/Items/" + name) as Item;
    }
}

