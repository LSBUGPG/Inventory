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

    public bool HasItems(Dictionary<string, int> ingredients)
    {
        bool hasIngredients = true;
        foreach (var ingredient in ingredients)
        {
            if (inventory.ContainsKey(ingredient.Key))
            {
                if (inventory[ingredient.Key] < ingredient.Value)
                {
                    hasIngredients = false;
                    break;
                }
            }
            else
            {
                hasIngredients = false;
                break;
            }
        }
        return hasIngredients;
    }

    public void Remove(string item, int count)
    {
        inventory[item] = inventory[item] - count;
    }
}
