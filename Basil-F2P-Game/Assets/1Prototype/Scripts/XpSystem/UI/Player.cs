using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public int ExpGained;

    void OnEnable()
    {
        Debug.Log("ExpGained");
        ExpGained = PlayerPrefs.GetInt("ExpGained");
    }
    
    public void ButtonPressed()
    {
        XPManager.instance.AddXP(ExpGained);
        ExpGained = 0;
        print("ExpLeft" + ExpGained);
    }

    public void awake() 
    {
        ExpGained = PlayerPrefs.GetInt("ExpGained");
        XPManager.instance.AddXP(ExpGained);
    }

    
}
