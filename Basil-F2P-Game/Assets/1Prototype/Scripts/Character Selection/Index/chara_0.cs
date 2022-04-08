using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chara_0 : MonoBehaviour
{
    public GameObject a;

    private void Start() 
    {
        GameObject a =  GameObject.Find("SelectCharacter"); 
        a.GetComponent<SelectCharacter>();
    }

    public void ButtonPressed()
    {
        a.GetComponent<SelectCharacter>().SetTo0();
    }   
}
