using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCharacter : MonoBehaviour
{
    public int character = 0;

    void start()
    {
        character = 0;
    }

    public void SetTo0()
    {
        character = 0;
    }

    public void SetTo1()
    {
        character = 1;
    }

    public void SetTo2()
    {
        character = 2;
    }
    
    void OnDisable() 
    {
        PlayerPrefs.SetInt("character", character);
    }

    void OnEnable()
    {
        character = PlayerPrefs.GetInt("character");
    }
}
