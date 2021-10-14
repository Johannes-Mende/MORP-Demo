using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Statusbar : MonoBehaviour
{

    public Slider H_slider;
    public Slider M_slider;
    public Slider S_slider;

    public Text H_text;
    public Text M_text;
    public Text S_text;

    // text setzt sich zusammen aus health + / + maxHealth

    void Start()
    {

    }


    void Update()
    {
        
    }

    public void SetMaxHealth(int health)
    {
        H_slider.maxValue = health;
        H_slider.value = health;
    }
    public void SetHealth(int health)
    {
        H_slider.value = health;
    }

    public void SetMaxMana(int mana)
    {
        M_slider.maxValue = mana;
        M_slider.value = mana;
    }
    public void SetMana(int mana)
    {
        M_slider.value = mana;
    }

    public void SetMaxStamina(int stamina)
    {
        S_slider.maxValue = stamina;
        S_slider.value = stamina;
    }
    public void SetStamina(int stamina)
    {
        S_slider.value = stamina;
    }
}
