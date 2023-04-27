using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public static class Inventory
{
    public static Dictionary<Item, int> items = new Dictionary<Item, int>();
    public static void AddItem(string itemName)
    {
        Item item = Item.Load(itemName);

        if (!items.ContainsKey(item))
            items.Add(Item.Load(itemName), 1);
        else if (items[item] < 16)
            items[item]++;
    }

    public static void RemoveItem(string itemName)
    {
        Item item = Item.Load(itemName);
        GameStats.health += item.healthReplenishment;

        if (items[item] > 1)
            items[item]--;
        else
            items.Remove(item);
    }
}
