using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EquipmentController : MonoBehaviour
{
    public EquipmentController access;

[Serializable]
    public struct Equippable     //Conmumable
    {
        public string name;
        public int wert;
        public GameObject objekt;
        public GameObject slot;
    }
    
    public List<Equippable> Equipables = new List<Equippable>();
    public List<ItemSlot> ItemSlots  = new List<ItemSlot>();

    void Awake()
    {
        access = this;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void onEquipped(GameObject Obj)
    {
        print("bums"+ Obj.name);
        
        for (int i = 0; i < ItemSlots.Count; i++)
        {
            Obj.name = ;
        }
    }
}
