using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        Inventory inventory = collider.GetComponent<Inventory>();
        if (inventory != null)
        {
            inventory.Add(name);
            Destroy(gameObject);
        }
    }
}
