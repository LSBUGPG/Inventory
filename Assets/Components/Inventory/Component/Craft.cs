using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Craft : MonoBehaviour
{
    Dictionary<string, int> ingredients = new Dictionary<string, int>();

    public void AddToRecipe(string item, int count)
    {
        ingredients.Add(item, count);
    }

    public bool MakeItem(Inventory inventory)
    {
        bool canMakeItem = false;
        if (inventory.HasItems(ingredients))
        {
            canMakeItem = true;
            foreach (var ingredient in ingredients)
            {
                inventory.Remove(ingredient.Key, ingredient.Value);
            }
        }
        return canMakeItem;
    }
}
