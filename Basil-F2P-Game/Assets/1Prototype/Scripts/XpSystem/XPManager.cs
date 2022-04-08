using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class XPManager : MonoBehaviour
{
    public TextMeshProUGUI levelText, currentXPtext, targetXPtext;
    public int level, currentXP, targetXP;

    public static XPManager instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
            
        else
        {
            Destroy(gameObject);
        }
            

        
    }

    private void start() 
    {
        currentXPtext.text = currentXP.ToString();
        targetXPtext.text = targetXP.ToString();
        levelText.text = level.ToString();
    }

    public void AddXP(int xp)
    {
        currentXP += xp;

        // Level up
        while(currentXP >= targetXP)
        {
            currentXP = currentXP - targetXP;
            level++;
            targetXP += targetXP / 20;

            levelText.text = level.ToString();
            targetXPtext.text = targetXP.ToString();
        }

        currentXPtext.text = currentXP.ToString();

    }

    private void OnDisable() 
    {
        PlayerPrefs.SetInt("level", level);
        print("level" + level);
        PlayerPrefs.SetInt("currentXP", currentXP);
        print("currentXP" + currentXP);
        PlayerPrefs.SetInt("targetXP", targetXP);
        print("targetXP" + targetXP);
    }

    private void OnEnable() 
    {
        
        level = PlayerPrefs.GetInt("level");
        levelText.text = level.ToString();

        currentXP = PlayerPrefs.GetInt("currentXP");
        currentXPtext.text = currentXP.ToString();
        
        targetXP = PlayerPrefs.GetInt("targetXP");
        targetXPtext.text = targetXP.ToString();

        print("PlayerPrefs Got");
    }
    
}
