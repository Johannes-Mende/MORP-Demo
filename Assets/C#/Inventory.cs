using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    #region Singilton

    
    public static Inventory instance;               //https://www.youtube.com/watch?v=HQNl3Ff2Lpo&list=PLPV2KyIb3jR4KLGCCAciWQ5qHudKtYeP7&index=5

    void Awake()
    {
        if(instance != null) 
        {;
            Debug.LogWarning("Mehr als eine instance von Inventory gefunden!");
            return;
        }
        instance = this;
    }
    #endregion 

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;
    public int space = 20;

    public List<Item> items = new List<Item>();

    public bool Add (Item item)
    {
        if (!item.isDefaultItem)
        {
            if(items.Count >= space)
            {
                Debug.Log("Not enoth room");
                return false;
            }
            items.Add(item);
            onItemChangedCallback.Invoke();
        }
        return true;
    }

    public void Remove (Item item)
    {
        items.Remove(item);
    }
}
