using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item item;

    //public override viod Interact()
    //{
        //base.Interact();
        //Pickup();
    //}

    void Pickup()
    {
        Debug.Log("Picking up" + item.name);
        // Add to inventory
        Destroy(gameObject);
    }

}
