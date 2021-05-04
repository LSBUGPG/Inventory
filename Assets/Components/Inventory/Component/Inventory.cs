using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Dictionary<string, int> inventory = new Dictionary<string, int>();

    public void Add(string item)
    {
        if (inventory.ContainsKey(item))
        {
            int count = inventory[item];
            inventory[item] = count + 1;
        }
        else
        {
            inventory.Add(item, 1);
        }
    }

    public List<string> Items()
    {
        return new List<string>(inventory.Keys);
    }

    public int ItemCount(string itemName)
    {
        return inventory[itemName];
    }
}
