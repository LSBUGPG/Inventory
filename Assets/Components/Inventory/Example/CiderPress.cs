using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CiderPress : MonoBehaviour
{
    public Transform spawnLocation;
    public Transform cider;
    public Craft craft;

    void Start()
    {
        craft.AddToRecipe("Apple", 2);
        craft.AddToRecipe("Sugar", 1);
    }

    void OnTriggerEnter(Collider collider)
    {
        Inventory inventory = collider.GetComponent<Inventory>();
        if (inventory != null)
        {
            if (craft.MakeItem(inventory))
            {
                Transform newCiderBlock = Instantiate(cider, spawnLocation.position, spawnLocation.rotation);
                newCiderBlock.name = cider.name;
            }
        }
    }
}
