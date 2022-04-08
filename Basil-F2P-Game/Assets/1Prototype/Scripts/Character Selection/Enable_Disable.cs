using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enable_Disable : MonoBehaviour
{
    public GameObject[] _character;
   // public bool _ChActive = true;
    public int character;
    //public int ReviveN = 1;

    private void Awake() 
    {
        _character[0].SetActive(false);
        _character[1].SetActive(false);
        _character[2].SetActive(false);
        _character[character].GetComponent<characterClimbingController>();
    }
    
    // Start is called before the first frame update
    private void Start()
    {
        //_ChActive = true;
        _character[character].SetActive(true);
    }
    /*
    public void Revive()
    {
        _character[character].GetComponent<characterClimbingController>().Health += 5;
        _character[character].SetActive(true);
    }
    


    void Update()
    {
        
        if (_character[character].GetComponent<characterClimbingController>().DeathOccured)
        {
            _character[character].SetActive(false);
            
        }
        else
        {
            _character[character].SetActive(true); 
        }
        
        if(ReviveN == 0)
        {
            Revive();
        }
        else
        {
            _character[character].GetComponent<characterClimbingController>().NoRevive();
        }
        
    }

    void ButtonPressed()
    {
        ReviveN -=1;
        //Revive();
    }
    
 */
    void OnEnable()
    {
        character = PlayerPrefs.GetInt("character");
    }

    void OnDisable() 
    {
        PlayerPrefs.SetInt("character", character);
    }
    
}
