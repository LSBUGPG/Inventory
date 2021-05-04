using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayInventory : MonoBehaviour
{
    public Inventory inventory;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("Inventory");
            List<string> items = inventory.Items();
            foreach (string item in items)
            {
                int count = inventory.ItemCount(item);
                Debug.Log($"{item} : {count}");
            }
        }
    }
}
