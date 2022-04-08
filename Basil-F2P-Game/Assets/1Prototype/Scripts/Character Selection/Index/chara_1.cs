using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class chara_1 : MonoBehaviour
{
    public GameObject a;
    //public Text text;
    public int level;

    private void Start() 
    {
        GameObject a =  GameObject.Find("SelectCharacter"); 
        a.GetComponent<SelectCharacter>();
        //text.enabled = false;
        //text.SetActive(false);
    }

    public void ButtonPressed()
    {   
        if(level < 5)
        {
            //text.enabled = true;
            //text.SetActive(true);
        }
        else
        {
            a.GetComponent<SelectCharacter>().SetTo1();
        }
        
    }   

    private void OnEnable() 
    {
        // Gets the Level of the player
        level = PlayerPrefs.GetInt("level");
        
    }
}
