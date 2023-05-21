using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public static class Inventory
{
    public static Dictionary<Item, int> items = new Dictionary<Item, int>();
    private static int count = 0;

    public static void AddItem(string itemName)
    {
        if (count > 16)
            return;

        Item item = Item.Load(itemName);
        if (!items.ContainsKey(item))
            items.Add(Item.Load(itemName), 1);
        else
            items[item]++;

        count++;
    }

    public static void RemoveItem(string itemName)
    {
        Item item = Item.Load(itemName);
        GameStats.health += item.healthReplenishment;

        if (items[item] > 1)
            items[item]--;
        else
            items.Remove(item);
        count--;
    }
}
