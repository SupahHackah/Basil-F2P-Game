using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2OnT : MonoBehaviour
{
    public bool _level2 = false;

    public void OnTriggerEnter(Collider other)
    {
               
         if(other.gameObject.tag == "Player" )
        {
            _level2 = true;
            print("Player has entered level2");
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player" )
        {
            _level2 = false;
            print("Player has exited level2");
        }
    }
    
}
