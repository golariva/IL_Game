using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public static class Inventory
{
    public static Dictionary<string, int> items = new Dictionary<string, int>();
    public static void AddItem(string itemName)
    {
        if (!items.ContainsKey(itemName))
            items.Add(itemName, 1);
        else if (items[itemName] < 16)
            items[itemName]++;
    }

    public static void RemoveItem(string itemName)
    {
        if (items[itemName] > 1)
            items[itemName]--;
        else
            items.Remove(itemName);
    }
}
